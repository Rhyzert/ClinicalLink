using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IUniversidadeApplication
    {
        Universidade GetUniversidade(int id);
        List<Universidade> GetUniversidades();
        void InsertUniversidade(Universidade universidade);
        void UpdateUniversidade(Universidade universidade);
        void DeleteUniversidade(int id);
    }
}
