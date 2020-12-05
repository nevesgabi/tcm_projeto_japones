using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Comanda
    {
        [Required(ErrorMessage = "Insira uma data válida!")]
        [Display(Name = "Data:  ")]
        public string dataComanda { get; set; }

        [Required(ErrorMessage = "Insira um horário válido!")]
        [Display(Name = "Horário:  ")]
        public string horarioComanda { get; set; }

        [Required(ErrorMessage = "Insira uma mesa válida!")]
        [Display(Name = "Número da mesa:  ")]
        public string mesaComanda { get; set; }

        [Required(ErrorMessage = "Insira um item válido!")]
        [Display(Name = "Item:  ")]
        public string itemComanda { get; set; }

        [Required(ErrorMessage = "Insira uma quantidade válida!")]
        [Display(Name = "Quantidade:  ")]
        public string quantidadeComanda { get; set; }

        [Required(ErrorMessage = "Insira um funcionário válido!")]
        [Display(Name = "Funcionário responsável:  ")]
        public string funcionarioComanda { get; set; }

        [Required(ErrorMessage = "Insira um código de comanda válido!")]
        [Display(Name = "ID:  ")]
        public string idComanda { get; set; }

        [Required(ErrorMessage = "Insira um total!")]
        [Display(Name = "Total:  ")]
        public string totalComanda { get; set; }

        [Required(ErrorMessage = "Insira um total!")]
        [Display(Name = "Total:  ")]
        public string statusComanda { get; set; }
    }
}
