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

    public class ConsultaService : IConsultaService
    {
        public readonly IConsultaRepository _consultaRepository;

        public ConsultaService(IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }
        public Consulta GetConsulta(int id)
        {
            return _consultaRepository.GetConsulta(id);
        }

        public List<Consulta> GetConsultas()
        {
            return _consultaRepository.GetConsultas();
        }


        public void InsertConsulta(Consulta consulta)
        {
            _consultaRepository.InsertConsulta(consulta);
        }

        public void UpdateConsulta(Consulta consulta)
        {
            _consultaRepository.UpdateConsulta(consulta);
        }

        public void DeleteConsulta(int id)
        {

            var Consulta = _consultaRepository.GetConsulta(id);
            if (Consulta == null)
                throw new Exception("Essa consulta Não Existe.");

            _consultaRepository.DeleteConsulta(Consulta);
        }


    }
}
