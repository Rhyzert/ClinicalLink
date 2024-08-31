using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IConsultaService
    {
        Consulta GetConsulta(int id);
        List<Consulta> GetConsultas();
        void InsertConsulta(Consulta consulta);
        void UpdateConsulta(Consulta consulta);
        void DeleteConsulta(int id);

    }
}
