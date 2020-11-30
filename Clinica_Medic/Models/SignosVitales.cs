using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Medic.Models
{
    public class SignosVitales
    {
        public int Id { get; set; }

        [Display(Name = "Dpi")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[0-9]{4}\s[0-9]{5}\s[0-9]{4}|[0-9]{13}",
            ErrorMessage = "Dato incorrecto.")]
        public string Dpi { get; set; }

        [Display(Name = "Temperatura")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[0-5][0-9] [CF]|[0-5]{1}[0-9]{1}",
            ErrorMessage = "Dato incorrecto. Ejemplo 04 C o F")]
        public string Temperatura { get; set; }

        [Display(Name = "Presion")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[0-9]*[/][0-9]*|[0-9]*",
          ErrorMessage = "Dato incorrecto.")]
        public string Presion { get; set; }

        [Display(Name = "Peso")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[0-9]*[libras|[0-9]*",
          ErrorMessage = "Dato incorrecto. ejemplo 100 libras")]
        public string Peso { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Fecha { get; set; }
    }
}
