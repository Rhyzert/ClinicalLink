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
    public class ConsultaController : ControllerBase
    {
        readonly IConsultaApplication _consultasRepository;

        public ConsultaController(IConsultaApplication consultasRepository)
        {
            _consultasRepository = consultasRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetConsultas()
        {
            try
            {
                var Consulta = _consultasRepository.GetConsultas();
                return Ok(Consulta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetConsulta(int id)
        {
            try
            {
                var Consulta = _consultasRepository.GetConsulta(id);
                return Ok(Consulta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertConsulta(Consulta consulta)
        {
            try
            {
                _consultasRepository.InsertConsulta(consulta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateConsulta(Consulta consulta)
        {
            try
            {
                _consultasRepository.UpdateConsulta(consulta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConsulta(int id)
        {
            try
            {
                _consultasRepository.DeleteConsulta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
