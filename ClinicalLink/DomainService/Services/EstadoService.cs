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

    public class EstadoService : IEstadoService
    {
        public readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
        public Estado GetEstado(int id)
        {
            return _estadoRepository.GetEstado(id);
        }

        public List<Estado> GetEstados()
        {
            return _estadoRepository.GetEstados();
        }


        public void InsertEstado(Estado estado)
        {
            _estadoRepository.InsertEstado(estado);
        }

        public void UpdateEstado(Estado estado)
        {
            _estadoRepository.UpdateEstado(estado);
        }

        public void DeleteEstado(int id)
        {

            var Estado = _estadoRepository.GetEstado(id);
            if (Estado == null)
                throw new Exception("Essa estado Não Existe.");

            _estadoRepository.DeleteEstado(Estado);
        }


    }
}
