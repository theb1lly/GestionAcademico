using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Modelos
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public int IdPeriodo { get; set; }
        public string NombrePeriodo { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Estado { get; set; }

        public string Descripcion
        {
            get { return $"{NombreEstudiante} - {NombreAsignatura} - {NombrePeriodo}"; }
        }
    }
}