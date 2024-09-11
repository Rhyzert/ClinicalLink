using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IPagamentoRepository
    {
        public Pagamento GetPagamento(int id);
        public List<Pagamento> GetPagamentosUsuario(int idUsuario);
        public void InsertPagamento(Pagamento pagamento);
        public void UpdatePagamento(Pagamento pagamento);
        public void DeletePagamento(Pagamento pagamento);

    }
}

