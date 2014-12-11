using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using Microsoft.Practices.ServiceLocation;
using OdeToFood.Service.Contract;
using OdeToFood.Service.Client;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IRestaurantService RestaurantService { get; set; }

        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            var restaurants = RestaurantService.FindAllRestaurants();
            return View(restaurants.AsEnumerable());
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