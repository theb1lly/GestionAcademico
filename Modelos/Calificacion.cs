using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Modelos
{
    public class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int IdInscripcion { get; set; }
        public string NombreAsignatura { get; set; }
        public decimal Nota { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
