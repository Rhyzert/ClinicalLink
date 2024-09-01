using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IUniversidadeRepository
    {
        public Universidade GetUniversidade(int id);
        public List<Universidade> GetUniversidades();
        public void InsertUniversidade(Universidade universidade);
        public void UpdateUniversidade(Universidade universidade);
        public void DeleteUniversidade(Universidade universidade);

    }
}

