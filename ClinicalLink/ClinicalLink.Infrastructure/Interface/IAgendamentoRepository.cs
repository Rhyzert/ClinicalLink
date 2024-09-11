using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IAgendamentoRepository
    {
        public Agendamento GetAgendamento(int id);
        public List<Agendamento> GetAgendamentos();
        public void InsertAgendamento(Agendamento agendamento);
        public void UpdateAgendamento(Agendamento agendamento);
        public void DeleteAgendamento(Agendamento agendamento);

    }
}

