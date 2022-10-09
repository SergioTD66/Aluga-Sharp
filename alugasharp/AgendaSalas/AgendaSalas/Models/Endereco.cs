using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }        

        [Required(ErrorMessage = "Atenção! O campo Logradouro é obrigatório.", AllowEmptyStrings = false)]
        public string Logradouro { get; set; }
        
        [Required(ErrorMessage = "Atenção! O campo Bairro é obrigatório.", AllowEmptyStrings = false)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Numero deve ser preenchido!")]
        [Range(0, int.MaxValue, ErrorMessage = "Atenção! Informe um número válido")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Complemento é obrigatório.", AllowEmptyStrings = false)]
        public string Complemento { get; set; }

        public override string ToString()
        {
            return "Logradouro: " + Logradouro + " \nBairro: " + Bairro + " \nNumero: " + Numero + " \nComplemento: " + Complemento;
        }
    }
}
