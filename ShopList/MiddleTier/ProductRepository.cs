using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopList.Models;
using System.Data.Entity;

namespace ShopList.MiddleTier
{
    public class ProductRepository
    {
        AppDbContext db;

        public ProductRepository(AppDbContext context)
        {
            db = context;
        }

        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public IEnumerable<Product> GetAll(int shopId)
        {
            return db.Products.Where(p => p.ShopId == shopId);
        }

        public void Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product item = Get(id);
            if (item != null)
                db.Products.Remove(item);
        }
    }
}