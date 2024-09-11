using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService.Interfaces;
using Domain.Entidades;
using ClinicalLink.Infrastructure.Interface;

namespace DomainService.Services
{

    public class AgendamentoService : IAgendamentoService
    {
        public readonly IAgendamentoRepository _agendamentoRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }
        public Agendamento GetAgendamento(int id)
        {
            return _agendamentoRepository.GetAgendamento(id);
        }

        public List<Agendamento> GetAgendamentos()
        {
            return _agendamentoRepository.GetAgendamentos();
        }


        public void InsertAgendamento(Agendamento agendamento)
        {
            _agendamentoRepository.InsertAgendamento(agendamento);
        }

        public void UpdateAgendamento(Agendamento agendamento)
        {
            _agendamentoRepository.UpdateAgendamento(agendamento);
        }

        public void DeleteAgendamento(int id)
        {

            var Agendamento = _agendamentoRepository.GetAgendamento(id);
            if (Agendamento == null)
                throw new Exception("Esse agendamento Não Existe.");

            _agendamentoRepository.DeleteAgendamento(Agendamento);
        }


    }
}
