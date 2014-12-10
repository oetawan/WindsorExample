using OdeToFood.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.Contract
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> AllRestaurants();
    }
}