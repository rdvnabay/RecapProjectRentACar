﻿using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerRepository: IEntityRepository<Customer>,IEntityAsyncRepository<Customer>
    {
    }
}
