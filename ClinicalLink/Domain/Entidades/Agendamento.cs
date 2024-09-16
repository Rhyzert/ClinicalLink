using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades
{
    [Table("AGENDAMENTOS")]
    public class Agendamento
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [Column("USUARIO_AVALIACAO")]
        public int UsuarioId { get; set; }
        [ForeignKey("PsiquiatraResponsavelId")]
        public Usuario PsiquiatraResponsavel { get; set; }
        [Column("ESPECIALISTA_AVALIADO")]
        public int PsiquiatraResponsavelId  { get; set; }
        [Column("DATA_CONSULTA")]
        public int DataConsulta {  get; set; }

    }
}
