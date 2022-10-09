using System.ComponentModel.DataAnnotations;


namespace AgendaSalas.Models
{
    public class Servicos
    {
        [Key]
        public int ServicoID { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Descrição é obrigatório.", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Custo é obrigatório.", AllowEmptyStrings = false)]
        public string Custo { get; set; }
        
    }
}
