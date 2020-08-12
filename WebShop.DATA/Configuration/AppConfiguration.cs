using WebShop.DATA.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.DATA.Configuration
{
    public class AppConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(o => o.Key);
            builder.Property(p => p.Value)
                .IsRequired(true);
        }
    }
}
