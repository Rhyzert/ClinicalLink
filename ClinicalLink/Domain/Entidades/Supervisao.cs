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

        // Propriedade de FK para UsuarioSupervisao
        [Column("USUARIO")]
        public int UsuarioSupervisaoId { get; set; }

        [ForeignKey("UsuarioSupervisaoId")]
        public Usuario UsuarioSupervisao { get; set; }

        // Propriedade de FK para UsuarioSupervisor
        [Column("USUARIO_SUPERVISOR")]
        public int UsuarioSupervisorId { get; set; }

        [ForeignKey("UsuarioSupervisorId")]
        public Usuario UsuarioSupervisor { get; set; }

        public List<Usuario> Subordinados { get; set; }
    }

}

