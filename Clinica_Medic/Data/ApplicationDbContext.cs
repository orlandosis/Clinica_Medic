using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Clinica_Medic.Models;
using Clinica_Medic.Areas.Users.Models;

namespace Clinica_Medic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        static DbContextOptions<ApplicationDbContext> _options;
        public ApplicationDbContext() : base(_options)
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _options = options;
        }
        public DbSet<TUsers> TUsers { get; set; }
        public DbSet<Clinica_Medic.Models.CIE10> CIE10 { get; set; }

        public DbSet<Clinica_Medic.Models.Registro> Registro { get; set; }

        public DbSet<Clinica_Medic.Models.SignosVitales> SignosVitales { get; set; }

        public DbSet<Clinica_Medic.Models.Historial> Historial { get; set; }
    }
}
