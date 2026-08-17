using GestionAcademico.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademico
{
    public partial class FormReporteGeneral : Form
    {
        public FormReporteGeneral()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                int totalUsuarios = ReporteDatos.ContarUsuarios();
                int totalEstudiantes = ReporteDatos.ContarEstudiantes();
                int totalDocentes = ReporteDatos.ContarDocentes();
                int totalAsignaturas = ReporteDatos.ContarAsignaturas();
                int totalInscripciones = ReporteDatos.ContarInscripciones();
                decimal promedio = ReporteDatos.ObtenerPromedioGeneral();

                lblTotalUsuarios.Text = "Total de usuarios: " + totalUsuarios;
                lblTotalEstudiantes.Text = "Total de estudiantes: " + totalEstudiantes;
                lblTotalDocentes.Text = "Total de docentes: " + totalDocentes;
                lblTotalAsignaturas.Text = "Total de asignaturas: " + totalAsignaturas;
                lblTotalInscripciones.Text = "Total de inscripciones: " + totalInscripciones;
                lblPromedioGeneral.Text = "Promedio general de calificaciones: " + promedio.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
