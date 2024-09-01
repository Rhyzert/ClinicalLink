using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IEspecialidadeRepository
    {
        public Especialidade GetEspecialidade(int id);
        public List<Especialidade> GetEspecialidades();
        public void InsertEspecialidade(Especialidade especialidade);
        public void UpdateEspecialidade(Especialidade especialidade);
        public void DeleteEspecialidade(Especialidade especialidade);

    }
}

