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
    public class SupervisaoRepositorySql : ISupervisaoRepository
    {
        private readonly SqlContext _context;

        public SupervisaoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Supervisao GetSupervisao(int id)
        {
            try
            {
                return _context.Supervisoes.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Supervisao> GetSupervisoes()
        {
            try
            {
                return _context.Supervisoes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertSupervisao(Supervisao supervisao)
        {
            try
            {
                _context.Supervisoes.Add(supervisao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateSupervisao(Supervisao supervisao)
        {
            try
            {
                _context.Entry(supervisao).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteSupervisao(Supervisao supervisao)
        {
            try
            {
                _context.Set<Supervisao>().Remove(supervisao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}