using OdeToFood.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.SqlRepository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        OdeToFoodDB _db;
        public RestaurantRepository()
        {
            _db = new OdeToFoodDB();
        }
        public IEnumerable<Entity.Restaurant> AllRestaurants()
        {
            return _db.Restaurants.ToList();    
        }
    }
}