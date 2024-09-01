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
    public class UniversidadeRepositorySql : IUniversidadeRepository
    {
        private readonly SqlContext _context;

        public UniversidadeRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Universidade GetUniversidade(int id)
        {
            try
            {
                return _context.Universidades.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Universidade> GetUniversidades()
        {
            try
            {
                return _context.Universidades.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertUniversidade(Universidade universidade)
        {
            try
            {
                _context.Universidades.Add(universidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateUniversidade(Universidade universidade)
        {
            try
            {
                _context.Entry(universidade).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteUniversidade(Universidade universidade)
        {
            try
            {
                _context.Set<Universidade>().Remove(universidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}