using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class Cadastro
    {
        [Display(Name = "ID:  ")]
        public string idCadastro { get; set; }

        [Required(ErrorMessage = "Insira um telefone válido!")]
        [Display(Name = "Telefone:  ")]
        public string telefoneCadastro { get; set; }

        [Required(ErrorMessage = "Insira um nome válido!")]
        [Display(Name = "Nome completo:  ")]
        public string nomeCadastro { get; set; }

        [Required(ErrorMessage = "Insira um endereço válido!")]
        [Display(Name = "Endereço:  ")]
        public string enderecoCadastro { get; set; }

        [Required(ErrorMessage = "Insira uma função válida!")]
        [Display(Name = "Função:  ")]
        public string funcaoCadastro { get; set; }

        [Required(ErrorMessage = "Insira um usuário válido!")]
        [Display(Name = "Usuário:  ")]
        public string usuarioCadastro { get; set; }

        [Required(ErrorMessage = "Insira um cpf válido!")]
        [Display(Name = "CPF:  ")]
        public string cpfCadastro { get; set; }

        [Required(ErrorMessage = "Insira uma senha válida!")]
        [Display(Name = "Senha:  ")]
        public string senhaCadastro { get; set; }

        [Required(ErrorMessage = "Confira se as duas senhas se igualam!")]
        [Display(Name = "Confirmar senha:  ")]
        public string confirmaCadastro { get; set; }

        [Required(ErrorMessage = "Insira um nível de acesso válido!")]
        [Display(Name = "Nível de acesso:  ")]
        public string nivelCadastro { get; set; }
    }
}