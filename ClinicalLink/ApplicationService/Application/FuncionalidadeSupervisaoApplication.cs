using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationService.Interface;
using ClinicalLink.Infrastructure.Interface;
using Domain.Entidades;
using DomainService.Interfaces;

namespace ApplicationService.Application
{
    public class FuncionalidadeSupervisaoApplication : IFuncionalidadeSupervisaoApplication
    {
        public readonly IFuncionalidadeSupervisaoService _funSupervisaoService;

        public FuncionalidadeSupervisaoApplication(IFuncionalidadeSupervisaoService funSupervisaoService)
        {
            _funSupervisaoService = funSupervisaoService;
        }
        public List<Usuario> GetAlunosSupervisao(int id)
        {
            return _funSupervisaoService.GetAlunosSupervisao(id);
        }

        public Consulta BuscarConsultasSupervisao(int idUsuario)
        {
            return _funSupervisaoService.BuscarConsultasSupervisao(idUsuario);
        }


        public List<Avaliacao> BuscarAvaliacoesSupervisao(int idUsuario)
        {
            return _funSupervisaoService.BuscarAvaliacoesSupervisao(idUsuario);
        }

        public List<Consulta> ConsultasMensais(Usuario usuario, string dataInicio, string dataFim)
        {
            return _funSupervisaoService.ConsultasMensais(usuario, dataInicio, dataFim);
        }



    }
}
