using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace WebShop.DATA.EF
{
    public class WebShopDbContextFactory : IDesignTimeDbContextFactory<WebShopDbContext>
    {
        public WebShopDbContext CreateDbContext(string[] args)
        {
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WebShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<WebShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebShopDbContext(optionsBuilder.Options);
        }
    }
}
