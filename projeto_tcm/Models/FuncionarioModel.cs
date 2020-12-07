using System.ComponentModel.DataAnnotations;

namespace projeto_tcm.Models
{
    public class FuncionarioModel
    {
        [Display(Name = "ID:  ")]
        public int idCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[0-9]{8,10}", ErrorMessage = "Insira no minimo 8 números")]
        [Display(Name = "Telefone:  ")]
        public string telefoneCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 letras")]
        [Display(Name = "Nome completo:  ")]
        public string nomeCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[a-zA-Z0-9]{10,40}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        [Display(Name = "Endereço:  ")]
        public string enderecoCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Insira no mínimo 3 letras")]
        [Display(Name = "Função:  ")]
        public string funcaoCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[a-zA-Z0-9]{3,20}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        [Display(Name = "Usuário:  ")]
        public string usuarioCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "CPF:  ")]
        [RegularExpression(@"[a-zA-Z0-9]{6,20}", ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string cpfCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Senha:  ")]
        [RegularExpression(@"[a-zA-Z0-9]{8,20}", ErrorMessage = "Insira no mínimo 8 caracteres")]
        public string senhaCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"[0-9]{1}", ErrorMessage = "Insira apenas 1 número")]
        [Display(Name = "Nível de acesso:  ")]
        public string nivelCadastro { get; set; }
    }
}