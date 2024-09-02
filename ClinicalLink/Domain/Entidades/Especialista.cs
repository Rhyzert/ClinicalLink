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
        [Column("ID")]
        public string Descricao { get; set; }
        [Column("ID")]
        public DateTime Data { get; set; }
        [Column("ID")]
        public Usuario UsuarioConsulta { get; set; }
        [Column("ID")]
        public Especialidade Especialidade { get; set; }
    }
}
