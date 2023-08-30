using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string SenhaAtual { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NovaSenha { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        //comando abaixo usado para comparar os campos e nesse caso passa o nome do campo que quer comprar no caso a variavel acima "NovaSenha".
        [Compare("NovaSenha", ErrorMessage = "Essa senha não é igual a nova senha.")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
