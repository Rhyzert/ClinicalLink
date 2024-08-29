using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ClinicalLink.Infrastructure
{
    public interface IAvaliacaoRepository
    {
        public Avaliacao GetAvaliacao(int id);
        public List<Avaliacao> GetAvaliacoes();
        public void InsertAvaliacao(Avaliacao avaliacao);
        public void UpdateAvaliacao(Avaliacao avaliacao);
        public void DeleteAvaliacao(Avaliacao avaliacao);

    }
}
