﻿using AutoMapper;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Dtos.Brand;
using Entities.Dtos.Car;
using Entities.Dtos.CarImage;
using Entities.Dtos.Color;
using Entities.Dtos.Customer;
using Entities.Dtos.OperationClaim;
using Entities.Dtos.Rental;
using Entities.Dtos.User;

namespace Business.Helpers
{
    public class AutoMapperHelper:Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, BrandAddDto>().ReverseMap();
            CreateMap<Brand, BrandUpdateDto>().ReverseMap();
          
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Car, CarAddDto>().ReverseMap();
            CreateMap<Car, CarDetailDto>().ReverseMap();
            CreateMap<Car, CarUpdateDto>().ReverseMap();

            CreateMap<CarImage, CarImageDto>().ReverseMap();
            CreateMap<CarImage, CarImageAddDto>().ReverseMap();
            CreateMap<CarImage, CarImageUpdateDto>().ReverseMap();

            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Color, ColorAddDto>().ReverseMap();
            CreateMap<Color, ColorUpdateDto>().ReverseMap();

            CreateMap<Rental, RentalAddDto>().ReverseMap();
            CreateMap<Rental, RentalDto>().ReverseMap();
            CreateMap<Rental, RentalUpdateDto>().ReverseMap();


            CreateMap<Customer, CustomerAddDto>().ReverseMap();
            CreateMap<OperationClaim, OperationClaimDto>().ReverseMap();
           
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<CarAddDto, CarImageAddDto>().ReverseMap();

        }
    }
}
