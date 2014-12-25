using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using NJA.Models;

namespace NJA.Controllers
{
    public class HomeController : Controller
    {

        private Product[] products = {
                            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                            };
        private IValueCalculator calc;
        
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.TotalValue = totalValue;
            return View();
//            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
