using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService.Interfaces;
using Domain.Entidades;
using ClinicalLink.Infrastructure.Interface;

namespace DomainService.Services
{

    public class FuncionalidadeSupervisaoService : IFuncionalidadeSupervisaoService
    {
        public readonly IFuncionalidadeSupervisaoRepository _funSupervisaoRepository;

        public FuncionalidadeSupervisaoService(IFuncionalidadeSupervisaoRepository funSupervisaoRepository)
        {
            _funSupervisaoRepository = funSupervisaoRepository;
        }
        public List<Usuario> GetAlunosSupervisao(int id)
        {
            return _funSupervisaoRepository.GetAlunosSupervisao(id);
        }

        public Consulta BuscarConsultasSupervisao(int idUsuario)
        {
            return _funSupervisaoRepository.BuscarConsultasSupervisao(idUsuario);
        }


        public List<Avaliacao> BuscarAvaliacoesSupervisao(int idUsuario)
        {
           return _funSupervisaoRepository.BuscarAvaliacoesSupervisao(idUsuario);
        }

        public List<Consulta> ConsultasMensais(Usuario usuario, string dataInicio, string dataFim)
        {
            return _funSupervisaoRepository.ConsultasMensais(usuario,dataInicio,dataFim);
        }


    }
}
