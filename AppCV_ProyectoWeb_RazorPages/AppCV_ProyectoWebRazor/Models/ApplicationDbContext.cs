using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCV_ProyectoWebRazor.Models;

namespace AppCV_ProyectoWebRazor.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Competencia> Competencias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<GradoEstudio> GradosEstudios { get; set; }
        public DbSet<Conocimiento> Conocimientos { get; set; }

        public DbSet<AppCV_ProyectoWebRazor.Models.Persona> Persona { get; set; }
        public DbSet<AppCV_ProyectoWebRazor.Models.GradoEstudio> GradoEstudio { get; set; }
    }
}
