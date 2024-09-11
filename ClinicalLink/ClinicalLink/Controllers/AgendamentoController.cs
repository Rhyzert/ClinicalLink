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
    public class AgendamentoController : ControllerBase
    {
        readonly IAgendamentoApplication _agendamentosRepository;

        public AgendamentoController(IAgendamentoApplication agendamentosRepository)
        {
            _agendamentosRepository = agendamentosRepository;
        }

        [HttpGet]
        public IActionResult GetAgendamentos()
        {
            try
            {
                var agendamento = _agendamentosRepository.GetAgendamentos();
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAgendamento(int id)
        {
            try
            {
                var agendamento = _agendamentosRepository.GetAgendamento(id);
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertAgendamento(Agendamento agendamento)
        {
            try
            {
                _agendamentosRepository.InsertAgendamento(agendamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateAgendamento(Agendamento agendamento)
        {
            try
            {
                _agendamentosRepository.UpdateAgendamento(agendamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAgendamento(int id)
        {
            try
            {
                _agendamentosRepository.DeleteAgendamento(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
