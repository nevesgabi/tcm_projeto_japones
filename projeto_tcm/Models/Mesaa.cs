using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Mesaa
    {
        [Required(ErrorMessage = "Insira um número de mesa válido!!")]
        [RegularExpression(@"[0-9]{1,5}", ErrorMessage = "Insira apenas números")]
        [Display(Name = "Número da mesa:  ")]
        public int mesa { get; set; }

        [Required(ErrorMessage = "Insira um número de assentos válido!!")]
        [RegularExpression(@"[0-9]{1,5}", ErrorMessage = "Insira apenas números")]
        [Display(Name = "Quantidade de assentos:  ")]
        public int assentos { get; set; }

        [Required(ErrorMessage = "Insira um status válido!!")]
        [RegularExpression(@"[a-zA-Z]{3,8}", ErrorMessage = "Insira no minimo 3 letras")]
        [Display(Name = "Status:  ")]
        public string statusmesa { get; set; }

        [Display(Name = "Id da mesa:  ")]
        public int idmesa { get; set; }
    }
}