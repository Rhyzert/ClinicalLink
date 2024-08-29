using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IAvaliacaoService
    {
        Avaliacao GetAvaliacao(int id);
        List<Avaliacao> GetAvaliacoes();
        void InsertAvaliacao(Avaliacao avaliacao);
        void UpdateAvaliacao(Avaliacao avaliacao);
        void DeleteAvaliacao(int id);

    }
}
