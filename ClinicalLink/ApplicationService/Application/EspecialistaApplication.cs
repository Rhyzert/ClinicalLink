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
    public class EspecialistaApplication : IEspecialistaApplication
    {
        public readonly IEspecialistaService _especialistaService;

        public EspecialistaApplication(IEspecialistaService especialistaService)
        {
            _especialistaService = especialistaService;
        }
        public List<Especialista> GetEspecialistas()
        {
            return _especialistaService.GetEspecialistas();
        }

        public Especialista GetEspecialista(int id)
        {
            return _especialistaService.GetEspecialista(id);
        }

        public void InsertEspecialista(Especialista especialista)
        {
            _especialistaService.InsertEspecialista(especialista);
        }

        public void UpdateEspecialista(Especialista especialista)
        {
            _especialistaService.UpdateEspecialista(especialista);
        }

        public void DeleteEspecialista(int id)
        {
            _especialistaService.DeleteEspecialista(id);
        }


    }
}
