﻿using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi93.Services.IServices;
using WebApi93.Services.Services;

namespace WebApi93.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorServices _autorServices;
        public AutoresController(IAutorServices autorServices)
        {
            _autorServices = autorServices;
        }

        [HttpGet(Name = "GetListAutores")]
        public async Task<IActionResult> GetListAutores()
        {
            return Ok (await _autorServices.GetAutores());
        }

        [HttpPost]
        public async Task<IActionResult> CrearAutores(Autor autor)
        {
            return Ok(await _autorServices.CrearAutores(autor));
        }
    }
}
