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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _colorService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int colorId)
        {
            var result = _colorService.GetById(colorId);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Color color)
        {
            var result = _colorService.Add(color);
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
