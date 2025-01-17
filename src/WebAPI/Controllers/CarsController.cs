﻿using Business.Abstract;
using Entities.Dtos.Car;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CarAddDto carAddDto)
        {
            var result = await _carService.AddAsync(carAddDto);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        [HttpDelete("delete")]
        public  IActionResult Delete(int carId)
        {
            var result =  _carService.DeleteById(carId);
            return result.Success
              ? Ok(result)
              : BadRequest(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _carService.GetAllAsync();
            return result.Success
                          ? Ok(result)
                          : BadRequest(result);
        }

        [HttpGet("getallbybrand")]
        public async Task<IActionResult> GetAllByBrand(int brandId)
        {
            var result = await _carService.GetAllByBrandAsync(brandId);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        [HttpGet("getallbycolor")]
        public async Task<IActionResult> GetAllByColor(int colorId)
        {
            var result = await _carService.GetAllByColorAsync(colorId);
            return result.Success
               ? Ok(result)
               : BadRequest(result);
        }

        [HttpGet("getdetail")]
        public async Task<IActionResult> GetDetail(int carId)
        {
            var result = await _carService.GetDetailAsync(carId);
            return result.Success
                 ? Ok(result)
                 : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(CarUpdateDto carUpdateDto)
        {
            var result = _carService.Update(carUpdateDto);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
    }
}
