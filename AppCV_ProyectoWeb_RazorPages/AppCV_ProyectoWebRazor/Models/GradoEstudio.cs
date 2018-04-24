using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCV_ProyectoWebRazor.Models
{
    public class GradoEstudio
    {   
        [Key]
        public int IdCarrerarGradoEstudio { get; set; }
        public int IdCurriculo { get; set; }
        public string NombreCarrera { get; set; }
        public int IdTipoGenGradoStudio { get; set; }
        public int IdGenGradoEstudio { get; set; }
        public string NombreEscuela { get; set; }
        public DateTime PeriodoIni { get; set; }
        public DateTime PeriodoFin { get; set; }
        public string UltimoGradoEstudio { get; set; }
        public string PrefijoEstudio { get; set; }
        public int IdTipoEstatus { get; set; }
        public int IdEstatus { get; set; }


    }
}
