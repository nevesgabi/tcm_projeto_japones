using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class UserLogin
    {
        public int cad_usuario { get; set; }

        [Required(ErrorMessage = "Insira um usuário válido!!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        [Display(Name = "Usuário")]
        public string nome_usuario { get; set; }

        [Required(ErrorMessage = "Insira uma senha válida!!")]
        [RegularExpression(@"[a-zA-Z0-9]{3,20}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        [Display(Name = "Senha")]
        public string senha { get; set; }
    }
}