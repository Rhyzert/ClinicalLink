using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades
{
    public class Avaliacao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("id")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [Column("especialista")]
        public Especialista EspecialistaAvaliado { get; set; }
        [Column("estrelas")]
        public int Estrelas {  get; set; }

    }
}
