using System.ComponentModel.DataAnnotations;

namespace EmailModel.ViewModels
{
    public class EmailVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Mensaje { get; set; }
        [Required]
        public string ParqueaderoNombre { get; set; }
    }
}
