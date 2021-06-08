using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Mapping;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Mapping
{
    public class CategoryMap : CoreMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired(true);
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID);
            base.Configure(builder);
        }
    }
}
