using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entidades;
using ClinicalLink.Infrastructure;
using ApplicationService.Interface;


namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        readonly IAvaliacaoApplication _avaliacaosRepository;

        public AvaliacaoController(IAvaliacaoApplication avaliacaosRepository)
        {
            _avaliacaosRepository = avaliacaosRepository;
        }

        [HttpGet]
        public IActionResult GetAvaliacoes()
        {
            try
            {
                var avaliacao = _avaliacaosRepository.GetAvaliacoes();
                return Ok(avaliacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAvaliacao(int id)
        {
            try
            {
                var avaliacao = _avaliacaosRepository.GetAvaliacao(id);
                return Ok(avaliacao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _avaliacaosRepository.InsertAvaliacao(avaliacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _avaliacaosRepository.UpdateAvaliacao(avaliacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAvaliacao(int id)
        {
            try
            {
                _avaliacaosRepository.DeleteAvaliacao(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
