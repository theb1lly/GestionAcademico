using System;
using System.Windows.Forms;
using GestionAcademico.Datos;
using GestionAcademico.Modelos;
using GestionAcademico.Utilidades;

namespace GestionAcademico
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            byte[] hash = Seguridad.GenerarHash(password);

            Usuario usuario = UsuarioDatos.ValidarLogin(nombreUsuario, hash);

            if (usuario != null && usuario.Estado)
            {
                MessageBox.Show("Datos correctos. Bienvenido.");

                HomeForm home = new HomeForm(usuario);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos.");
            }
        }
    }
}