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
    public class PagamentoController : ControllerBase
    {
        readonly IPagamentoApplication _pagamentosRepository;

        public PagamentoController(IPagamentoApplication pagamentosRepository)
        {
            _pagamentosRepository = pagamentosRepository;
        }

       // [Authorize]
        [HttpGet]
        public IActionResult GetPagamentosUsuario(int idUsuario)
        {
            try
            {
                var Pagamento = _pagamentosRepository.GetPagamentosUsuario(idUsuario);
                return Ok(Pagamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetPagamento(int id)
        {
            try
            {
                var Pagamento = _pagamentosRepository.GetPagamento(id);
                return Ok(Pagamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertPagamento(Pagamento pagamento)
        {
            try
            {
                _pagamentosRepository.InsertPagamento(pagamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdatePagamento(Pagamento pagamento)
        {
            try
            {
                _pagamentosRepository.UpdatePagamento(pagamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePagamento(int id)
        {
            try
            {
                _pagamentosRepository.DeletePagamento(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
