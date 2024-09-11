using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IAgendamentoService
    {
        Agendamento GetAgendamento(int id);
        List<Agendamento> GetAgendamentos();
        void InsertAgendamento(Agendamento agendamento);
        void UpdateAgendamento(Agendamento agendamento);
        void DeleteAgendamento(int id);

    }
}
