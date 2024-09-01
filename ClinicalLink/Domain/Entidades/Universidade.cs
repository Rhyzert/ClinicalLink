using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("UNIVERSIDADES")]
    public class Universidade
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("CNPJ")]
        public string Cnpj { get; set; }
        [Column("CEP")]
        public string Cep { get; set; }

    }
}
