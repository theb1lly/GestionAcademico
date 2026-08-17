using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAcademico.Datos;
using GestionAcademico.Modelos;

namespace GestionAcademico
{
    public partial class FormCrearAsignatura : Form
    {
        private List<Docente> docentes;

        public FormCrearAsignatura()
        {
            InitializeComponent();
            CargarDocentes();
        }

        private void CargarDocentes()
        {
            docentes = DocenteDatos.ObtenerTodos();

            // Agregamos una opción "Sin asignar" al inicio de la lista
            docentes.Insert(0, new Docente { IdDocente = 0, NombreCompleto = "-- Sin asignar --" });

            cmbDocente.DataSource = docentes;
            cmbDocente.DisplayMember = "NombreCompleto";
            cmbDocente.ValueMember = "IdDocente";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe completar nombre y código.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCreditos.Text.Trim(), out int creditos) || creditos <= 0)
            {
                MessageBox.Show("Ingrese un número válido de créditos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Docente docenteSeleccionado = (Docente)cmbDocente.SelectedItem;
            int? idDocente = (docenteSeleccionado.IdDocente == 0) ? (int?)null : docenteSeleccionado.IdDocente;

            try
            {
                AsignaturaDatos.Insertar(nombre, codigo, creditos, idDocente);

                MessageBox.Show("Asignatura creada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtCodigo.Clear();
                txtCreditos.Clear();
                cmbDocente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la asignatura:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}