using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiConnect.Models
{
    [Table("Prestadores")]
    public class Prestador
    {
        [Key]
        public int Id {  get; set; } 

        [Required(ErrorMessage = "Obrigatorio colocar a profissão")]
        public string Profissão { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar o telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar as informações adicionais")]
        public string Informações { get; set; }
    }
}
