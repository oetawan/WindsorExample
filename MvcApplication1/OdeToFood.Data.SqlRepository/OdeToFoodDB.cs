using OdeToFood.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.SqlRepository
{
    public class OdeToFoodDB : DbContext
    {
        public OdeToFoodDB()
            : base("name=OdeToFoodDB")
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}