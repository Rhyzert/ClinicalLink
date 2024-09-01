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
    public class EspecialidadeApplication : IEspecialidadeApplication
    {
        public readonly IEspecialidadeService _especialidadeService;

        public EspecialidadeApplication(IEspecialidadeService especialidadeService)
        {
            _especialidadeService = especialidadeService;
        }
        public List<Especialidade> GetEspecialidades()
        {
            return _especialidadeService.GetEspecialidades();
        }

        public Especialidade GetEspecialidade(int id)
        {
            return _especialidadeService.GetEspecialidade(id);
        }

        public void InsertEspecialidade(Especialidade especialidade)
        {
            _especialidadeService.InsertEspecialidade(especialidade);
        }

        public void UpdateEspecialidade(Especialidade especialidade)
        {
            _especialidadeService.UpdateEspecialidade(especialidade);
        }

        public void DeleteEspecialidade(int id)
        {
            _especialidadeService.DeleteEspecialidade(id);
        }


    }
}
