using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopList.Models;
using ShopList.MiddleTier;

namespace ShopList.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            return View(unitOfWork.Shops.GetAll());
        }

        public ActionResult GetShopProducts(int shopId)
        {
            ViewBag.ShopName = unitOfWork.Shops.Get(shopId).Name;
            return PartialView("ProductsPartial", unitOfWork.Products.GetAll(shopId));
        }
    }
}