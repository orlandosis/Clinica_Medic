using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clinica_Medic.Data;
using Clinica_Medic.Library;

namespace Clinica_Medic.Areas.Principal.Controllers
{
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        
        public PrincipalController(
          ApplicationDbContext context)
        {
           
        }
        public IActionResult Principal()
        {
            
            return View();
        }
    }
}