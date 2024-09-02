using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("CONSULTAS")]
    public class Consulta
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [Column("ESPECIALISTA")]
        public Especialista Especialista { get; set; }
        [Column("DATA_CONSULTA")]
        public string Data { get; set; }
        [Column("USUARIO")]
        public Usuario UsuarioConsulta { get; set; }
        [Column("STATUS_CONSULTA")]
        [StringLength(2)]
        public StatusConsulta StatusConsulta { get; set; }

    }
}
