using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IPagamentoApplication
    {
        Pagamento GetPagamento(int id);
        List<Pagamento> GetPagamentosUsuario(int idUsuario);
        void InsertPagamento(Pagamento pagamento);
        void UpdatePagamento(Pagamento pagamento);
        void DeletePagamento(int id);
    }
}
