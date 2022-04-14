using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        private string Descricao { get; set; }
        [Required]
        private DateTime DataPagamento { get; set; }

        [Required]
        private Decimal Valor { get; set; }
        
        private DateTime DataVencimento { get; set; }

        public virtual Classificacao Classificacao { get; set; }
        
        public virtual Tipo Tipo { get; set; }
    }
}
