using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IEstadoApplication
    {
        Estado GetEstado(int id);
        List<Estado> GetEstados();
        void InsertEstado(Estado estado);
        void UpdateEstado(Estado estado);
        void DeleteEstado(int id);
    }
}
