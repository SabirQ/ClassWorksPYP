using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Category.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<MicroservicePYP.Domain.Entities.Category>
    {
        public void Configure(EntityTypeBuilder<MicroservicePYP.Domain.Entities.Category> builder)
        {
            //builder.ToTable("Categories");
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(true);
        }
    }

}
