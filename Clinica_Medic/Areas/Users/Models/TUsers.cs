using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Medic.Areas.Users.Models
{
    public class TUsers
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public string NID { get; set; }
        public string Correo { get; set; }
        public string IdUser { get; set; }
        public byte[] Image { get; set; }
    }
}
