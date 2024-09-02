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

    public class SupervisaoService : ISupervisaoService
    {
        public readonly ISupervisaoRepository _supervisaoRepository;

        public SupervisaoService(ISupervisaoRepository supervisaoRepository)
        {
            _supervisaoRepository = supervisaoRepository;
        }
        public Supervisao GetSupervisao(int id)
        {
            return _supervisaoRepository.GetSupervisao(id);
        }

        public List<Supervisao> GetSupervisoes()
        {
            return _supervisaoRepository.GetSupervisoes();
        }


        public void InsertSupervisao(Supervisao supervisao)
        {
            _supervisaoRepository.InsertSupervisao(supervisao);
        }

        public void UpdateSupervisao(Supervisao supervisao)
        {
            _supervisaoRepository.UpdateSupervisao(supervisao);
        }

        public void DeleteSupervisao(int id)
        {

            var Supervisao = _supervisaoRepository.GetSupervisao(id);
            if (Supervisao == null)
                throw new Exception("Essa supervisao Não Existe.");

            _supervisaoRepository.DeleteSupervisao(Supervisao);
        }


    }
}
