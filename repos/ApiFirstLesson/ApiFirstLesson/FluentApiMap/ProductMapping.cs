using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFirstLesson.FluentApiMap
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products","dbo");
            builder.Property(p => p.ProductName).HasColumnType("nvarchar").HasMaxLength(40).IsRequired(true);
            builder.Property(p => p.QuantityPerUnit).HasColumnType("nvarchar").HasMaxLength(20).IsRequired(false);
            builder.Property(p => p.UnitPrice).HasColumnType("money").IsRequired(false);
            builder.Property(p => p.UnitsInStock).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.UnitsOnOrder).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.ReorderLevel).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Discontinued).HasColumnType("bit").IsRequired(true);

            //relation
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);
        }
    }
}
