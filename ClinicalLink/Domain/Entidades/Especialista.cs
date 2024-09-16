using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("ESPECIALISTAS")]
    public class Especialista
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [ForeignKey("UsuarioEspecialistaId")]
        public Usuario UsuarioEspecialista { get; set; }
        [Column("ID_USUARIO")]
        public int UsuarioEspecialistaId { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
        [ForeignKey("EspecialidadeId")]
        public Especialidade Especialidade { get; set; }
        [Column("ID_ESPECIALIDADE")]
        public int EspecialidadeId { get; set; }
    }
}
