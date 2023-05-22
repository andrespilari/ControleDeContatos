using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Senha { get; set; }
    }
}
