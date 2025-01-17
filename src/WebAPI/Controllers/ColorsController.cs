﻿using Business.Abstract;
using Entities.Dtos.Color;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorService _colorService;
        public ColorsController(
            IColorService colorService)
        {
            _colorService = colorService;
        }

        //Methods
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] ColorAddDto colorAddDto)
        {
            var result = await _colorService.AddAsync(colorAddDto);
            return result.Success
               ? Ok(result)
               : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int  colorId)
        {
            var result = _colorService.DeleteById(colorId);
            return result.Success
               ? Ok(result)
               : BadRequest(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(int colorId)
        {
            var result = await _colorService.GetByIdAsync(colorId);
            return result.Success
               ? Ok(result)
               : BadRequest(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _colorService.GetAllAsync();
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] ColorUpdateDto colorUpdateDto)
        {
            var result = _colorService.Update(colorUpdateDto);
            return result.Success
              ? Ok(result)
              : BadRequest(result);
        }
    }
}
