﻿using System.Diagnostics;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return Ok("GetAll");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok("GetOne");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Users users)
        {
            return Ok("Create" + users.Name);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Users users)
        {
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }
    }
}



