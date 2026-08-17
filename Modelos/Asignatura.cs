using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Modelos
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Creditos { get; set; }
        public int? IdDocente { get; set; }
        public bool Estado { get; set; }
    }
}
