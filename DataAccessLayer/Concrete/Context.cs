using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    internal class Context : DbContext
    {
        //Bağlantı Adresi için gerekli konfigürasyon kodları
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9D1JVJE\\SQLEXPRESS;database=Db_CoreProject;intigrated security=true");
        }

    }
}
