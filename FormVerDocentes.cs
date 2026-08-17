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
    public partial class FormVerDocentes : Form
    {
        public FormVerDocentes()
        {
            InitializeComponent();
            dgvDatos.DataSource = DocenteDatos.ObtenerTodos();
        }
    }
}
