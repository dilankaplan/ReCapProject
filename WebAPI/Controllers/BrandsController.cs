﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet ("getall")]
        public IActionResult Get()
        {
            var result = _brandService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int brandId)
        {
            var result = _brandService.GetById(brandId);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(brand);
        }
        [HttpPut("update")]
        public IActionResult Put(Brand brand)
        {
            var result = _brandService.Update(brand);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
