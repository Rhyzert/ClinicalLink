using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IUniversidadeService
    {
        Universidade GetUniversidade(int id);
        List<Universidade> GetUniversidades();
        void InsertUniversidade(Universidade universidade);
        void UpdateUniversidade(Universidade universidade);
        void DeleteUniversidade(int id);

    }
}
