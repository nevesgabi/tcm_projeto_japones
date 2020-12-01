using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Mesa
    {
        [Required(ErrorMessage = "Insira um número de mesa válido!!")]
        [Display(Name = "Número da mesa:  ")]
        public string mesa { get; set; }

        [Required(ErrorMessage = "Insira o status da mesa!!")]
        [Display(Name = "Status da mesa:  ")]
        public string statusmesa { get; set; }

        [Required(ErrorMessage = "Insira o número de assentos da mesa!!")]
        [Display(Name = "Número de assentos:  ")]
        public string assentos { get; set; }

        [Display(Name = "Id:  ")]
        public string idmesa { get; set; }
    }
}