using ApiFirstLesson.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFirstLesson.FluentApiMap
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.Property(p => p.CategoryName).HasMaxLength(25).IsRequired(true);
            builder.Property(p => p.Description).HasMaxLength(500).HasColumnType("nvarchar").IsRequired(true);

        }
    }
}
