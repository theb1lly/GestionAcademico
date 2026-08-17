using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Modelos
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public int? Semestre { get; set; }
        public bool Estado { get; set; }
    }
}
