using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationService.Interface;
using Domain.Entidades;
using DomainService.Interfaces;

namespace ApplicationService.Application
{
    public class PagamentoApplication : IPagamentoApplication
    {
        public readonly IPagamentoService _pagamentoService;

        public PagamentoApplication(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }
        public List<Pagamento> GetPagamentosUsuario(int idUsuario)
        {
            return _pagamentoService.GetPagamentosUsuario(idUsuario);
        }

        public Pagamento GetPagamento(int id)
        {
            return _pagamentoService.GetPagamento(id);
        }

        public void InsertPagamento(Pagamento pagamento)
        {
            _pagamentoService.InsertPagamento(pagamento);
        }

        public void UpdatePagamento(Pagamento pagamento)
        {
            _pagamentoService.UpdatePagamento(pagamento);
        }

        public void DeletePagamento(int id)
        {
            _pagamentoService.DeletePagamento(id);
        }


    }
}
