using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IConsultaRepository
    {
        public Consulta GetConsulta(int id);
        public List<Consulta> GetConsultas();
        public void InsertConsulta(Consulta consulta);
        public void UpdateConsulta(Consulta consulta);
        public void DeleteConsulta(Consulta consulta);

    }
}

