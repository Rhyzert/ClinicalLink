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
    public class EspecialistaRepositorySql : IEspecialistaRepository
    {
        private readonly SqlContext _context;

        public EspecialistaRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Especialista GetEspecialista(int id)
        {
            try
            {
                return _context.Especialistas.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Especialista> GetEspecialistas()
        {
            try
            {
                return _context.Especialistas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertEspecialista(Especialista especialista)
        {
            try
            {
                _context.Especialistas.Add(especialista);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateEspecialista(Especialista especialista)
        {
            try
            {
                _context.Entry(especialista).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteEspecialista(Especialista especialista)
        {
            try
            {
                _context.Set<Especialista>().Remove(especialista);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}