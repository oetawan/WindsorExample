using OdeToFood.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace OdeToFood.Service.Client
{
    public class RestaurantServiceClient : ClientBase<IRestaurantService>, IRestaurantService
    {
        public OdeToFood.Entity.Restaurant[] FindAllRestaurants()
        {
            try
            {
                var result = Channel.FindAllRestaurants();
                return result;
            }
            catch (Exception)
            {
                Abort();
                throw;
            }
            finally
            {
                //Close();
            }
        }
    }
}