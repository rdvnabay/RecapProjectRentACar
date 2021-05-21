﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>,IEntityAsyncRepository<Car>
    {
        CarDto GetDetails(int carId);
        List<CarDto> GetAllDto();
    }
}
