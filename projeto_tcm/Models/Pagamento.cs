using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Pagamento
    {
        [Required(ErrorMessage = "Insira um troco válido!")]
        [Display(Name = "Troco:  ")]
        public string trocoPagamento { get; set; }

        [Required(ErrorMessage = "Insira um total válido!")]
        [Display(Name = "Total:  ")]
        public string totalPagamento { get; set; }

        [Required(ErrorMessage = "Insira um total válido!")]
        [Display(Name = "Total pago:  ")]
        public string totalPago { get; set; }

        [Required(ErrorMessage = "Selecione um tipo de pagamento válido!")]
        [Display(Name = "Tipo de pagamento:  ")]
        public string tipoPag { get; set; }

        [Required(ErrorMessage = "Insira um CPF válido!")]
        [Display(Name = "CPF:  ")]
        public string cpfPagamento { get; set; }

        [Required(ErrorMessage = "Insira um status válido!")]
        [Display(Name = "Status:  ")]
        public string statusPagamento { get; set; }

        [Display(Name = "Id:  ")]
        public int idPagamento { get; set; }

        [Required(ErrorMessage = "Insira uma comanda válida!")]
        [Display(Name = "Comanda:  ")]
        public int comandaPagamento { get; set; }
    }
}