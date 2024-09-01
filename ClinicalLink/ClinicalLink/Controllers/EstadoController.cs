using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entidades;
using ClinicalLink.Infrastructure;
using ApplicationService.Interface;
using ClinicalLink.Infrastructure.Interface;


namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        readonly IEstadoApplication _estadosRepository;

        public EstadoController(IEstadoApplication estadosRepository)
        {
            _estadosRepository = estadosRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetEstados()
        {
            try
            {
                var Estado = _estadosRepository.GetEstados();
                return Ok(Estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetEstado(int id)
        {
            try
            {
                var Estado = _estadosRepository.GetEstado(id);
                return Ok(Estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEstado(Estado estado)
        {
            try
            {
                _estadosRepository.InsertEstado(estado);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateEstado(Estado estado)
        {
            try
            {
                _estadosRepository.UpdateEstado(estado);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEstado(int id)
        {
            try
            {
                _estadosRepository.DeleteEstado(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
