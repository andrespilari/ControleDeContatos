using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Email { get; set; }
    }
}