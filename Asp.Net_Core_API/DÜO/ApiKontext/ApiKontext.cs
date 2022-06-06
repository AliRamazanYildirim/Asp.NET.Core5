using Asp.Net_Core_API.DÜO.ApiEinheit;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net_Core_API.DÜO.ApiKontext
{
    public class ApiKontext:DbContext
    {
        public DbSet<Kategorie> Kategorien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=THINKPAD;Initial Catalog=SuperMappe2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
