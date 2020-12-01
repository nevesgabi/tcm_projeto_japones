using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Item
    {
        [Required(ErrorMessage = "Insira um nome válido!!")]
        [Display(Name = "Nome:  ")]
        public string NomeItem { get; set; }

        [Required(ErrorMessage = "Insira um preço válido!!")]
        [Display(Name = "Preço:  ")]
        public string PrecoItem { get; set; }

        [Required(ErrorMessage = "Insira uma descrição válida!!")]
        [Display(Name = "Descrição:  ")]
        public string DescItem { get; set; }

        [Display(Name = "ID:  ")]
        public string IdItem { get; set; }
    }
}