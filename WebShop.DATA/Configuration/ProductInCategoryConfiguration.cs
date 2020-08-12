using WebShop.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.DATA.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("===========Product In Categories!==========");
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.HasOne(t => t.Product)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(t => t.ProductId);
            builder.HasOne(t => t.Category)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(t => t.CategoryId);
        }
    }
}
