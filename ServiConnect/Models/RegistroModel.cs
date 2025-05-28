using System.ComponentModel.DataAnnotations;

namespace ServiConnect.Models
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

    }
}
