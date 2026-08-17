using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAcademico.Modelos;

namespace GestionAcademico
{
    public partial class HomeForm : Form
    {
        private Usuario usuarioActual;

        public HomeForm(Usuario usuario)
        {
            InitializeComponent();

            // Guardamos el usuario que inició sesión
            usuarioActual = usuario;

            // Cambiamos el título según el rol
            this.Text = "Sistema de Gestión Académica - " + usuarioActual.Rol;

            // Configuramos los menús según el rol
            ConfigurarMenuSegunRol();
        }

        private void ConfigurarMenuSegunRol()
        {
            switch (usuarioActual.Rol)
            {
                case "Administrador":

                    // El administrador puede ver todo
                    break;

                case "Docente":

                    menuUsuarios.Visible = false;
                    menuEstudiantesDocentes.Visible = false;
                    menuAsignaturas.Visible = false;
                    menuInscripciones.Visible = false;
                    menuReportes.Visible = false;

                    // Calificaciones y Consultas permanecen visibles
                    break;

                case "Estudiante":

                    menuUsuarios.Visible = false;
                    menuEstudiantesDocentes.Visible = false;
                    menuAsignaturas.Visible = false;
                    menuCalificaciones.Visible = false;
                    menuReportes.Visible = false;

                    // Inscripciones y Consultas permanecen visibles
                    break;

                default:

                    // Si el usuario no tiene un rol reconocido,
                    // ocultamos todos los menús sensibles.
                    menuUsuarios.Visible = false;
                    menuEstudiantesDocentes.Visible = false;
                    menuAsignaturas.Visible = false;
                    menuInscripciones.Visible = false;
                    menuCalificaciones.Visible = false;
                    menuReportes.Visible = false;
                    menuConsultas.Visible = false;

                    break;
            }
        }
    }
}