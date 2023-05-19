using ControleDeContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "Obrigatório preencher esse campo.")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
