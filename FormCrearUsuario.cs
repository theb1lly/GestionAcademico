using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAcademico.Datos;
using GestionAcademico.Modelos;
using GestionAcademico.Utilidades;

namespace GestionAcademico
{
    public partial class FormCrearUsuario : Form
    {
        private List<Rol> roles;

        public FormCrearUsuario()
        {
            InitializeComponent();
            CargarRoles();
            ActualizarCamposVisibles();
        }

        private void CargarRoles()
        {
            roles = RolDatos.ObtenerTodos();
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "IdRol";
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCamposVisibles();
        }

        private void ActualizarCamposVisibles()
        {
            if (cmbRol.SelectedItem == null) return;

            string rolSeleccionado = ((Rol)cmbRol.SelectedItem).NombreRol;

            gbDocente.Visible = (rolSeleccionado == "Docente");
            gbEstudiante.Visible = (rolSeleccionado == "Estudiante");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string password = txtPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(nombreUsuario) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rol rolSeleccionado = (Rol)cmbRol.SelectedItem;

            try
            {
                byte[] hash = Seguridad.GenerarHash(password);

                int idUsuario = UsuarioDatos.Insertar(nombre, apellido, correo,
                    nombreUsuario, hash, rolSeleccionado.IdRol);

                if (rolSeleccionado.NombreRol == "Docente")
                {
                    string especialidad = txtEspecialidad.Text.Trim();
                    DocenteDatos.Insertar(idUsuario, especialidad);
                }
                else if (rolSeleccionado.NombreRol == "Estudiante")
                {
                    string codigo = txtCodigo.Text.Trim();
                    string carrera = txtCarrera.Text.Trim();
                    int? semestre = null;

                    if (int.TryParse(txtSemestre.Text.Trim(), out int semestreValor))
                        semestre = semestreValor;

                    EstudianteDatos.Insertar(idUsuario, codigo, carrera, semestre);
                }

                MessageBox.Show("Usuario creado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtNombreUsuario.Clear();
            txtPassword.Clear();
            txtConfirmarPassword.Clear();
            txtEspecialidad.Clear();
            txtCodigo.Clear();
            txtCarrera.Clear();
            txtSemestre.Clear();
            cmbRol.SelectedIndex = 0;
        }
    }
}