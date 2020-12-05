using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Mesaa
    {
        [Required(ErrorMessage = "Insira um número de mesa válido!!")]
        [Display(Name = "Número da mesa:  ")]
        public int mesa { get; set; }

        [Required(ErrorMessage = "Insira um número de assentos válido!!")]
        [Display(Name = "Quantidade de assentos:  ")]
        public int assentos { get; set; }

        [Required(ErrorMessage = "Insira um status válido!!")]
        [Display(Name = "Status:  ")]
        public string statusmesa { get; set; }

        [Display(Name = "Id da mesa:  ")]
        public int idmesa { get; set; }
    }
}