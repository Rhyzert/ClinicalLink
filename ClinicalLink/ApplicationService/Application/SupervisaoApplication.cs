using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationService.Interface;
using Domain.Entidades;
using DomainService.Interfaces;

namespace ApplicationService.Application
{
    public class SupervisaoApplication : ISupervisaoApplication
    {
        public readonly ISupervisaoService _supervisaoService;

        public SupervisaoApplication(ISupervisaoService supervisaoService)
        {
            _supervisaoService = supervisaoService;
        }
        public List<Supervisao> GetSupervisoes()
        {
            return _supervisaoService.GetSupervisoes();
        }

        public Supervisao GetSupervisao(int id)
        {
            return _supervisaoService.GetSupervisao(id);
        }

        public void InsertSupervisao(Supervisao supervisao)
        {
            _supervisaoService.InsertSupervisao(supervisao);
        }

        public void UpdateSupervisao(Supervisao supervisao)
        {
            _supervisaoService.UpdateSupervisao(supervisao);
        }

        public void DeleteSupervisao(int id)
        {
            _supervisaoService.DeleteSupervisao(id);
        }


    }
}
