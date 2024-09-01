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
    public class ConsultaApplication : IConsultaApplication
    {
        public readonly IConsultaService _consultaService;

        public ConsultaApplication(IConsultaService consultaService)
        {
            _consultaService = consultaService;
        }
        public List<Consulta> GetConsultas()
        {
            return _consultaService.GetConsultas();
        }

        public Consulta GetConsulta(int id)
        {
            return _consultaService.GetConsulta(id);
        }

        public void InsertConsulta(Consulta consulta)
        {
            _consultaService.InsertConsulta(consulta);
        }

        public void UpdateConsulta(Consulta consulta)
        {
            _consultaService.UpdateConsulta(consulta);
        }

        public void DeleteConsulta(int id)
        {
            _consultaService.DeleteConsulta(id);
        }


    }
}
