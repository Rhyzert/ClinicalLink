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
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("SENHA")]
        public string Senha { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("FONE")]
        public string Phone { get; set; }
        [Column("CEP")]
        public string Cep { get; set; }
        [Column("SEXO")]
        public string Sexo { get; set; }
        [Column("TIPO_USUARIO")]
        public TipoUsuario Tipo {  get; set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }

        //public Usuario(int id, string nome, string email)
        //{
        //    DomainExceptionValidation

        //}
    }


}
