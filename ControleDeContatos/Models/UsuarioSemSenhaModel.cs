using ControleDeContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public PerfilEnum? Perfil { get; set; }
    }
}
