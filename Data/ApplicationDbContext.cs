using CategoryMVCTask.Models;
using Microsoft.EntityFrameworkCore;



    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;database=mvc18;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
