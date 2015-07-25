using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopList.Models;

namespace ShopList.MiddleTier
{
    public class UnitOfWork
    {
        AppDbContext db = new AppDbContext();

        ShopRepository shopRepository;

        ProductRepository productRepository;

        public ShopRepository Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(db);
                return shopRepository;
            }
        }

        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}