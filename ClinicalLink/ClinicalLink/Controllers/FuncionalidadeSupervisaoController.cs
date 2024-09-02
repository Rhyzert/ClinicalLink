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
    public class FuncionalidadeSupervisaoController : ControllerBase
    {
        readonly IFuncionalidadeSupervisaoApplication _funSupervisaoApplication;

        public FuncionalidadeSupervisaoController(IFuncionalidadeSupervisaoApplication funSupervisaoApplication)
        {
            _funSupervisaoApplication = funSupervisaoApplication;
        }

        // [Authorize]
        [HttpGet("alunos/{idUsuario}")]
        public IActionResult GetAlunosSupervisao(int idUsuario)
        {
            try
            {
                var alunosSupervisao = _funSupervisaoApplication.GetAlunosSupervisao(idUsuario);
                return Ok(alunosSupervisao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize]
        [HttpGet("avaliacoes/{id}")]
        public IActionResult BuscarAvaliacoesSupervisao(int id)
        {
            try
            {
                var avaliacoesSupervisao = _funSupervisaoApplication.BuscarAvaliacoesSupervisao(id);
                return Ok(avaliacoesSupervisao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("consultas/{idUsuario}")]
        public IActionResult BuscarConsultasSupervisaoo(int idUsuario)
        {
            try
            {
                var consultarSupervisao= _funSupervisaoApplication.BuscarConsultasSupervisao(idUsuario);
                return Ok(consultarSupervisao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("consultas-mensais")]
        public IActionResult ConsultasMensais(Usuario usuario, string dataInicio, string dataFim)
        {
            try
            {
               var consultasMensais = _funSupervisaoApplication.ConsultasMensais(usuario, dataInicio, dataFim);
                return Ok(consultasMensais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
