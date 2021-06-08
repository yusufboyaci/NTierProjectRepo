using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Mapping;
using NTierProject.ENTITIES.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Mapping
{
    public class ProductMap : CoreMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.NoAction);//Önemli Cascade engellemek için kullanılır
            base.Configure(builder);
        }

    }
}
