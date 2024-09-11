using ClinicalLink.Infrastructure.Interface;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClinicalLink.Infrastructure.Repositories
{
    public class AgendamentoRepositorySql : IAgendamentoRepository
    {
        private readonly SqlContext _context;

        public AgendamentoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Agendamento GetAgendamento(int id)
        {
            try
            {
                return _context.Agendamentos.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Agendamento> GetAgendamentos()
        {
            try
            {
                return _context.Agendamentos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertAgendamento(Agendamento agendamento)
        {
            try
            {
                _context.Agendamentos.Add(agendamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateAgendamento(Agendamento agendamento)
        {
            try
            {
                _context.Entry(agendamento).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteAgendamento(Agendamento agendamento)
        {
            try
            {
                _context.Set<Agendamento>().Remove(agendamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}