using ClinicalLink.Infrastructure.Interface;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClinicalLink.Infrastructure.Repositories
{
    public class FuncionalidadeSupervisaoRepositorySql : IFuncionalidadeSupervisaoRepository
    {
        private readonly SqlContext _context;

        public FuncionalidadeSupervisaoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public List<Avaliacao> BuscarAvaliacoesSupervisao(int idUsuario)
        {
            var usuarios = _context.Avaliacoes
            .Where(s => s.Id == idUsuario)  // Seleciona todos os subordinados
            .ToList();

            return usuarios;
        }

        public Consulta BuscarConsultasSupervisao(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ConsultasMensais(Usuario usuario, string dataInicio, string dataFim)
        {
            try
            {
                List<Consulta> consultasUsuario = _context.Consultas.Where(c => c.UsuarioConsulta == usuario && string.Compare(c.Data, dataInicio) >= 0 &&
                string.Compare(c.Data, dataInicio) <= 0).ToList();
                return consultasUsuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Usuario> GetAlunosSupervisao(int idSupervisor)
        {
            try
            {
                var usuarios = _context.Supervisoes
                       .Where(s => s.Id == idSupervisor)
                       .SelectMany(s => s.Subordinados)  // Seleciona todos os subordinados
                       .ToList();

                return usuarios;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}