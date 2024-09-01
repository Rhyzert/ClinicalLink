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

    public class UniversidadeService : IUniversidadeService
    {
        public readonly IUniversidadeRepository _universidadeRepository;

        public UniversidadeService(IUniversidadeRepository universidadeRepository)
        {
            _universidadeRepository = universidadeRepository;
        }
        public Universidade GetUniversidade(int id)
        {
            return _universidadeRepository.GetUniversidade(id);
        }

        public List<Universidade> GetUniversidades()
        {
            return _universidadeRepository.GetUniversidades();
        }


        public void InsertUniversidade(Universidade universidade)
        {
            _universidadeRepository.InsertUniversidade(universidade);
        }

        public void UpdateUniversidade(Universidade universidade)
        {
            _universidadeRepository.UpdateUniversidade(universidade);
        }

        public void DeleteUniversidade(int id)
        {

            var Universidade = _universidadeRepository.GetUniversidade(id);
            if (Universidade == null)
                throw new Exception("Essa denuncia Não Existe.");

            _universidadeRepository.DeleteUniversidade(Universidade);
        }


    }
}
