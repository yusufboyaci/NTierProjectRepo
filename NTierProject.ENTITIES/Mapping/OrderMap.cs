﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Mapping;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Mapping
{
    public class OrderMap : CoreMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.NoAction);//OnDelete(DeleteBehavior.NoAction) Önemli Cascade engellemek için kullanılır
            base.Configure(builder);
        }

    }
}
