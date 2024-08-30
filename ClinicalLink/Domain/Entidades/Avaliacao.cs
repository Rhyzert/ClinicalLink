using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Especialista EspecialistaAvaliado { get; set; }
        public int Estrelas {  get; set; }

    }
}
