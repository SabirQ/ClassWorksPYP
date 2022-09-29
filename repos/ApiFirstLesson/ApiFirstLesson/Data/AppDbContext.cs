using ApiFirstLesson.FluentApiMap;
using ApiFirstLesson.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiFirstLesson.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(p=>p.CategoryName)
                .HasMaxLength(25)
                .IsRequired(true);

            modelBuilder.Entity<Category>()
                .Property(p => p.Description)
                .HasMaxLength(500)
                .IsRequired(false)
                .HasColumnType("nvarchar");

            //one by one

            //modelBuilder.ApplyConfiguration(new ProductMapping());
            //modelBuilder.ApplyConfiguration(new CategoryMapping());

            //all in assembly 

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
