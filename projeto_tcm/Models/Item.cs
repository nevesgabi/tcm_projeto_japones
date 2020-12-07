using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Item
    {
        [Required(ErrorMessage = "Insira um nome válido!!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 letras")]
        [Display(Name = "Nome:  ")]
        public string NomeItem { get; set; }

        [Required(ErrorMessage = "Insira um preço válido!!")]
        [Display(Name = "Preço:  ")]
        public string PrecoItem { get; set; }

        [Required(ErrorMessage = "Insira uma descrição válida!!")]
        [RegularExpression(@"[a-zA-Z]{10,20}", ErrorMessage = "Insira no mínimo 10 letras")]
        [Display(Name = "Descrição:  ")]
        public string DescItem { get; set; }

        [Required(ErrorMessage = "Insira uma categoria válida!!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 letras")]
        [Display(Name = "Categoria:  ")]
        public string CategoriaItem { get; set; }

        [Display(Name = "ID:  ")]
        public int IdItem { get; set; }
    }
}