using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IConsultaApplication
    {
        Consulta GetConsulta(int id);
        List<Consulta> GetConsultas();
        void InsertConsulta(Consulta consulta);
        void UpdateConsulta(Consulta consulta);
        void DeleteConsulta(int id);
    }
}
