﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<Brand> GetById(int brandId);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Task<List<Brand>>> GetAllAsync();
    }
}