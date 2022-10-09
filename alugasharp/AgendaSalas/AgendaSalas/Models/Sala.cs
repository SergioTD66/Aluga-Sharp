using System.ComponentModel.DataAnnotations;


namespace AgendaSalas.Models
{
    public class Sala
    {
        [Key]

        public int SalaId { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque o Identificaçao principal da sala", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 1, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 200 e caracteres.")]
        public string Identificacao { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque informações sobre o local.", AllowEmptyStrings = false)]
        [StringLength(600, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 200 e caracteres.")]
        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Voltagem { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque o numero inteiro do metro do hambiente da lateral", AllowEmptyStrings = false)]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Atenção! Esse campo não pode ser maior que 99.")]
        public string medidaLado1EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque o numero inteiro do metro do hambiente da horizontal", AllowEmptyStrings = false)]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Atenção! Esse campo não pode ser maior que 99.")]
        public string medidaLado2EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! Coloque a quantidade pessoas que estão no hambiente", AllowEmptyStrings = false)]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Atenção! Esse campo não pode ser maior que 999.")]
        public string numeroMaximoDePessoas { get; set; }

        public string Janelas { get; set; }
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Atenção! Esse campo não pode ser maior que 99.")]

        public ICollection<Endereco>? Localizacao { get; set; }
        

    }

}


