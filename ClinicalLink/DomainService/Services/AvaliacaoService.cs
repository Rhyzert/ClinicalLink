using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService.Interfaces;
using Domain.Entidades;
using ClinicalLink.Infrastructure;

namespace DomainService.Services
{

    public class AvaliacaoService : IAvaliacaoService
    {
        public readonly IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }
        public Avaliacao GetAvaliacao(int id)
        {
            return _avaliacaoRepository.GetAvaliacao(id);
        }

        public List<Avaliacao> GetAvaliacoes()
        {
            return _avaliacaoRepository.GetAvaliacoes();
        }


        public void InsertAvaliacao(Avaliacao avaliacao)
        {
            _avaliacaoRepository.InsertAvaliacao(avaliacao);
        }

        public void UpdateAvaliacao(Avaliacao avaliacao)
        {
            _avaliacaoRepository.UpdateAvaliacao(avaliacao);
        }

        public void DeleteAvaliacao(int id)
        {

            var Avaliacao = _avaliacaoRepository.GetAvaliacao(id);
            if (Avaliacao == null)
                throw new Exception("Essa denuncia Não Existe.");

            _avaliacaoRepository.DeleteAvaliacao(Avaliacao);
        }


    }
}
