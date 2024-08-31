using Domain.Entidades;
using DomainService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthControlller : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            //var user = 
           
            if (username == "leo" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Usuario());
                return Ok(token);
            }
            return BadRequest();
        }
    }
}
