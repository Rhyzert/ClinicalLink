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
    public class EspecialistaController : ControllerBase
    {
        readonly IEspecialistaApplication _especialistasRepository;

        public EspecialistaController(IEspecialistaApplication especialistasRepository)
        {
            _especialistasRepository = especialistasRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetEspecialistas()
        {
            try
            {
                var Especialista = _especialistasRepository.GetEspecialistas();
                return Ok(Especialista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetEspecialista(int id)
        {
            try
            {
                var Especialista = _especialistasRepository.GetEspecialista(id);
                return Ok(Especialista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEspecialista(Especialista especialista)
        {
            try
            {
                _especialistasRepository.InsertEspecialista(especialista);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateEspecialista(Especialista especialista)
        {
            try
            {
                _especialistasRepository.UpdateEspecialista(especialista);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEspecialista(int id)
        {
            try
            {
                _especialistasRepository.DeleteEspecialista(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
