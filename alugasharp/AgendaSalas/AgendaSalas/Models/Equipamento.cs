using System.ComponentModel.DataAnnotations;
namespace AgendaSalas.Models
{
    public class Equipamento
    {
        [Key]
        public int EquipamentosId { get; set; }
        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(550, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 500 caracter.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Atenção! O campo Descricao é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(550, MinimumLength = 10, ErrorMessage = "Atenção! O campo descrição deve ter entre 10 e 500 caracter.")]
        public string Descricao { get; set; }
public string Voltagem { get; set; }
        public float Peso { get; set; }
        public string Volume { get; set; }
public float CustoTotal { get; set; }
        public float CustoSeguro { get; set; }
public float CustoHora { get; set; }


            
    }
}
