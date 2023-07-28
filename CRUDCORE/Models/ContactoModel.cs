using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {

        public int IdContacto { get; set; }

        [Required(ErrorMessage ="El campo Nombre es Obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es Obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es Obligatorio")]
        public string? Correo { get; set; }
    }
}
