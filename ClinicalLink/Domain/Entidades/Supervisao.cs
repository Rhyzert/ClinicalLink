using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("SUPERVISAO")]
    public class Supervisao
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [Column("USUARIO")]
        public Usuario UsuarioSupervisao { get; set; }
        [Column("USUARIO_SUPERVISOR")]
        public Usuario UsuarioSupervisor { get; set; }

        public List<Usuario> Subordinados { get; set; }

    }
}
