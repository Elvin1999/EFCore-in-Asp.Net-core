using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Category = "Telefon", Name = "Samsung A7", Price = 1200 },
                    new Product() { Category = "Telefon", Name = "Samsung A10", Price = 400 },
                    new Product() { Category = "Telefon", Name = "Samsung A80", Price = 1800 }
                    );
                context.SaveChanges();
            }
        }
    }
}
