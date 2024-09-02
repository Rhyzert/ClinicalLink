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
    public class SupervisaoController : ControllerBase
    {
        readonly ISupervisaoApplication _supervisaosRepository;

        public SupervisaoController(ISupervisaoApplication supervisaosRepository)
        {
            _supervisaosRepository = supervisaosRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetSupervisoes()
        {
            try
            {
                var Supervisao = _supervisaosRepository.GetSupervisoes();
                return Ok(Supervisao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetSupervisao(int id)
        {
            try
            {
                var Supervisao = _supervisaosRepository.GetSupervisao(id);
                return Ok(Supervisao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertSupervisao(Supervisao supervisao)
        {
            try
            {
                _supervisaosRepository.InsertSupervisao(supervisao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateSupervisao(Supervisao supervisao)
        {
            try
            {
                _supervisaosRepository.UpdateSupervisao(supervisao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupervisao(int id)
        {
            try
            {
                _supervisaosRepository.DeleteSupervisao(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
