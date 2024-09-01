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
    public class UniversidadeController : ControllerBase
    {
        readonly IUniversidadeApplication _universidadesRepository;

        public UniversidadeController(IUniversidadeApplication universidadesRepository)
        {
            _universidadesRepository = universidadesRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetUniversidades()
        {
            try
            {
                var Universidade = _universidadesRepository.GetUniversidades();
                return Ok(Universidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetUniversidade(int id)
        {
            try
            {
                var Universidade = _universidadesRepository.GetUniversidade(id);
                return Ok(Universidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUniversidade(Universidade universidade)
        {
            try
            {
                _universidadesRepository.InsertUniversidade(universidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateUniversidade(Universidade universidade)
        {
            try
            {
                _universidadesRepository.UpdateUniversidade(universidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUniversidade(int id)
        {
            try
            {
                _universidadesRepository.DeleteUniversidade(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
