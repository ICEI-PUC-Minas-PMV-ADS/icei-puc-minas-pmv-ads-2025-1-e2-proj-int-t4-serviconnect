using System.ComponentModel.DataAnnotations;

namespace ServiConnect.Models
{
    public class LoginAdmin
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }
    }
}
