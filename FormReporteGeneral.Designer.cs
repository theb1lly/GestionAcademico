namespace GestionAcademico
{
    partial class FormReporteGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblPromedioGeneral = new System.Windows.Forms.Label();
            this.lblTotalInscripciones = new System.Windows.Forms.Label();
            this.lblTotalAsignaturas = new System.Windows.Forms.Label();
            this.lblTotalDocentes = new System.Windows.Forms.Label();
            this.lblTotalEstudiantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.Location = new System.Drawing.Point(93, 49);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(151, 26);
            this.lblTotalUsuarios.TabIndex = 0;
            this.lblTotalUsuarios.Text = "Total de usuarios:";
            // 
            // lblPromedioGeneral
            // 
            this.lblPromedioGeneral.AutoSize = true;
            this.lblPromedioGeneral.Location = new System.Drawing.Point(93, 275);
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(137, 20);
            this.lblPromedioGeneral.TabIndex = 1;
            this.lblPromedioGeneral.Text = "Promedio general:";
            // 
            // lblTotalInscripciones
            // 
            this.lblTotalInscripciones.AutoSize = true;
            this.lblTotalInscripciones.Location = new System.Drawing.Point(93, 230);
            this.lblTotalInscripciones.Name = "lblTotalInscripciones";
            this.lblTotalInscripciones.Size = new System.Drawing.Size(165, 20);
            this.lblTotalInscripciones.TabIndex = 2;
            this.lblTotalInscripciones.Text = "Total de inscripciones:";
            // 
            // lblTotalAsignaturas
            // 
            this.lblTotalAsignaturas.AutoSize = true;
            this.lblTotalAsignaturas.Location = new System.Drawing.Point(93, 181);
            this.lblTotalAsignaturas.Name = "lblTotalAsignaturas";
            this.lblTotalAsignaturas.Size = new System.Drawing.Size(157, 20);
            this.lblTotalAsignaturas.TabIndex = 3;
            this.lblTotalAsignaturas.Text = "Total de asignaturas:";
            // 
            // lblTotalDocentes
            // 
            this.lblTotalDocentes.AutoSize = true;
            this.lblTotalDocentes.Location = new System.Drawing.Point(93, 138);
            this.lblTotalDocentes.Name = "lblTotalDocentes";
            this.lblTotalDocentes.Size = new System.Drawing.Size(140, 20);
            this.lblTotalDocentes.TabIndex = 4;
            this.lblTotalDocentes.Text = "Total de docentes:";
            // 
            // lblTotalEstudiantes
            // 
            this.lblTotalEstudiantes.Location = new System.Drawing.Point(93, 94);
            this.lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            this.lblTotalEstudiantes.Size = new System.Drawing.Size(165, 23);
            this.lblTotalEstudiantes.TabIndex = 5;
            this.lblTotalEstudiantes.Text = "Total de estudiantes:";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 348);
            this.Controls.Add(this.lblTotalEstudiantes);
            this.Controls.Add(this.lblTotalDocentes);
            this.Controls.Add(this.lblTotalAsignaturas);
            this.Controls.Add(this.lblTotalInscripciones);
            this.Controls.Add(this.lblPromedioGeneral);
            this.Controls.Add(this.lblTotalUsuarios);
            this.Name = "FormReportes";
            this.Text = "Reporte General";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblPromedioGeneral;
        private System.Windows.Forms.Label lblTotalInscripciones;
        private System.Windows.Forms.Label lblTotalAsignaturas;
        private System.Windows.Forms.Label lblTotalDocentes;
        private System.Windows.Forms.Label lblTotalEstudiantes;
    }
}