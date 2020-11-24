using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class UserLogin
    {
        public int cad_usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do aluno!!")]
        [Display(Name = "Usuário:  ")]
        public string nome_usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do aluno!!")]
        [Display(Name = "Senha:  ")]
        public string senha { get; set; }
    }
}