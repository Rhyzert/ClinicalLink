using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IEstadoRepository
    {
        public Estado GetEstado(int id);
        public List<Estado> GetEstados();
        public void InsertEstado(Estado estado);
        public void UpdateEstado(Estado estado);
        public void DeleteEstado(Estado estado);

    }
}

