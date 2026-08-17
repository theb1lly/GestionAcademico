using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAcademico.Datos;
using GestionAcademico.Modelos;

namespace GestionAcademico
{
    public partial class FormRegistrarCalificacion : Form
    {
        public FormRegistrarCalificacion()
        {
            InitializeComponent();
            CargarInscripciones();
        }

        private void CargarInscripciones()
        {
            List<Inscripcion> inscripciones = InscripcionDatos.ObtenerTodas();

            cmbInscripcion.DataSource = inscripciones;
            cmbInscripcion.DisplayMember = "Descripcion";
            cmbInscripcion.ValueMember = "IdInscripcion";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbInscripcion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una inscripción.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtNota.Text.Trim(), out decimal nota) || nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota válida entre 0 y 100.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Inscripcion inscripcion = (Inscripcion)cmbInscripcion.SelectedItem;

            try
            {
                CalificacionDatos.Registrar(inscripcion.IdInscripcion, nota);

                MessageBox.Show("Calificación registrada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNota.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la calificación:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}