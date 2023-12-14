using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o E-mail do contato")]
        [EmailAddress(ErrorMessage = "O E-mail informado é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Número do Contato")]
        [Phone(ErrorMessage = "O Numero informado é inválido")]
        public string Numero { get; set; }
    }
}
