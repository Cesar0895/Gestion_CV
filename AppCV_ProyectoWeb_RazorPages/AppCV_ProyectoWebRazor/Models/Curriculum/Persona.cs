using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCV_ProyectoWebRazor.Models
{
    public class Persona
    {
        [Key]
        public int IdCurriculo { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}
