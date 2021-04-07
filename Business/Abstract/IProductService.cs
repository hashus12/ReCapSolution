﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Car> GetAll();

        List<Car> GetByBrandId(string brandId);

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

    }
}
