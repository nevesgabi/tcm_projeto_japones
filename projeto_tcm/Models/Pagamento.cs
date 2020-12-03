using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Pagamento
    {
        [Required(ErrorMessage = "Insira uma comanda válida!")]
        [Display(Name = "Comanda:  ")]
        public string comandaPagamento { get; set; }

        [Required(ErrorMessage = "Insira um total válido!")]
        [Display(Name = "Total:  ")]
        public string totalPagamento { get; set; }

        [Required(ErrorMessage = "Insira uma taxa de serviço válida!")]
        [Display(Name = "Taxa de serviço:  ")]
        public string taxaPagamento { get; set; }

        [Required(ErrorMessage = "Insira um CPF válido!")]
        [Display(Name = "CPF:  ")]
        public string cpfPagamento { get; set; }

        [Required(ErrorMessage = "Selecione um tipo de pagamento válido!")]
        [Display(Name = "Tipo de pagamento:  ")]
        public string tipoPag { get; set; }

        [Required(ErrorMessage = "Insira um total válido!")]
        [Display(Name = "Total pago:  ")]
        public string totalPago { get; set; }

        [Required(ErrorMessage = "Insira um troco válido!")]
        [Display(Name = "Troco:  ")]
        public string trocoPagamento { get; set; }

        [Display(Name = "Id:  ")]
        public string idPagamento { get; set; }
    }
}