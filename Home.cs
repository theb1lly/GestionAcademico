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

            // Habilitar como contenedor MDI para que otros formularios puedan asignar MdiParent = this
            this.IsMdiContainer = true;

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
                    // Ve todo, no se oculta nada
                    break;

                case "Docente":
                    // Menús principales que NO puede usar
                    menuUsuarios.Visible = false;
                    menuAsignaturas.Visible = false;
                    menuInscripciones.Visible = false;
                    menuReportes.Visible = false;
                    // menuCalificaciones queda visible (puede registrar notas)
                    // menuConsultas queda visible, pero limitamos qué puede ver adentro:
                    verUsuariosToolStripMenuItem.Visible = false;
                    verDocentesToolStripMenuItem.Visible = false;
                    // Ver Estudiantes, Ver Asignaturas, Ver Inscripciones, Ver Calificaciones quedan visibles
                    break;

                case "Estudiante":
                    // Menús principales que NO puede usar
                    menuUsuarios.Visible = false;
                    menuAsignaturas.Visible = false;
                    menuCalificaciones.Visible = false;
                    menuReportes.Visible = false;
                    // menuInscripciones queda visible (se inscribe a sí mismo)
                    // menuConsultas queda visible, pero limitamos qué puede ver adentro:
                    verUsuariosToolStripMenuItem.Visible = false;
                    verEstudiantesToolStripMenuItem.Visible = false;
                    verDocentesToolStripMenuItem.Visible = false;
                    // Ver Asignaturas, Ver Inscripciones, Ver Calificaciones quedan visibles
                    break;
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            // Buscar si el formulario ya está abierto
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is FormCrearUsuario)
                {
                    // Si está minimizado, restaurarlo
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }

                    // Llevarlo al frente
                    formulario.Activate();

                    return;
                }
            }

            // Si no está abierto, crear una nueva ventana
            FormCrearUsuario crearUsuario = new FormCrearUsuario();

            // Hacer que HomeForm sea su formulario padre
            crearUsuario.MdiParent = this;

            // Mostrarlo dentro de HomeForm
            crearUsuario.Show();
        }

        private void menuAsignaturas_Click(object sender, EventArgs e)
        {
            // Buscar si el formulario ya está abierto
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is FormCrearAsignatura)
                {
                    // Si está minimizado, restaurarlo
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }

                    // Llevarlo al frente
                    formulario.Activate();

                    return;
                }
            }

            // Si no está abierto, crear una nueva ventana
            FormCrearAsignatura crearAsignaturas = new FormCrearAsignatura();

            // Hacer que HomeForm sea su formulario padre
            crearAsignaturas.MdiParent = this;

            // Mostrarlo dentro de HomeForm
            crearAsignaturas.Show();
        }

        private void menuInscripciones_Click(object sender, EventArgs e)
        {
            {
                // Buscar si el formulario ya está abierto
                foreach (Form formulario in this.MdiChildren)
                {
                    if (formulario is FormNuevaInscripcion)
                    {
                        // Si está minimizado, restaurarlo
                        if (formulario.WindowState == FormWindowState.Minimized)
                        {
                            formulario.WindowState = FormWindowState.Normal;
                        }

                        // Llevarlo al frente
                        formulario.Activate();

                        return;
                    }
                }

                // Si no está abierto, crear una nueva ventana
                FormNuevaInscripcion crearAsignaturas = new FormNuevaInscripcion();

                // Hacer que HomeForm sea su formulario padre
                crearAsignaturas.MdiParent = this;

                // Mostrarlo dentro de HomeForm
                crearAsignaturas.Show();
            }
        }

        private void menuCalificaciones_Click(object sender, EventArgs e)
        {
            {
                // Buscar si el formulario ya está abierto
                foreach (Form formulario in this.MdiChildren)
                {
                    if (formulario is FormRegistrarCalificacion)
                    {
                        // Si está minimizado, restaurarlo
                        if (formulario.WindowState == FormWindowState.Minimized)
                        {
                            formulario.WindowState = FormWindowState.Normal;
                        }

                        // Llevarlo al frente
                        formulario.Activate();

                        return;
                    }
                }

                // Si no está abierto, crear una nueva ventana
                FormRegistrarCalificacion crearAsignaturas = new FormRegistrarCalificacion();

                // Hacer que HomeForm sea su formulario padre
                crearAsignaturas.MdiParent = this;

                // Mostrarlo dentro de HomeForm
                crearAsignaturas.Show();
            }
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            {
                // Buscar si el formulario ya está abierto
                foreach (Form formulario in this.MdiChildren)
                {
                    if (formulario is FormReporteGeneral)
                    {
                        // Si está minimizado, restaurarlo
                        if (formulario.WindowState == FormWindowState.Minimized)
                        {
                            formulario.WindowState = FormWindowState.Normal;
                        }

                        // Llevarlo al frente
                        formulario.Activate();

                        return;
                    }
                }

                // Si no está abierto, crear una nueva ventana
                FormReporteGeneral crearAsignaturas = new FormReporteGeneral();

                // Hacer que HomeForm sea su formulario padre
                crearAsignaturas.MdiParent = this;

                // Mostrarlo dentro de HomeForm
                crearAsignaturas.Show();
            }
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerUsuarios().Show();
        }

        private void verEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerEstudiantes().Show();
        }

        private void verDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerDocentes().Show();
        }

        private void verAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerAsignaturas().Show();
        }

        private void verInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerInscripciones().Show();
        }

        private void verCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVerCalificaciones().Show();
        }
    }
}