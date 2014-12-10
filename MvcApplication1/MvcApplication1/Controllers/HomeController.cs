using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using OdeToFood.Data.Contract;
using Microsoft.Practices.ServiceLocation;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            IRestaurantRepository restoRepo = ServiceLocator.Current.GetInstance<IRestaurantRepository>();
            var restaurants = restoRepo.AllRestaurants();
            return View(restaurants);
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