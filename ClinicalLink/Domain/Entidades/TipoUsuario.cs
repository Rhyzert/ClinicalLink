using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("TIPO_USUARIOS_SISTEMA")]
    public class TipoUsuario
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TIPO")]
        [StringLength(50)]
        public string Tipo { get; set; }

    }
}
