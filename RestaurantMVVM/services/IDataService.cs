﻿using RestaurantMVVM.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMVVM.services
{
    interface IDataService
    {
        List<Dish> GetDishes();
    }
}
