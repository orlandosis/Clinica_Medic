using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Medic.Models
{
    public class Historial
    {
        public int Id { get; set; }

        [Display(Name = "Sintomas")]
        [Required(ErrorMessage = "Este campo es requerido.")]
       
        public string Sintomas { get; set; }

        [Display(Name = "Medicamento")]
        [Required(ErrorMessage = "Este campo es requerido.")]

        public string Medicamento { get; set; }

        [Display(Name = "Instrucciones")]
        [Required(ErrorMessage = "Este campo es requerido.")]

        public string Instrucciones { get; set; }

        [Display(Name = "Examen de Laboratorio")]
        [Required(ErrorMessage = "Este campo es requerido.")]

        public string Examen { get; set; }
    }
}
