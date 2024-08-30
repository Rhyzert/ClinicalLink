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
    public class AvaliacaoRepositorySql : IAvaliacaoRepository
    {
        private readonly SqlContext _context;

        public AvaliacaoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Avaliacao GetAvaliacao(int id)
        {
            try
            {
                return _context.Avaliacoes.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Avaliacao> GetAvaliacoes()
        {
            try
            {
                return _context.Avaliacoes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _context.Avaliacoes.Add(avaliacao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _context.Entry(avaliacao).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _context.Set<Avaliacao>().Remove(avaliacao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}