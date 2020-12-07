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
        [Display(Name = "Mesa:  ")]
        public int mesaComanda { get; set; }

        [Required(ErrorMessage = "Insira um item válido!")]
        [Display(Name = "Item:  ")]
        public int itemComanda { get; set; }

        [Required(ErrorMessage = "Insira um funcionário válido!")]
        [Display(Name = "Funcionário responsável:  ")]
        public int funcionarioComanda { get; set; }

        [Required(ErrorMessage = "Insira um código de comanda válido!")]
        [Display(Name = "ID:  ")]
        public int idComanda { get; set; }

        [Required(ErrorMessage = "Insira um total!")]
        [Display(Name = "Total:  ")]
        public string totalComanda { get; set; }

        [Required(ErrorMessage = "Insira um status!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        [Display(Name = "Status:  ")]
        public string statusComanda { get; set; }
    }
}
