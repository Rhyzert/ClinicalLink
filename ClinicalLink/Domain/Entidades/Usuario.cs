using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    [Table("USUARIOS_SISTEMA")]
    public class Usuario
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("senha")]
        public string Senha { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("fone")]
        public string Phone { get; set; }
        [Column("cep")]
        public string Cep { get; set; }
        [Column("sexo")]
        public string Sexo { get; set; }
        [Column("tipousuario")]
        public TipoUsuario Tipo {  get; set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }

        //public Usuario(int id, string nome, string email)
        //{
        //    DomainExceptionValidation

        //}
    }


}
