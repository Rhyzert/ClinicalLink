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
    public class ConsultaRepositorySql : IConsultaRepository
    {
        private readonly SqlContext _context;

        public ConsultaRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Consulta GetConsulta(int id)
        {
            try
            {
                return _context.Consultas.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Consulta> GetConsultas()
        {
            try
            {
                return _context.Consultas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertConsulta(Consulta consulta)
        {
            try
            {
                _context.Consultas.Add(consulta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateConsulta(Consulta consulta)
        {
            try
            {
                _context.Entry(consulta).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteConsulta(Consulta consulta)
        {
            try
            {
                _context.Set<Consulta>().Remove(consulta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}