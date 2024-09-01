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
    public class EstadoRepositorySql : IEstadoRepository
    {
        private readonly SqlContext _context;

        public EstadoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Estado GetEstado(int id)
        {
            try
            {
                return _context.Estados.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Estado> GetEstados()
        {
            try
            {
                return _context.Estados.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertEstado(Estado estado)
        {
            try
            {
                _context.Estados.Add(estado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateEstado(Estado estado)
        {
            try
            {
                _context.Entry(estado).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteEstado(Estado estado)
        {
            try
            {
                _context.Set<Estado>().Remove(estado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}