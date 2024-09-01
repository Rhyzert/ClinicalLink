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

    public class EspecialidadeService : IEspecialidadeService
    {
        public readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository)
        {
            _especialidadeRepository = especialidadeRepository;
        }
        public Especialidade GetEspecialidade(int id)
        {
            return _especialidadeRepository.GetEspecialidade(id);
        }

        public List<Especialidade> GetEspecialidades()
        {
            return _especialidadeRepository.GetEspecialidades();
        }


        public void InsertEspecialidade(Especialidade especialidade)
        {
            _especialidadeRepository.InsertEspecialidade(especialidade);
        }

        public void UpdateEspecialidade(Especialidade especialidade)
        {
            _especialidadeRepository.UpdateEspecialidade(especialidade);
        }

        public void DeleteEspecialidade(int id)
        {

            var Especialidade = _especialidadeRepository.GetEspecialidade(id);
            if (Especialidade == null)
                throw new Exception("Essa especialidade Não Existe.");

            _especialidadeRepository.DeleteEspecialidade(Especialidade);
        }


    }
}
