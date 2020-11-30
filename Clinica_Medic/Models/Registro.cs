using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Medic.Models
{
    public class Registro
    {
        public int Id { get; set; }

        [Display(Name = "Dpi")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[0-9]{4}\s[0-9]{5}\s[0-9]{4}|[0-9]{13}",
            ErrorMessage = "Dato incorrecto.")]

        public string Dpi { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*|[a-zA-Z]* [a-zA-Z]* ",
            ErrorMessage = "Dato incorrecto.")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*|[a-zA-Z]* [a-zA-Z]*",
            ErrorMessage = "Dato incorrecto.")]
        public string Apellido { get; set; }

        [Display(Name = "Fecha_nacimiento")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_nacimiento { get; set; }

        [Display(Name = "Tipo_sangre")]

        //[RegularExpression(@"A+|B+|O+",
        //    ErrorMessage = "Dato incorrecto.")]
        public string Tipo_sangre { get; set; }

    }
}
