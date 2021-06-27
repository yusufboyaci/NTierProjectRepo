using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.CORE.Mapping
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("ID");
            builder.Property(x => x.Status).IsRequired(true);//Nullable yapmak için içine false yaz


            builder.Property(x => x.CreatedComputerName).HasColumnName("Created Computer Name").IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnName("Created Date").IsRequired(false);
            builder.Property(x => x.CreatedADUserName).HasColumnName("Created AD Name").IsRequired(false);
            builder.Property(x => x.CreatedBy).HasColumnName("Created By").IsRequired(false);
            builder.Property(x => x.CreatedIP).HasColumnName("Created IP").IsRequired(false);


            builder.Property(x => x.ModifiedComputerName).HasColumnName("Modified Computer Name").IsRequired(false);
            builder.Property(x => x.ModifiedDate).HasColumnName("Modified Date").IsRequired(false);
            builder.Property(x => x.ModifiedComputerName).HasColumnName("Modified AD Name").IsRequired(false);
            builder.Property(x => x.ModifiedComputerName).HasColumnName("Modified By").IsRequired(false);
            builder.Property(x => x.ModifiedComputerName).HasColumnName("Modified IP").IsRequired(false);



        }
    }
}
