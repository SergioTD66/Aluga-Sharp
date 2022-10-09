using System.ComponentModel.DataAnnotations;
namespace AgendaSalas.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        public ICollection<DisponibilidadeSala>? DisponibilidadeSalas { get; set; }

        public ICollection<Equipamento>? Equipamentos { get; set; }

        public ICollection<Servicos>? Servicos { get; set; }

        public ICollection<Objetos>? Objetos { get; set; }

        public bool? FazerContratacao { get; set; }

    }
}
