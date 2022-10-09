using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class DisponibilidadeSala
    {
        [Key]
        public int DisponibilidadeSalaId { get; set; }

        public ICollection<Sala>? Sala { get; set; }

        public ICollection<Periodo>? Periodo  { get; set; }

    }
}
