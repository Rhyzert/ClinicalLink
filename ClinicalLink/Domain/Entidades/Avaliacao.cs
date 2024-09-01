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
        [Column("ESPECIALISTA")]
        public Especialista EspecialistaAvaliado { get; set; }
        [Column("ESTRELAS")]
        public int Estrelas {  get; set; }

    }
}
