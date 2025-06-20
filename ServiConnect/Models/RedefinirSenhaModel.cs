using System.ComponentModel.DataAnnotations;

namespace ServiConnect.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite seu nome")]
        public string Name{ get; set; }
        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
    }
}
