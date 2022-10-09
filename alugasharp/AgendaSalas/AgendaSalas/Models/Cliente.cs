using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 200 e caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Atenção! O campo E-mail deve ser preenchido!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Atenção! Informe um e-mail válido.")]
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        /*        
                public override string ToString()
                {
                    return "Nome: " + Nome + " \nE-mail: " + Email + " \nCelular: " + Celular + " \nCpf: " + Cpf + " \nRg: " + Rg;
                }
        */
    }
}
