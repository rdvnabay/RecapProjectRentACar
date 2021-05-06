﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarDbContext>, IUserDal
    {
        public List<UserForListDto> GetAllDto()
        {
            using (var context = new RentACarDbContext())
            {
                var result = from u in context.Users
                             select new UserForListDto
                             {
                                 Id = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status
                             };
                return result.ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentACarDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        } 
    }
}