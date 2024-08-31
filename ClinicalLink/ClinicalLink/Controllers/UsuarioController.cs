using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entidades;
using ClinicalLink.Infrastructure;
using ApplicationService.Interface;


namespace Application.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioApplication _usuariosRepository;

        public UsuarioController(IUsuarioApplication usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            try
            {
                var usuario = _usuariosRepository.GetUsuarios();
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            try
            {
                var usuario = _usuariosRepository.GetUsuario(id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUsuario(Usuario usuario)
        {
            try
            {
                _usuariosRepository.InsertUsuario(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateUsuario(Usuario usuario)
        {
            try
            {
                _usuariosRepository.UpdateUsuario(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                _usuariosRepository.DeleteUsuario(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
