namespace GestionAcademico
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuAsignaturas,
            this.menuInscripciones,
            this.menuCalificaciones,
            this.menuReportes,
            this.menuConsultas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(96, 29);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuAsignaturas
            // 
            this.menuAsignaturas.Name = "menuAsignaturas";
            this.menuAsignaturas.Size = new System.Drawing.Size(121, 29);
            this.menuAsignaturas.Text = "Asignaturas";
            this.menuAsignaturas.Click += new System.EventHandler(this.menuAsignaturas_Click);
            // 
            // menuInscripciones
            // 
            this.menuInscripciones.Name = "menuInscripciones";
            this.menuInscripciones.Size = new System.Drawing.Size(130, 29);
            this.menuInscripciones.Text = "Inscripciones";
            this.menuInscripciones.Click += new System.EventHandler(this.menuInscripciones_Click);
            // 
            // menuCalificaciones
            // 
            this.menuCalificaciones.Name = "menuCalificaciones";
            this.menuCalificaciones.Size = new System.Drawing.Size(138, 29);
            this.menuCalificaciones.Text = "Calificaciones ";
            this.menuCalificaciones.Click += new System.EventHandler(this.menuCalificaciones_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(98, 29);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.verEstudiantesToolStripMenuItem,
            this.verDocentesToolStripMenuItem,
            this.verAsignaturasToolStripMenuItem,
            this.verInscripcionesToolStripMenuItem,
            this.verCalificacionesToolStripMenuItem});
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(105, 29);
            this.menuConsultas.Text = "Consultas";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // verEstudiantesToolStripMenuItem
            // 
            this.verEstudiantesToolStripMenuItem.Name = "verEstudiantesToolStripMenuItem";
            this.verEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verEstudiantesToolStripMenuItem.Text = "Ver Estudiantes";
            this.verEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.verEstudiantesToolStripMenuItem_Click);
            // 
            // verDocentesToolStripMenuItem
            // 
            this.verDocentesToolStripMenuItem.Name = "verDocentesToolStripMenuItem";
            this.verDocentesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verDocentesToolStripMenuItem.Text = "Ver Docentes";
            this.verDocentesToolStripMenuItem.Click += new System.EventHandler(this.verDocentesToolStripMenuItem_Click);
            // 
            // verAsignaturasToolStripMenuItem
            // 
            this.verAsignaturasToolStripMenuItem.Name = "verAsignaturasToolStripMenuItem";
            this.verAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verAsignaturasToolStripMenuItem.Text = "Ver Asignaturas";
            this.verAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.verAsignaturasToolStripMenuItem_Click);
            // 
            // verInscripcionesToolStripMenuItem
            // 
            this.verInscripcionesToolStripMenuItem.Name = "verInscripcionesToolStripMenuItem";
            this.verInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verInscripcionesToolStripMenuItem.Text = "Ver Inscripciones";
            this.verInscripcionesToolStripMenuItem.Click += new System.EventHandler(this.verInscripcionesToolStripMenuItem_Click);
            // 
            // verCalificacionesToolStripMenuItem
            // 
            this.verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            this.verCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            this.verCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.verCalificacionesToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::GestionAcademico.Properties.Resources.eb25f8ff82ea6bc28be922ec025d4f70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 600);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAsignaturas;
        private System.Windows.Forms.ToolStripMenuItem menuInscripciones;
        private System.Windows.Forms.ToolStripMenuItem menuCalificaciones;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
    }
}

