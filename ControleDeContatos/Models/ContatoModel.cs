using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        [Phone(ErrorMessage = "Celular inválido.")]
        public string Celular { get; set; }
        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}
