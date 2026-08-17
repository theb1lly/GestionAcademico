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
            this.menuEstudiantesDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaInscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCalificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuEstudiantesDocentes,
            this.menuAsignaturas,
            this.menuInscripciones,
            this.menuCalificaciones,
            this.menuReportes,
            this.menuConsultas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(96, 30);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // menuEstudiantesDocentes
            // 
            this.menuEstudiantesDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudianteToolStripMenuItem,
            this.registrarDocenteToolStripMenuItem});
            this.menuEstudiantesDocentes.Name = "menuEstudiantesDocentes";
            this.menuEstudiantesDocentes.Size = new System.Drawing.Size(199, 30);
            this.menuEstudiantesDocentes.Text = "Estudiantes/Docentes";
            // 
            // menuAsignaturas
            // 
            this.menuAsignaturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAsignaturaToolStripMenuItem});
            this.menuAsignaturas.Name = "menuAsignaturas";
            this.menuAsignaturas.Size = new System.Drawing.Size(121, 30);
            this.menuAsignaturas.Text = "Asignaturas";
            // 
            // menuInscripciones
            // 
            this.menuInscripciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaInscripciónToolStripMenuItem});
            this.menuInscripciones.Name = "menuInscripciones";
            this.menuInscripciones.Size = new System.Drawing.Size(130, 30);
            this.menuInscripciones.Text = "Inscripciones";
            // 
            // menuCalificaciones
            // 
            this.menuCalificaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCalificaciónToolStripMenuItem});
            this.menuCalificaciones.Name = "menuCalificaciones";
            this.menuCalificaciones.Size = new System.Drawing.Size(138, 30);
            this.menuCalificaciones.Text = "Calificaciones ";
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(98, 30);
            this.menuReportes.Text = "Reportes";
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
            this.menuConsultas.Size = new System.Drawing.Size(105, 30);
            this.menuConsultas.Text = "Consultas";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registrarEstudianteToolStripMenuItem.Text = "Registrar Estudiante";
            // 
            // registrarDocenteToolStripMenuItem
            // 
            this.registrarDocenteToolStripMenuItem.Name = "registrarDocenteToolStripMenuItem";
            this.registrarDocenteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registrarDocenteToolStripMenuItem.Text = "Registrar Docente";
            // 
            // crearAsignaturaToolStripMenuItem
            // 
            this.crearAsignaturaToolStripMenuItem.Name = "crearAsignaturaToolStripMenuItem";
            this.crearAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.crearAsignaturaToolStripMenuItem.Text = "Crear Asignatura";
            // 
            // nuevaInscripciónToolStripMenuItem
            // 
            this.nuevaInscripciónToolStripMenuItem.Name = "nuevaInscripciónToolStripMenuItem";
            this.nuevaInscripciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevaInscripciónToolStripMenuItem.Text = "Nueva Inscripción";
            // 
            // registrarCalificaciónToolStripMenuItem
            // 
            this.registrarCalificaciónToolStripMenuItem.Name = "registrarCalificaciónToolStripMenuItem";
            this.registrarCalificaciónToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.registrarCalificaciónToolStripMenuItem.Text = "Registrar Calificación";
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.reporteGeneralToolStripMenuItem.Text = "Reporte General";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // verEstudiantesToolStripMenuItem
            // 
            this.verEstudiantesToolStripMenuItem.Name = "verEstudiantesToolStripMenuItem";
            this.verEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verEstudiantesToolStripMenuItem.Text = "Ver Estudiantes";
            // 
            // verDocentesToolStripMenuItem
            // 
            this.verDocentesToolStripMenuItem.Name = "verDocentesToolStripMenuItem";
            this.verDocentesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verDocentesToolStripMenuItem.Text = "Ver Docentes";
            // 
            // verAsignaturasToolStripMenuItem
            // 
            this.verAsignaturasToolStripMenuItem.Name = "verAsignaturasToolStripMenuItem";
            this.verAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verAsignaturasToolStripMenuItem.Text = "Ver Asignaturas";
            // 
            // verInscripcionesToolStripMenuItem
            // 
            this.verInscripcionesToolStripMenuItem.Name = "verInscripcionesToolStripMenuItem";
            this.verInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verInscripcionesToolStripMenuItem.Text = "Ver Inscripciones";
            // 
            // verCalificacionesToolStripMenuItem
            // 
            this.verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            this.verCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 565);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Home";
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
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesDocentes;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAsignaturas;
        private System.Windows.Forms.ToolStripMenuItem crearAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInscripciones;
        private System.Windows.Forms.ToolStripMenuItem nuevaInscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCalificaciones;
        private System.Windows.Forms.ToolStripMenuItem registrarCalificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCalificacionesToolStripMenuItem;
    }
}

