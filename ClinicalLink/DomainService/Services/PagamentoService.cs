using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService.Interfaces;
using Domain.Entidades;
using ClinicalLink.Infrastructure.Interface;

namespace DomainService.Services
{

    public class PagamentoService : IPagamentoService
    {
        public readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }
        public Pagamento GetPagamento(int id)
        {
            return _pagamentoRepository.GetPagamento(id);
        }

        public List<Pagamento> GetPagamentosUsuario(int idUsuario)
        {
            return _pagamentoRepository.GetPagamentosUsuario(idUsuario);
        }


        public void InsertPagamento(Pagamento pagamento)
        {
            _pagamentoRepository.InsertPagamento(pagamento);
        }

        public void UpdatePagamento(Pagamento pagamento)
        {
            _pagamentoRepository.UpdatePagamento(pagamento);
        }

        public void DeletePagamento(int id)
        {

            var Pagamento = _pagamentoRepository.GetPagamento(id);
            if (Pagamento == null)
                throw new Exception("Essa pagamento Não Existe.");

            _pagamentoRepository.DeletePagamento(Pagamento);
        }


    }
}
