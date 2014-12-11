using OdeToFood.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace OdeToFood.Service.Contract
{
    [ServiceContract]
    public interface IRestaurantService
    {
        [OperationContract]
        Restaurant[] FindAllRestaurants();
    }
}