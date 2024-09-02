using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface ISupervisaoRepository
    {
        public Supervisao GetSupervisao(int id);
        public List<Supervisao> GetSupervisoes();
        public void InsertSupervisao(Supervisao supervisao);
        public void UpdateSupervisao(Supervisao supervisao);
        public void DeleteSupervisao(Supervisao supervisao);

    }
}

