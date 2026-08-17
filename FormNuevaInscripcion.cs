using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAcademico.Datos;
using GestionAcademico.Modelos;

namespace GestionAcademico
{
    public partial class FormNuevaInscripcion : Form
    {
        public FormNuevaInscripcion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Estudiante> estudiantes = EstudianteDatos.ObtenerTodos();
            cmbEstudiante.DataSource = estudiantes;
            cmbEstudiante.DisplayMember = "NombreCompleto";
            cmbEstudiante.ValueMember = "IdEstudiante";

            List<Asignatura> asignaturas = AsignaturaDatos.ObtenerTodos();
            cmbAsignatura.DataSource = asignaturas;
            cmbAsignatura.DisplayMember = "Nombre";
            cmbAsignatura.ValueMember = "IdAsignatura";

            List<Periodo> periodos = PeriodoDatos.ObtenerTodos();
            cmbPeriodo.DataSource = periodos;
            cmbPeriodo.DisplayMember = "Nombre";
            cmbPeriodo.ValueMember = "IdPeriodo";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedItem == null ||
                cmbAsignatura.SelectedItem == null ||
                cmbPeriodo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar estudiante, asignatura y período.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiante estudiante = (Estudiante)cmbEstudiante.SelectedItem;
            Asignatura asignatura = (Asignatura)cmbAsignatura.SelectedItem;
            Periodo periodo = (Periodo)cmbPeriodo.SelectedItem;

            try
            {
                InscripcionDatos.Insertar(estudiante.IdEstudiante, asignatura.IdAsignatura, periodo.IdPeriodo);

                MessageBox.Show("Inscripción registrada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribir:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}