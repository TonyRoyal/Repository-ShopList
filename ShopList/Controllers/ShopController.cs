using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopList.Models;
using ShopList.MiddleTier;

namespace ShopList.Controllers
{
    public class ShopController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Shop> GetAllShops()
        {
            return unitOfWork.Shops.GetAll();
        }

        public IEnumerable<Product> GetProducts(int id)
        {
            return unitOfWork.Products.GetAll(id);
        }
    }
}