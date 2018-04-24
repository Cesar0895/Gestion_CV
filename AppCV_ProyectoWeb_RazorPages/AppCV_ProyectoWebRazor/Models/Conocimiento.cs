using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCV_ProyectoWebRazor.Models
{
    public class Conocimiento
    {
        [Key]
        public int IdConocimientoDet { get; set; }
        public int IdCurriculo { get; set; }
        public int IdConocimiento { get; set; }
        public string DesConocimiento { get; set; }
        public float Dominio { get; set; }
        public string Detalle { get; set; }
    }
}
