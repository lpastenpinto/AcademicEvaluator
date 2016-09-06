namespace MT.Vista
{
    partial class FormEditarImportanciaAsignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarImportanciaAsignaturas));
            this.dataGridViewImportanciaAsignaturas = new System.Windows.Forms.DataGridView();
            this.ColumnNombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImportanciaActualAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNuevaImportanciaAsignatura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonGuardarEdicionMalla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportanciaAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImportanciaAsignaturas
            // 
            this.dataGridViewImportanciaAsignaturas.AllowUserToOrderColumns = true;
            this.dataGridViewImportanciaAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportanciaAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombreAsignatura,
            this.ColumnImportanciaActualAsignatura,
            this.ColumnNuevaImportanciaAsignatura});
            this.dataGridViewImportanciaAsignaturas.Location = new System.Drawing.Point(52, 73);
            this.dataGridViewImportanciaAsignaturas.Name = "dataGridViewImportanciaAsignaturas";
            this.dataGridViewImportanciaAsignaturas.RowHeadersVisible = false;
            this.dataGridViewImportanciaAsignaturas.Size = new System.Drawing.Size(775, 357);
            this.dataGridViewImportanciaAsignaturas.TabIndex = 1;
            // 
            // ColumnNombreAsignatura
            // 
            this.ColumnNombreAsignatura.HeaderText = "Asignatura";
            this.ColumnNombreAsignatura.Name = "ColumnNombreAsignatura";
            this.ColumnNombreAsignatura.ReadOnly = true;
            this.ColumnNombreAsignatura.Width = 400;
            // 
            // ColumnImportanciaActualAsignatura
            // 
            this.ColumnImportanciaActualAsignatura.HeaderText = "Importancia Actual Asignatura";
            this.ColumnImportanciaActualAsignatura.Name = "ColumnImportanciaActualAsignatura";
            this.ColumnImportanciaActualAsignatura.ReadOnly = true;
            this.ColumnImportanciaActualAsignatura.Width = 180;
            // 
            // ColumnNuevaImportanciaAsignatura
            // 
            this.ColumnNuevaImportanciaAsignatura.HeaderText = "Cambiar a...";
            this.ColumnNuevaImportanciaAsignatura.Name = "ColumnNuevaImportanciaAsignatura";
            this.ColumnNuevaImportanciaAsignatura.ReadOnly = true;
            this.ColumnNuevaImportanciaAsignatura.Width = 190;
            // 
            // buttonGuardarEdicionMalla
            // 
            this.buttonGuardarEdicionMalla.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarEdicionMalla.Image")));
            this.buttonGuardarEdicionMalla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarEdicionMalla.Location = new System.Drawing.Point(743, 453);
            this.buttonGuardarEdicionMalla.Name = "buttonGuardarEdicionMalla";
            this.buttonGuardarEdicionMalla.Size = new System.Drawing.Size(84, 33);
            this.buttonGuardarEdicionMalla.TabIndex = 2;
            this.buttonGuardarEdicionMalla.Text = "Guardar";
            this.buttonGuardarEdicionMalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarEdicionMalla.UseVisualStyleBackColor = true;
            this.buttonGuardarEdicionMalla.Click += new System.EventHandler(this.buttonGuardarEdicionMalla_Click);
            // 
            // FormEditarImportanciaAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 498);
            this.Controls.Add(this.buttonGuardarEdicionMalla);
            this.Controls.Add(this.dataGridViewImportanciaAsignaturas);
            this.Name = "FormEditarImportanciaAsignaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Importancia de Asignaturas";
            this.Load += new System.EventHandler(this.FormEditarMalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportanciaAsignaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewImportanciaAsignaturas;
        private System.Windows.Forms.Button buttonGuardarEdicionMalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImportanciaActualAsignatura;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnNuevaImportanciaAsignatura;
    }
}