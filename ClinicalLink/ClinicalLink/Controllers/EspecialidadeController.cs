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
    public class EspecialidadeController : ControllerBase
    {
        readonly IEspecialidadeApplication _especialidadesRepository;

        public EspecialidadeController(IEspecialidadeApplication especialidadesRepository)
        {
            _especialidadesRepository = especialidadesRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetEspecialidades()
        {
            try
            {
                var Especialidade = _especialidadesRepository.GetEspecialidades();
                return Ok(Especialidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetEspecialidade(int id)
        {
            try
            {
                var Especialidade = _especialidadesRepository.GetEspecialidade(id);
                return Ok(Especialidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEspecialidade(Especialidade especialidade)
        {
            try
            {
                _especialidadesRepository.InsertEspecialidade(especialidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateEspecialidade(Especialidade especialidade)
        {
            try
            {
                _especialidadesRepository.UpdateEspecialidade(especialidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEspecialidade(int id)
        {
            try
            {
                _especialidadesRepository.DeleteEspecialidade(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
