using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Medic.Models
{
    public class CIE10 
    {
       // public int? id;
       // public string cod;
      //  public string name;

        //public CIE10(int? id,string cod, string name)
       // {
            //this.id = id;
            //this.name = name;
            //this.cod = cod;
        //}

        public int Id { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z][0-9]*",
           ErrorMessage = "Dato incorrecto.")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*([a-zA-Z]* [a-zA-Z]*)*",
            ErrorMessage = "Dato incorrecto.")]
        public string Nombre { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*([a-zA-Z]* [a-zA-Z]*)*",
           ErrorMessage = "Dato incorrecto.")]
        public string Categoria { get; set; }


        [Display(Name = "Descripcion")]
        
        [RegularExpression(@"[a-zA-Z]*([a-zA-Z]* [a-zA-Z]*[0-9]*)*",
          ErrorMessage = "Dato incorrecto.")]
        public string Descripcion { get; set; }

    }
}
