using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Especialista Especialista { get; set; }
        public DateTime Data { get; set; }
        public Usuario UsuarioConsulta { get; set; }

    }
}
