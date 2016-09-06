namespace MT
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelSolicitudes = new System.Windows.Forms.LinkLabel();
            this.buttonReglas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efectividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efectividadSolicitudes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxRut = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxMalo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBueno = new System.Windows.Forms.PictureBox();
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAsignaturas = new System.Windows.Forms.ComboBox();
            this.dataGridViewAsignaturas = new System.Windows.Forms.DataGridView();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelAsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oportunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prerre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevoArchivoHistoricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMallaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarRutaArchivoDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarRutaArchivoMallaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBueno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelSolicitudes);
            this.groupBox1.Controls.Add(this.buttonReglas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewAlumnos);
            this.groupBox1.Controls.Add(this.maskedTextBoxRut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConsultar);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno - Academicos:";
            // 
            // linkLabelSolicitudes
            // 
            this.linkLabelSolicitudes.AutoSize = true;
            this.linkLabelSolicitudes.Location = new System.Drawing.Point(298, 136);
            this.linkLabelSolicitudes.Name = "linkLabelSolicitudes";
            this.linkLabelSolicitudes.Size = new System.Drawing.Size(115, 13);
            this.linkLabelSolicitudes.TabIndex = 5;
            this.linkLabelSolicitudes.TabStop = true;
            this.linkLabelSolicitudes.Text = "Ver Solicitudes Alumno";
            this.linkLabelSolicitudes.Visible = false;
            this.linkLabelSolicitudes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonReglas
            // 
            this.buttonReglas.Location = new System.Drawing.Point(696, 129);
            this.buttonReglas.Name = "buttonReglas";
            this.buttonReglas.Size = new System.Drawing.Size(122, 23);
            this.buttonReglas.TabIndex = 4;
            this.buttonReglas.Text = "Reglas";
            this.buttonReglas.UseVisualStyleBackColor = true;
            this.buttonReglas.Click += new System.EventHandler(this.buttonReglas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 7);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Sin Digito Verificador)";
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.promedio,
            this.Nivel,
            this.Efectividad,
            this.efectividadSolicitudes});
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(6, 73);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersVisible = false;
            this.dataGridViewAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(407, 60);
            this.dataGridViewAlumnos.TabIndex = 3;
            // 
            // promedio
            // 
            this.promedio.HeaderText = "Promedio";
            this.promedio.Name = "promedio";
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            // 
            // Efectividad
            // 
            this.Efectividad.HeaderText = "Efectividad Aprobación";
            this.Efectividad.Name = "Efectividad";
            // 
            // efectividadSolicitudes
            // 
            this.efectividadSolicitudes.HeaderText = "Efectividad Solicitudes";
            this.efectividadSolicitudes.Name = "efectividadSolicitudes";
            // 
            // maskedTextBoxRut
            // 
            this.maskedTextBoxRut.Location = new System.Drawing.Point(78, 31);
            this.maskedTextBoxRut.Mask = "##.###.###";
            this.maskedTextBoxRut.Name = "maskedTextBoxRut";
            this.maskedTextBoxRut.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxRut.TabIndex = 2;
            this.maskedTextBoxRut.Text = "16351604";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut Alumno:";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultar.Location = new System.Drawing.Point(178, 24);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(74, 32);
            this.buttonConsultar.TabIndex = 0;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBoxMalo);
            this.groupBox2.Controls.Add(this.pictureBoxBueno);
            this.groupBox2.Controls.Add(this.textBoxCreditos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxAsignaturas);
            this.groupBox2.Controls.Add(this.dataGridViewAsignaturas);
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 382);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox3.Location = new System.Drawing.Point(12, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 11);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asignatura sin Prerrequisito cumplido.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox2.Location = new System.Drawing.Point(12, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 11);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asignatura con problemas de Nivel";
            // 
            // pictureBoxMalo
            // 
            this.pictureBoxMalo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMalo.Image")));
            this.pictureBoxMalo.Location = new System.Drawing.Point(584, 28);
            this.pictureBoxMalo.Name = "pictureBoxMalo";
            this.pictureBoxMalo.Size = new System.Drawing.Size(17, 19);
            this.pictureBoxMalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMalo.TabIndex = 5;
            this.pictureBoxMalo.TabStop = false;
            this.pictureBoxMalo.Visible = false;
            // 
            // pictureBoxBueno
            // 
            this.pictureBoxBueno.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBueno.Image")));
            this.pictureBoxBueno.Location = new System.Drawing.Point(584, 28);
            this.pictureBoxBueno.Name = "pictureBoxBueno";
            this.pictureBoxBueno.Size = new System.Drawing.Size(17, 19);
            this.pictureBoxBueno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBueno.TabIndex = 4;
            this.pictureBoxBueno.TabStop = false;
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Enabled = false;
            this.textBoxCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreditos.Location = new System.Drawing.Point(550, 25);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.Size = new System.Drawing.Size(28, 24);
            this.textBoxCreditos.TabIndex = 3;
            this.textBoxCreditos.Text = "0";
            this.textBoxCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creditos Totales a Inscribir:";
            // 
            // comboBoxAsignaturas
            // 
            this.comboBoxAsignaturas.FormattingEnabled = true;
            this.comboBoxAsignaturas.Location = new System.Drawing.Point(10, 28);
            this.comboBoxAsignaturas.Name = "comboBoxAsignaturas";
            this.comboBoxAsignaturas.Size = new System.Drawing.Size(392, 21);
            this.comboBoxAsignaturas.TabIndex = 1;
            this.comboBoxAsignaturas.Text = "Asignaturas";
            this.comboBoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAsignaturas_SelectedIndexChanged);
            // 
            // dataGridViewAsignaturas
            // 
            this.dataGridViewAsignaturas.AllowUserToAddRows = false;
            this.dataGridViewAsignaturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignatura,
            this.PromedioAsignatura,
            this.Porcentaje,
            this.Importancia,
            this.NivelAsi,
            this.Creditos,
            this.Oportunidad,
            this.Prerre,
            this.Eliminar});
            this.dataGridViewAsignaturas.Location = new System.Drawing.Point(6, 70);
            this.dataGridViewAsignaturas.Name = "dataGridViewAsignaturas";
            this.dataGridViewAsignaturas.RowHeadersVisible = false;
            this.dataGridViewAsignaturas.Size = new System.Drawing.Size(1099, 241);
            this.dataGridViewAsignaturas.TabIndex = 0;
            this.dataGridViewAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsignaturas_CellContentClick);
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Width = 300;
            // 
            // PromedioAsignatura
            // 
            this.PromedioAsignatura.HeaderText = "Promedio General Asignatura";
            this.PromedioAsignatura.Name = "PromedioAsignatura";
            this.PromedioAsignatura.Width = 90;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje Aprobación";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 90;
            // 
            // Importancia
            // 
            this.Importancia.HeaderText = "Importancia Perfil";
            this.Importancia.Name = "Importancia";
            this.Importancia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importancia.Width = 90;
            // 
            // NivelAsi
            // 
            this.NivelAsi.HeaderText = "Nivel";
            this.NivelAsi.Name = "NivelAsi";
            this.NivelAsi.Width = 70;
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.Name = "Creditos";
            this.Creditos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Creditos.Width = 70;
            // 
            // Oportunidad
            // 
            this.Oportunidad.HeaderText = "Oportunidad";
            this.Oportunidad.Name = "Oportunidad";
            this.Oportunidad.Width = 70;
            // 
            // Prerre
            // 
            this.Prerre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prerre.HeaderText = "Prerrequisito";
            this.Prerre.Name = "Prerre";
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarNuevoArchivoHistoricosToolStripMenuItem,
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarNuevoArchivoHistoricosToolStripMenuItem
            // 
            this.cargarNuevoArchivoHistoricosToolStripMenuItem.Name = "cargarNuevoArchivoHistoricosToolStripMenuItem";
            this.cargarNuevoArchivoHistoricosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cargarNuevoArchivoHistoricosToolStripMenuItem.Text = "Cargar Nuevo Archivo Historicos";
            this.cargarNuevoArchivoHistoricosToolStripMenuItem.Click += new System.EventHandler(this.cargarNuevoArchivoHistoricosToolStripMenuItem_Click);
            // 
            // cargarNuevoArchivoSolicitudesToolStripMenuItem
            // 
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem.Name = "cargarNuevoArchivoSolicitudesToolStripMenuItem";
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem.Text = "Cargar Nuevo Archivo Solicitudes";
            this.cargarNuevoArchivoSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.cargarNuevoArchivoSolicitudesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMallaCarreraToolStripMenuItem,
            this.editarRutaToolStripMenuItem});
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // editarMallaCarreraToolStripMenuItem
            // 
            this.editarMallaCarreraToolStripMenuItem.Name = "editarMallaCarreraToolStripMenuItem";
            this.editarMallaCarreraToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.editarMallaCarreraToolStripMenuItem.Text = "Editar Importancia Asignaturas";
            this.editarMallaCarreraToolStripMenuItem.Click += new System.EventHandler(this.editarMallaCarreraToolStripMenuItem_Click);
            // 
            // editarRutaToolStripMenuItem
            // 
            this.editarRutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarRutaArchivoDatosToolStripMenuItem1,
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1,
            this.cambiarRutaArchivoMallaToolStripMenuItem1});
            this.editarRutaToolStripMenuItem.Name = "editarRutaToolStripMenuItem";
            this.editarRutaToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.editarRutaToolStripMenuItem.Text = "Editar Rutas de Archivos";
            // 
            // cambiarRutaArchivoDatosToolStripMenuItem1
            // 
            this.cambiarRutaArchivoDatosToolStripMenuItem1.Name = "cambiarRutaArchivoDatosToolStripMenuItem1";
            this.cambiarRutaArchivoDatosToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.cambiarRutaArchivoDatosToolStripMenuItem1.Text = "Cambiar Ruta Archivo Datos";
            this.cambiarRutaArchivoDatosToolStripMenuItem1.Click += new System.EventHandler(this.cambiarRutaArchivoDatosToolStripMenuItem1_Click);
            // 
            // cambiarRutaArchivoSolicitudesToolStripMenuItem1
            // 
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1.Name = "cambiarRutaArchivoSolicitudesToolStripMenuItem1";
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1.Text = "Cambiar Ruta Archivo Solicitudes";
            this.cambiarRutaArchivoSolicitudesToolStripMenuItem1.Click += new System.EventHandler(this.cambiarRutaArchivoSolicitudesToolStripMenuItem1_Click);
            // 
            // cambiarRutaArchivoMallaToolStripMenuItem1
            // 
            this.cambiarRutaArchivoMallaToolStripMenuItem1.Name = "cambiarRutaArchivoMallaToolStripMenuItem1";
            this.cambiarRutaArchivoMallaToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.cambiarRutaArchivoMallaToolStripMenuItem1.Text = "Cambiar Ruta Archivo Malla";
            this.cambiarRutaArchivoMallaToolStripMenuItem1.Click += new System.EventHandler(this.cambiarRutaArchivoMallaToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónAlumnoToolStripMenuItem});
            this.verToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verToolStripMenuItem.Image")));
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // informaciónAlumnoToolStripMenuItem
            // 
            this.informaciónAlumnoToolStripMenuItem.Name = "informaciónAlumnoToolStripMenuItem";
            this.informaciónAlumnoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.informaciónAlumnoToolStripMenuItem.Text = "Información alumno";
            this.informaciónAlumnoToolStripMenuItem.Click += new System.EventHandler(this.informaciónAlumnoToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(917, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(892, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBueno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAsignaturas;
        private System.Windows.Forms.DataGridView dataGridViewAsignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efectividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectividadSolicitudes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMallaCarreraToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCreditos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónAlumnoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReglas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel linkLabelSolicitudes;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem editarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarRutaArchivoDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarRutaArchivoSolicitudesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarRutaArchivoMallaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBoxMalo;
        private System.Windows.Forms.PictureBox pictureBoxBueno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevoArchivoHistoricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevoArchivoSolicitudesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelAsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oportunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prerre;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

