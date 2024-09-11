using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IPagamentoService
    {
        Pagamento GetPagamento(int id);
        List<Pagamento> GetPagamentosUsuario(int idUsuario);
        void InsertPagamento(Pagamento pagamento);
        void UpdatePagamento(Pagamento pagamento);
        void DeletePagamento(int id);

    }
}
