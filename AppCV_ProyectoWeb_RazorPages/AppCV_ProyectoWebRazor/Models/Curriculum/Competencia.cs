using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCV_ProyectoWebRazor.Models
{
    public class Competencia
    {
        [Key]
        public int IdCompetenciaDet { get; set; }
        public int IdCurriculo { get; set; }
        public int IdCompetencia { get; set; }
        public string DesCompetencia { get; set; }
        public float Dominio { get; set; }
        public string Detalle { get; set; }
    }
}
