using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IEspecialistaApplication
    {
        Especialista GetEspecialista(int id);
        List<Especialista> GetEspecialistas();
        void InsertEspecialista(Especialista especialista);
        void UpdateEspecialista(Especialista especialista);
        void DeleteEspecialista(int id);
    }
}
