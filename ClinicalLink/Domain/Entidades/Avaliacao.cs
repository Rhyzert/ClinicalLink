using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades
{
    [Table("AVALIACAO_ESPECIALISTA")]
    public class Avaliacao
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [ForeignKey("UsuarioAvaliacaoId")]
        public Usuario UsuarioAvaliacao { get; set; }
        [Column("USUARIO_AVALIACAO")]
        public int UsuarioAvaliacaoId { get; set; }
        [ForeignKey("EspecialistaAvaliadoId")]
        public Especialista EspecialistaAvaliado { get; set; }
        [Column("ESPECIALISTA_AVALIADO")]
        public int EspecialistaAvaliadoId { get; private set; }
        [Column("ESTRELAS")]
        public int Estrelas {  get; set; }

    }
}
