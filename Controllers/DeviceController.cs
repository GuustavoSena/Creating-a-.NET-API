﻿namespace MyFirstApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;
using System.Linq.Expressions;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var laptop = new Laptop();

        var test = laptop.Hello();

        var model = laptop.GetBrand();

        return Ok(model);
    }
}