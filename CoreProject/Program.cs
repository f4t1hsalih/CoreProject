using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Program.cs dosyas�, ASP.NET Core uygulaman�n ba�lang�� noktas�d�r.
// Ba��ml�l�klar�n y�netimi burada yap�land�r�l�r. Otomatik DI deste�i olsa da,
// ba��ml�l�klar�n do�ru �ekilde tan�mlanmas�n� sa�lamak, uygulaman�n �al���rken 
// hata almamas� i�in gereklidir. Hangi interface'in hangi implementasyonu kulland��� 
// a��k�a belirtildi�i i�in kodun anla��labilirli�i artar. Bu yap�, gelecekteki 
// de�i�ikliklerde hata riski azaltarak, uygulaman�n genel mimarisini daha 
// sa�lam ve s�rd�r�lebilir hale getirir.

// Service'leri ekle
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IExperienceDal, EfExperienceDal>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IPortfolioDal, EfPortfolioDal>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<ISkillDal, EfSkillDal>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

// Generic Service'leri ekle
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IMessageService, MessageManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<ISkillService, SkillManager>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

// Add services to the container.
builder.Services.AddControllersWithViews(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.AccessDeniedPath = "/Admin/Login/";
        options.LoginPath = "/Admin/Login/";
        options.LogoutPath = "/Admin/LogOut/";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MainPage}/{action=Index}/{id?}");

app.Run();
