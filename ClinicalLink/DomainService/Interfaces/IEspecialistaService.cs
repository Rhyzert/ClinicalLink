using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IEspecialistaService
    {
        Especialista GetEspecialista(int id);
        List<Especialista> GetEspecialistas();
        void InsertEspecialista(Especialista especialista);
        void UpdateEspecialista(Especialista especialista);
        void DeleteEspecialista(int id);

    }
}
