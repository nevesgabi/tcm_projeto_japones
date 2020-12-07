using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class UserLogin
    {
        public int cad_usuario { get; set; }

        [Required(ErrorMessage = "Insira um usuário válido!!")]
        [Range(10, 20)]
        [Display(Name = "Usuário   ")]
        public string nome_usuario { get; set; }

        [Required(ErrorMessage = "Insira uma senha válida!!")]
        [Display(Name = "Senha   ")]
        public string senha { get; set; }
    }
}