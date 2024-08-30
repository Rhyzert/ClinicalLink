using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationService.Interface;
using Domain.Entidades;
using DomainService.Interfaces;

namespace ApplicationService.Application
{
    public class AvaliacaoApplication : IAvaliacaoApplication
    {
        public readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoApplication(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }
        public List<Avaliacao> GetAvaliacoes()
        {
            return _avaliacaoService.GetAvaliacoes();
        }

        public Avaliacao GetAvaliacao(int id)
        {
            return _avaliacaoService.GetAvaliacao(id);
        }

        public void InsertAvaliacao(Avaliacao avaliacao)
        {
            _avaliacaoService.InsertAvaliacao(avaliacao);
        }

        public void UpdateAvaliacao(Avaliacao avaliacao)
        {
            _avaliacaoService.UpdateAvaliacao(avaliacao);
        }

        public void DeleteAvaliacao(int id)
        {
            _avaliacaoService.DeleteAvaliacao(id);
        }


    }
}
