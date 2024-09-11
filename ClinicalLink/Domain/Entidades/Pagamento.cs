using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("PAGAMENTOS")]
    public class Pagamento
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("USUARIO_ORIGEM")]
        [StringLength(100)]
        public Usuario UsuarioOrigem { get; set; }
        [Column("ESPECIALISTA_DESTINO")]
        public Usuario EspecialistaDestino { get; set; }
        [Column("TIPO_PAGAMENTO")]
        public string TipoPagamento { get; set; }
        [Column("DATA_PAGAMENTO")]
        public string Data { get; set; }
        [Column("VALOR")]
        public float Valor { get; set; }
        [Column("TIPO_TRANSFERENCIA")]
        public string TipoTransferencia { get; set; }
        [Column("NOME_DESTINO")]
        public string NomeDestino { get; set; }
        [Column("INSTITUICAO_DESTINO")]
        public string InstituicaoDestino { get; set; }
        [Column("AGENCIA_DESTINO")]
        public string AgenciaDestino { get; set; }
        [Column("CONTA_DESTINO")]
        public string ContaDestino { get; set; }
        [Column("NOME_ORIGEM")]
        public string NomeOrigem { get; set; }
        [Column("INSTITUICAO_ORIGEM")]
        public string InstituicaoOrigem { get; set; }
        [Column("AGENCIA_ORIGEM")]
        public string AgenciaOrigem { get; set; }
        [Column("CONTA_ORIGEM")]
        public string ContaOrigem { get; set; }
        [Column("ID_TRANSACAO")]
        public string IdTransacao { get; set; } = Guid.NewGuid().ToString();

    }
}
