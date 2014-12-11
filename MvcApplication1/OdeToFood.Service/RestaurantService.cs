using Microsoft.Practices.ServiceLocation;
using OdeToFood.Data.Contract;
using OdeToFood.Entity;
using OdeToFood.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Service
{
    public class RestaurantService : IRestaurantService
    {
        public IRestaurantRepository RestaurantRepository { get; set; }

        public Restaurant[] FindAllRestaurants()
        {
            RestaurantRepository = ServiceLocator.Current.GetInstance<IRestaurantRepository>();
            return RestaurantRepository.AllRestaurants().ToArray();
        }
    }
}