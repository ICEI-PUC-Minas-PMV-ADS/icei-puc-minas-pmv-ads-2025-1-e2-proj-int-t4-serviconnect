using System.ComponentModel.DataAnnotations;
using ServiConnect.Enums;

namespace ServiConnect.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Digite o nome" )]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        public PerfilEnum? Perfil { get; set; }

        public bool SenhaValida(string password)
        {
            return password == Password;
        }
    }

}
