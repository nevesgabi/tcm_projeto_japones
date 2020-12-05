using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Models
{
    public class Mesaa
    {
        [Required(ErrorMessage = "Insira um número de mesa válido!!")]
        [Display(Name = "Número da mesa:  ")]
        public string mesa { get; set; }

        [Required(ErrorMessage = "Insira um número de assentos válido!!")]
        [Display(Name = "Quantidade de assentos:  ")]
        public string assentos { get; set; }

        [Required(ErrorMessage = "Insira um status válido!!")]
        [Display(Name = "Status:  ")]
        public string statusmesa { get; set; }

        [Display(Name = "Id da mesa:  ")]
        public string idmesa { get; set; }
    }
}