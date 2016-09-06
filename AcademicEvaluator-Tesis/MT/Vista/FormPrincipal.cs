using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MT.Vista;

namespace MT
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent(); 
            RutaArchivoDatos=conexion.obtener_ruta_datos();
            RutaArchivoSolicitudes = conexion.obtener_ruta_solicitudes();
                        
            //controlador.datosExcel.CargarDatos_ExcelDatos();
            //controlador.datosExcel.CargarDatos_ExcelSolicitud();  //////
            controlador.datosExcel.CargarDatos_ExcelMalla();
        }


        Controlador.ControladorMetodos controlador = new Controlador.ControladorMetodos();
        Modelo.Conexion conexion = new Modelo.Conexion();
        string rut=null;
        int nivel_alumno;
        public static string RutaArchivoDatos;
        public static string RutaArchivoSolicitudes;




        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(FormFormulario.cantidad_hijos+"");
         
                    /*Modelo.DatosExcel datos = new Modelo.DatosExcel();
                    datos.CargarDatos_ExcelMalla();

                    List<List<string>> ArchivoAlumnos = datos.GetArchivoMalla();
                    if (ArchivoAlumnos.Count == 0)
                    {
                        MessageBox.Show("La Lista de los Alumnos esta Vacia");
                    }
                    else { ImprimirExcel(ArchivoAlumnos); }

                    //List<List<string>> ArchivoSolicitudes = datos.GetArchivoSolicitudes();
                    //if (ArchivoSolicitudes.Count == 0)
                    //{
                    //    MessageBox.Show("La Lista de los Alumnos esta Vacia");
                    //}

                    //else { ImprimirExcel(ArchivoSolicitudes); }
            */
        }



        //Imprime la Lista que retorna el DatosExcel.
        private void ImprimirExcel(List<List<string>> listaArchivo)
        {
            for (int i = 0; i < listaArchivo.Count; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < listaArchivo[i].Count; j++)
                {
                    MessageBox.Show(listaArchivo[i][j]);
                    Console.Write(" " + listaArchivo[i][j]);
                }
            }
        }




        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            
            BorrarDatos();
            String key = controlador.TransformarRutaKey(maskedTextBoxRut.Text.Replace(",", ""));
            rut = key;           

            bool alumnoExiste =controlador.alumnoexiste(rut);
            
            //Vista.FormFormulario formulario = new Vista.FormFormulario(key);
            //formulario.Show();

            if (alumnoExiste)
            {
                
                //Vista.FormFormulario formulario = new Vista.FormFormulario(key);
                //formulario.ShowDialog();

                ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Mostrar_Form); // va el nombre del metodo que recibe un object
                Thread hilo = new Thread(parameterizedThreadStart);
                hilo.Start(key);


                double promedioAlumno = controlador.promedioAlumno(key);
                double efectividadAprobacion = controlador.efectividadAprobacion(key);
                double efectividadSolicitudes = controlador.EfectividadSolicitudesAlumno(key);
                

                if (efectividadSolicitudes > 0) { linkLabelSolicitudes.Visible = true; }
                List<string> Lista = controlador.ListaLlenarAsignaturas();

               
                List<string> ListaAsignaturasAprobadas = controlador.ListaLlenarAsignaturasAprobadas(key);
                nivel_alumno = controlador.ConsultaNivelAlumno(ListaAsignaturasAprobadas, Lista);
                llenarComboBoxAsignatura(Lista, ListaAsignaturasAprobadas);
                dataGridViewAlumnos.Rows.Add(Math.Round(promedioAlumno, 2), nivel_alumno, Math.Round(efectividadAprobacion,2), efectividadSolicitudes);
                dataGridViewAlumnos.ClearSelection();
            }
            else {
                MessageBox.Show("Alumno no existe");
            }
             
           
        }


        private void BorrarDatos()
        {
            linkLabelSolicitudes.Visible = false;
            dataGridViewAlumnos.Rows.Clear();
            dataGridViewAsignaturas.Rows.Clear();
            comboBoxAsignaturas.Items.Clear();
            textBoxCreditos.Text = "0";
        }



        void Mostrar_Form(object Obj)
        {
            String llave = (String)Obj;
            Vista.FormFormulario formulario = new Vista.FormFormulario(llave);
            formulario.ShowDialog();
        }





        private void llenarComboBoxAsignatura(List<string> Lista, List<string> ListaAprobadas)
        {

            for (int i = 0; i < ListaAprobadas.Count; i++ ) {

                Lista.Remove(ListaAprobadas[i].ToString());
            }

            
            for (int i = 0; i<Lista.Count; i++) {
                
                    //int nivel_asignatura = controlador.ConsultaNivelAsignatura(Lista[i].ToString());

                        comboBoxAsignaturas.Items.Add(Lista[i].ToString());
                    
            }
        }




        private void comboBoxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asignatura = comboBoxAsignaturas.Text;

            if (!asignatura.Equals("ELECTIVO DE FORMACIÓN PROFESIONAL")) {
                comboBoxAsignaturas.Items.Remove(asignatura);     
            }

            string promedio = controlador.ConsultaPromedioAsignatura(asignatura);
            double porcentaje_aprobacion = controlador.ConsultaPorcentajeAprobacionAsignatura(asignatura);
            int nivel_asignatura = controlador.ConsultaNivelAsignatura(asignatura);
           
            int creditos_asignatura = controlador.ConsultarCreditosAsignatura(asignatura);
            string importancia_asignatura = controlador.ConsultarImportancia(asignatura);
            int oportunidad_asignatura = controlador.ConsultarOportunidad(asignatura,rut)+1;
            string prerrequisito = controlador.ConsultarPrerrequisito(asignatura);

            List<string> ListaAsignaturasAprobadas = controlador.ListaLlenarAsignaturasAprobadas(rut);

            if (!ListaAsignaturasAprobadas.Contains(prerrequisito))
            {

                dataGridViewAsignaturas.Rows.Add(asignatura, promedio, porcentaje_aprobacion, importancia_asignatura, nivel_asignatura, creditos_asignatura, oportunidad_asignatura, prerrequisito);
                dataGridViewAsignaturas.Rows[dataGridViewAsignaturas.RowCount - 1].DefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewAsignaturas.ClearSelection();
            }
            else
            {
                if ((nivel_asignatura - nivel_alumno) > 2)
                {
                    dataGridViewAsignaturas.Rows.Add(asignatura, promedio, porcentaje_aprobacion, importancia_asignatura, nivel_asignatura, creditos_asignatura, oportunidad_asignatura, prerrequisito);
                    dataGridViewAsignaturas.Rows[dataGridViewAsignaturas.RowCount - 1].DefaultCellStyle.BackColor = Color.DarkKhaki;
                    dataGridViewAsignaturas.ClearSelection();
                }
                else
                {
                    dataGridViewAsignaturas.Rows.Add(asignatura, promedio, porcentaje_aprobacion, importancia_asignatura, nivel_asignatura, creditos_asignatura, oportunidad_asignatura, prerrequisito);
                    dataGridViewAsignaturas.ClearSelection();
                }
            }
            textBoxCreditos.Text= ContarCreditos().ToString();
        }



        private int ContarCreditos()
        {

            int creditos=0;

            for (int i = 0; i < dataGridViewAsignaturas.RowCount; i++)
            {
                creditos = creditos + Convert.ToInt16(dataGridViewAsignaturas.Rows[i].Cells[5].Value);
            }
            if (creditos > 32)
            {
                pictureBoxBueno.Visible = false;
                pictureBoxMalo.Visible = true;
            }
            else {
                pictureBoxBueno.Visible = true;
                pictureBoxMalo.Visible = false;
            
            }
            return creditos;
        }




        private void dataGridViewAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string asignatura = dataGridViewAsignaturas.Rows[dataGridViewAsignaturas.CurrentRow.Index].Cells[0].Value.ToString();
                if (this.dataGridViewAsignaturas.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                {
                    dataGridViewAsignaturas.Rows.RemoveAt(dataGridViewAsignaturas.CurrentRow.Index);
                    textBoxCreditos.Text = ContarCreditos().ToString();
                    comboBoxAsignaturas.Items.Add(asignatura);
                }
            }
            catch { }
        }




        private void informaciónAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.FormFormulario formulario = new Vista.FormFormulario(rut);
            formulario.ShowDialog(); 
        }

        private void editarMallaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.FormEditarImportanciaAsignaturas formulario = new Vista.FormEditarImportanciaAsignaturas();
            formulario.ShowDialog();
        }

       

       

        private void buttonReglas_Click(object sender, EventArgs e)
        {
             Controlador.ParserReglas ParserReglas = new Controlador.ParserReglas();
             List<string> ListaAntecedentes_ReglaEjemplo = new List<string>();
             ListaAntecedentes_ReglaEjemplo.Add("BAJO");
             ListaAntecedentes_ReglaEjemplo.Add("MEDIO");
             string consecuente = ParserReglas.ObtenerConsecuenteReglaRiesgoTotal(ListaAntecedentes_ReglaEjemplo);
             MessageBox.Show("THEN="+consecuente);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String key = controlador.TransformarRutaKey(maskedTextBoxRut.Text.Replace(",", ""));
            FormSolicitudesAlumno solicitudes = new FormSolicitudesAlumno(key);
            solicitudes.ShowDialog();
        }






        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void cambiarRutaArchivoDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Excel Worksheets|*.xls";

            openFileDialog.FileName = "Seleccione un archivo ";

            openFileDialog.Title = "Cambie ruta de archivos de Datos de historicos";

            openFileDialog.InitialDirectory = "C:/";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                bool verificar = controlador.VerificarEstructuraArchivoDatos(ruta);
                if (verificar.Equals(false))
                {
                    MessageBox.Show("Estructura de archivo incorrecto. Intentelo de nuevo");
                }
                else
                {
                    RutaArchivoDatos = ruta;
                    controlador.CambiarRutaArchivoDatos(RutaArchivoDatos);
                    MessageBox.Show("Ruta cambiada correctamente");
                }

            }


        }

        private void cambiarRutaArchivoSolicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Worksheets|*.xls";

            openFileDialog.FileName = "Seleccione un archivo ";

            openFileDialog.Title = "Cambie ruta de archivos de Solicitudes";

            openFileDialog.InitialDirectory = "C:/";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                bool verificar = controlador.VerificarEstructuraArchivoSolicitudes(ruta);
                if (verificar.Equals(false))
                {
                    MessageBox.Show("Estructura de archivo incorrecto. Intentelo de nuevo");
                }
                else
                {
                    RutaArchivoSolicitudes = ruta;
                    controlador.CambiarRutaArchivoSolicitudes(RutaArchivoSolicitudes);
                    MessageBox.Show("Ruta cambiada correctamente");
                }

            }
        }

        private void cambiarRutaArchivoMallaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cargarNuevoArchivoHistoricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Worksheets|*.xls";

            openFileDialog.FileName = "Seleccione un archivo ";

            openFileDialog.Title = "Cambie ruta de archivos de Datos de historicos";

            openFileDialog.InitialDirectory = "C:/";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                bool verificar = controlador.VerificarEstructuraArchivoDatos(ruta);
                if (verificar.Equals(false))
                {   
                    MessageBox.Show("Estructura de archivo incorrecto. Intentelo de nuevo");
                }
                else
                {
                    DateTime tiempo1 = DateTime.Now;
                    //controlador.CambiarKeysExcel();
                    controlador.CambiarKeyNumericaExcelHistoricos(ruta);

                    DateTime tiempo2 = DateTime.Now;
                    
                    TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
                    MessageBox.Show(total.ToString());
                 
                }

            }
        }

        private void cargarNuevoArchivoSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Worksheets|*.xls";

            openFileDialog.FileName = "Seleccione un archivo ";

            openFileDialog.Title = "Cambie ruta de archivos de Datos de historicos";

            openFileDialog.InitialDirectory = "C:/";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                bool verificar = controlador.VerificarEstructuraArchivoSolicitudes(ruta);
                if (verificar.Equals(false))
                {
                    MessageBox.Show("Estructura de archivo incorrecto. Intentelo de nuevo");
                }
                else
                {
                    DateTime tiempo1 = DateTime.Now;
                    //controlador.CambiarKeysExcel();
                    controlador.CambiarKeyNumericaExcelSolicitudes(ruta);

                    DateTime tiempo2 = DateTime.Now;

                    TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
                    MessageBox.Show(total.ToString());

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controlador.ParserReglas ParserReglas = new Controlador.ParserReglas();
            List<List<string>> Lista = new List<List<string>>();
            List<string> ListaAntecedentes_ReglaEjemplo = new List<string>();
            ListaAntecedentes_ReglaEjemplo.Add("BAJO");
            ListaAntecedentes_ReglaEjemplo.Add("BAJO");
            ListaAntecedentes_ReglaEjemplo.Add("BAJO");
            ListaAntecedentes_ReglaEjemplo.Add("BAJO");
            Lista.Add(ListaAntecedentes_ReglaEjemplo);
            
            ParserReglas.ObtenerConsecuenteReglaRiesgoAsignaturasTotales(Lista);
           
        }

      

    }
}
