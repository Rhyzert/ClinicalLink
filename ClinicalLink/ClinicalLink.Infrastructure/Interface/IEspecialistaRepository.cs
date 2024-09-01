using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IEspecialistaRepository
    {
        public Especialista GetEspecialista(int id);
        public List<Especialista> GetEspecialistas();
        public void InsertEspecialista(Especialista especialista);
        public void UpdateEspecialista(Especialista especialista);
        public void DeleteEspecialista(Especialista especialista);

    }
}

