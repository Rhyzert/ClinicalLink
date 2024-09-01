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

    public class EspecialistaService : IEspecialistaService
    {
        public readonly IEspecialistaRepository _especialistaRepository;

        public EspecialistaService(IEspecialistaRepository especialistaRepository)
        {
            _especialistaRepository = especialistaRepository;
        }
        public Especialista GetEspecialista(int id)
        {
            return _especialistaRepository.GetEspecialista(id);
        }

        public List<Especialista> GetEspecialistas()
        {
            return _especialistaRepository.GetEspecialistas();
        }


        public void InsertEspecialista(Especialista especialista)
        {
            _especialistaRepository.InsertEspecialista(especialista);
        }

        public void UpdateEspecialista(Especialista especialista)
        {
            _especialistaRepository.UpdateEspecialista(especialista);
        }

        public void DeleteEspecialista(int id)
        {

            var Especialista = _especialistaRepository.GetEspecialista(id);
            if (Especialista == null)
                throw new Exception("Essa especialista Não Existe.");

            _especialistaRepository.DeleteEspecialista(Especialista);
        }


    }
}
