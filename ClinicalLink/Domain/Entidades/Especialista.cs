using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Especialista
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_USUARIO")]
        public Usuario UsuarioEspecialista { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
    }
}
