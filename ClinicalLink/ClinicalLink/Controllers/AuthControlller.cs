﻿using ApplicationService.Interface;
using Domain.Entidades;
using DomainService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthControlller : Controller
    {
       /* [HttpPost]
        public async Task<ActionResult<>>   Registrar(string username, string password)
        {
  
           
            if (username == "leo" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Usuario());
                return Ok(token);
            }
            return BadRequest();
        }*/
    }
}
