﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos.Rental;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRentalRepository : IEntityRepository<Rental>,IEntityAsyncRepository<Rental>
    {
        List<RentalDto> GetRentAllByCustomer(int carId, int customerId);
        List<RentalDto> GetAllRentalWithCustomerAndBrand();
        Task<List<RentalDto>> GetAllRentalWithCustomerAndBrandAsync();
        Task<RentalDto> GetRentalWithCustomerAndBrandAsync(int rentalId);
    }
}
