using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Program.cs dosyasý, ASP.NET Core uygulamanýn baþlangýç noktasýdýr.
// Baðýmlýlýklarýn yönetimi burada yapýlandýrýlýr. Otomatik DI desteði olsa da,
// baðýmlýlýklarýn doðru þekilde tanýmlanmasýný saðlamak, uygulamanýn çalýþýrken 
// hata almamasý için gereklidir. Hangi interface'in hangi implementasyonu kullandýðý 
// açýkça belirtildiði için kodun anlaþýlabilirliði artar. Bu yapý, gelecekteki 
// deðiþikliklerde hata riski azaltarak, uygulamanýn genel mimarisini daha 
// saðlam ve sürdürülebilir hale getirir.

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
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MainPage}/{action=Index}/{id?}");

app.Run();
