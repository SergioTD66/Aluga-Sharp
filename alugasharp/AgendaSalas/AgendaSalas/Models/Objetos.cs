using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class Objetos
    {
        [Key]

        public int ObjetosId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 200 e caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Descrição é obrigatório.", AllowEmptyStrings = false)]
        public string Descricao { get; set; }
    }
}
