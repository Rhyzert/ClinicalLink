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
    public class PagamentoRepositorySql : IPagamentoRepository
    {
        private readonly SqlContext _context;

        public PagamentoRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Pagamento GetPagamento(int id)
        {
            try
            {
                return _context.Pagamentos.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Pagamento> GetPagamentosUsuario(int idUsuario)
        {
            try
            {
                return _context.Pagamentos.Include(p => p.UsuarioOrigem) 
                       .Where(x => x.UsuarioOrigem.Id == idUsuario)
                       .ToList(); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertPagamento(Pagamento pagamento)
        {
            try
            {
                _context.Pagamentos.Add(pagamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdatePagamento(Pagamento pagamento)
        {
            try
            {
                _context.Entry(pagamento).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeletePagamento(Pagamento pagamento)
        {
            try
            {
                _context.Set<Pagamento>().Remove(pagamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}