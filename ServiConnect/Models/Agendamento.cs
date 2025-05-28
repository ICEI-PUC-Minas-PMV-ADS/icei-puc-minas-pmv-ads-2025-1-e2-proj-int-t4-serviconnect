using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServiConnect.Models
{

    [Table("Agendamento")]
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar o local")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar a data")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio colocar a hora")]
        public string Hora { get; set; }

    }
}
