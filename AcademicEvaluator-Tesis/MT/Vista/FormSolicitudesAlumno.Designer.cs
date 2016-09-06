namespace MT.Vista
{
    partial class FormSolicitudesAlumno
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
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignaturasNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignaturasAprobadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignatura,
            this.Nota,
            this.AsignaturasNumero,
            this.AsignaturasAprobadas,
            this.Promedio});
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(727, 256);
            this.dataGridViewSolicitudes.TabIndex = 0;
            // 
            // Asignatura
            // 
            this.Asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota Asignatura";
            this.Nota.Name = "Nota";
            // 
            // AsignaturasNumero
            // 
            this.AsignaturasNumero.HeaderText = "Numero Asignaturas Inscritas";
            this.AsignaturasNumero.Name = "AsignaturasNumero";
            // 
            // AsignaturasAprobadas
            // 
            this.AsignaturasAprobadas.HeaderText = "Asignaturas Aprobadas";
            this.AsignaturasAprobadas.Name = "AsignaturasAprobadas";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio Semestre";
            this.Promedio.Name = "Promedio";
            // 
            // FormSolicitudesAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 436);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Name = "FormSolicitudesAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignaturasNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignaturasAprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}