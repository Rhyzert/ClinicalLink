using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IEspecialidadeApplication
    {
        Especialidade GetEspecialidade(int id);
        List<Especialidade> GetEspecialidades();
        void InsertEspecialidade(Especialidade especialidade);
        void UpdateEspecialidade(Especialidade especialidade);
        void DeleteEspecialidade(int id);
    }
}
