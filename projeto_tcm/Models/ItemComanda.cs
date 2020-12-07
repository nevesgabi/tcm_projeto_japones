using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace projeto_tcm.Models
{
    public class ItemComanda
    {
        [Required(ErrorMessage = "Insira uma quantidade válida!")]
        [Display(Name = "Quantidade:  ")]
        public int qt_item { get; set; }
        [Required(ErrorMessage = "Insira uma comanda válida!")]
        [Display(Name = "ID Comanda:  ")]
        public int id_comanda { get; set; }
        [Required(ErrorMessage = "Insira um item válido!")]
        [Display(Name = "ID item:  ")]
        public int id_item { get; set; }
    }

    public class ItemFormatadoResposta
    {
        public List<ItemComandaFormatado> itens { get; set; }
        public double total { get; set; }
    }

    public class ItemComandaFormatado
    {
        public string nome_item { get; set; }
        public double preco_item { get; set; }
        public int qtd_item { get; set; }
    }
}