using System.ComponentModel.DataAnnotations;
using ServiConnect.Enums;
using ServiConnect.Repositorio;

namespace ServiConnect.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [Required(ErrorMessage = "digite seu nome")]
        public string Password { get; set; }
        [Required(ErrorMessage = "digite sua senha")]
        public string Email { get; set; }
        [Required(ErrorMessage = "digite seu email")]
        [EmailAddress(ErrorMessage = "o email informado não é valido!")]

        public PerfilEnum Perfil { get; set; }

    }
}
