using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopList.Models;
using System.Data.Entity;

namespace ShopList.MiddleTier
{
    public class ShopRepository
    {
        AppDbContext db;

        public ShopRepository(AppDbContext context)
        {
            db = context;
        }

        public void Create(Shop item)
        {
            db.Shops.Add(item);
        }

        public Shop Get(int id)
        {
            return db.Shops.Find(id);
        }

        public IEnumerable<Shop> GetAll()
        {
            return db.Shops;
        }

        public void Update(Shop item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shop item = Get(id);
            if (item != null)
                db.Shops.Remove(item);
        }
    }
}