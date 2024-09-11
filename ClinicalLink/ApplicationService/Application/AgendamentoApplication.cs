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
    public class AgendamentoApplication : IAgendamentoApplication
    {
        public readonly IAgendamentoService _agendamentoService;

        public AgendamentoApplication(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }
        public List<Agendamento> GetAgendamentos()
        {
            return _agendamentoService.GetAgendamentos();
        }

        public Agendamento GetAgendamento(int id)
        {
            return _agendamentoService.GetAgendamento(id);
        }

        public void InsertAgendamento(Agendamento agendamento)
        {
            _agendamentoService.InsertAgendamento(agendamento);
        }

        public void UpdateAgendamento(Agendamento agendamento)
        {
            _agendamentoService.UpdateAgendamento(agendamento);
        }

        public void DeleteAgendamento(int id)
        {
            _agendamentoService.DeleteAgendamento(id);
        }


    }
}
