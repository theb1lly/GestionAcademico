using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Modelos
{
    public class Docente
    {
        public int IdDocente { get; set; }
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad { get; set; }
        public bool Estado { get; set; }
    }
}
