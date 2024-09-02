using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("ESPECIALIDADES")]
    public class Especialidade
    {
       
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

    }
}
