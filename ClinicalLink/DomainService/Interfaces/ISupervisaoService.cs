using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface ISupervisaoService
    {
        Supervisao GetSupervisao(int id);
        List<Supervisao> GetSupervisoes();
        void InsertSupervisao(Supervisao supervisao);
        void UpdateSupervisao(Supervisao supervisao);
        void DeleteSupervisao(int id);

    }
}
