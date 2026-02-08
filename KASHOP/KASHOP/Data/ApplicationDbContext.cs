using KASHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace KASHOP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //database for development
            //optionsBuilder.UseSqlServer("Data Source=.;Database=KASHOP;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Command Timeout=30");

            //database for production
            optionsBuilder.UseSqlServer("Data Source=SQL5106.site4now.net;Initial Catalog=db_ac5018_kashope;User Id=db_ac5018_kashope_admin;Password=db123456;Encrypt=True;TrustServerCertificate=True; ");
        }
    }
}
