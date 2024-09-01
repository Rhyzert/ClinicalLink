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
    public class UniversidadeApplication : IUniversidadeApplication
    {
        public readonly IUniversidadeService _universidadeService;

        public UniversidadeApplication(IUniversidadeService universidadeService)
        {
            _universidadeService = universidadeService;
        }
        public List<Universidade> GetUniversidades()
        {
            return _universidadeService.GetUniversidades();
        }

        public Universidade GetUniversidade(int id)
        {
            return _universidadeService.GetUniversidade(id);
        }

        public void InsertUniversidade(Universidade universidade)
        {
            _universidadeService.InsertUniversidade(universidade);
        }

        public void UpdateUniversidade(Universidade universidade)
        {
            _universidadeService.UpdateUniversidade(universidade);
        }

        public void DeleteUniversidade(int id)
        {
            _universidadeService.DeleteUniversidade(id);
        }


    }
}
