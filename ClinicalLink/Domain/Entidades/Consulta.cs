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
        
        [ForeignKey("EspecialistaId")]
        public Usuario Especialista { get; set; }
        [Column("ESPECIALISTA")]
        public int EspecialistaId { get; set; }
        [Column("DATA_CONSULTA")]
        public string Data { get; set; }
        
        [ForeignKey("UsuarioId")]
        public Usuario UsuarioConsulta { get; set; }
        [Column("USUARIO")]
        public int UsuarioId { get; set; }
        [ForeignKey("StatusConsultaId")]
        public StatusConsulta StatusConsulta { get; set; }
        [Column("STATUS_CONSULTA")]
        public int StatusConsultaId { get; set; }

    }
}
