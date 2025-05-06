using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiConnect.Models
{
    [Table("PrestadorServicos")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor inserir a Profissão")]
        public string Profission { get; set; }

        [Required(ErrorMessage = "Favor inserir o Email")]           
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor inserir o telefone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Favor inserir as informacoes adicionais")]
        public string AddInformation { get; set; }
    }
}
