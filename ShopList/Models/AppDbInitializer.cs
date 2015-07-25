using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopList.Models
{
    public class AppDbInitializer: DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Shops.Add(new Shop
            {
                Name = "Shop1",
                Address = "Default Street, 1",
                WorkHours = "10:00 - 20:00"
            });
            context.Shops.Add(new Shop
            {
                Name = "Shop2",
                Address = "Default Street, 2",
                WorkHours = "8:00 - 20:00"
            });
            context.Shops.Add(new Shop
            {
                Name = "Shop3",
                Address = "Default Street, 3",
                WorkHours = "9:00 - 22:00"
            });

            context.Products.Add(new Product
            {
                Name = "Product1",
                Description = "Default description for Product1",
                ShopId = 1
            });
            context.Products.Add(new Product
            {
                Name = "Product2",
                Description = "Default description for Product2",
                ShopId = 2
            });
            context.Products.Add(new Product
            {
                Name = "Product3",
                Description = "Default description for Product3",
                ShopId = 2
            });
            context.Products.Add(new Product
            {
                Name = "Product4",
                Description = "Default description for Product4",
                ShopId = 3
            });
            context.Products.Add(new Product
            {
                Name = "Product5",
                Description = "Default description for Product5",
                ShopId = 3
            });
            context.Products.Add(new Product
            {
                Name = "Product6",
                Description = "Default description for Product6",
                ShopId = 3
            });

            base.Seed(context);
        }
    }
}