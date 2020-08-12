using WebShop.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.DATA.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("==============OrderDetail table============ ");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Product).WithMany(v=>v.OrderDetails).HasForeignKey(k=>k.ProductId);
            builder.HasOne(p => p.Order)
                   .WithMany(w => w.OrderDetails)
                   .HasForeignKey(k => k.OrderId);
        }
    }
}
