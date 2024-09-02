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
        [Column("USUARIO")]
        [StringLength(100)]
        public Usuario Usuario { get; set; }
        [Column("ESPECIALISTA")]
        public Especialista Especialista { get; set; }
        [Column("TIPO_PAGAMENTO")]
        public Especialista TipoPagamento { get; set; }
        [Column("DATA_PAGAMENTO")]
        public string Data { get; set; }
        public float ValorPagamento { get; set; }
    }
}
