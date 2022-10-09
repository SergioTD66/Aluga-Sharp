using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AgendaSalas.Models
{
    public class Periodo
    {
        public enum DiaSemana
        {
            Dias,
                [Description("1")]
                Domindo,
                [Description("2")]
                Segunda_Feira,
                [Description("3")]
                Terca_Feira,
                [Description("4")]
                Quarta_Feira,
                [Description("5")]
                Quinta_Feira,
                [Description("6")]
                Sexta_Feira,
                [Description("7")]
                Sabado
        }
        
        [Key]
        public int PeriodoId { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque dias não pode ficar em branco, ", AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Atenção! Esse campo não pode ser maior que 7. Digite novamente.")]
        public DiaSemana Dia { get; set; }

        public ICollection<Horario>? Horarios { get; set; }

        public float Preco { get; set; }

        public bool? estaAtiva { get; set; }

    }
}
