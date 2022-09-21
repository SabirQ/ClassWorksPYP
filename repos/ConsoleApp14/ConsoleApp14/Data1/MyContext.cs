using ConsoleApp14.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Data1
{
    public class MyContext:DbContext
    {
     
        public virtual DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=class09_09;trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(model => {
                model.HasKey(prop => prop.Id);
                model.Property(prop => prop.Name).HasMaxLength(200).IsRequired(false);
                model.Property(prop => prop.Id).HasMaxLength(200).IsRequired(true);
                model.Property(prop => prop.Code ).HasMaxLength(2).IsRequired(false);
                model.Property(prop => prop.Name ).HasMaxLength(200).IsRequired(false);
                model.Property(prop => prop.Phone).HasMaxLength(30).IsRequired(false);
                model.Property(prop => prop.ISO ).HasMaxLength(200).IsRequired(false);
                model.Property(prop => prop.Capital) .HasMaxLength(200).IsRequired(false);
                model.Property(prop => prop.Currency).HasMaxLength(5).IsRequired(false);
                model.Property(prop => prop.Continent).HasMaxLength(200).IsRequired(false);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
