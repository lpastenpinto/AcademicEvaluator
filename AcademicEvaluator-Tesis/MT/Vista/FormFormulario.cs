using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MT.Modelo;
using MT.Controlador;

namespace MT.Vista
{

    public partial class FormFormulario : Form
    {

        public static int cantidad_hijos;
        public static string estado_civil;
        public static string ciudad_procedencia;
        public static bool verifica_trabaja;
        public static int horas_trabajo;
        public static string jornada_trabajo;
        public static string financiamiento_estudios;

        public FormFormulario( string key)
        {
            InitializeComponent();
            BuscarDatosAlumno(key);       
        }


        private void BuscarDatosAlumno(string key)
        {
            
            DatosExcel datosExcel = new DatosExcel();
            ControladorMetodos controlador = new ControladorMetodos();
            datosExcel.CargarDatos_ExcelSolicitud();
            List<List<string>> datosExcelSolicitud = datosExcel.GetArchivoSolicitudes();
            

            for (int i = 0; i < datosExcelSolicitud.Count; i++)
            {
                string keyEncontrada = controlador.ObtenerKeyNumerica(datosExcelSolicitud[i][0].ToString());
                
                
                if (keyEncontrada.Equals(key))
                {

                    textBoxAñoIngreso.Text = datosExcelSolicitud[i][2].ToString();
                    textBoxKey.Text = datosExcelSolicitud[i][0].ToString();
                    textBoxDireccionPro.Text = datosExcelSolicitud[i][5].ToString();
                    textBoxVillaPoblacion.Text = datosExcelSolicitud[i][6].ToString();
                    textBoxCiudadProcedencia.Text = datosExcelSolicitud[i][7].ToString();
                    textBoxDependencia.Text = datosExcelSolicitud[i][9].ToString();
                    textBoxTipoColegioPro.Text = datosExcelSolicitud[i][8].ToString();

                }
               

            }
        }


        private void checkBoxTrabaja_CheckedChanged(object sender, EventArgs e)
        {
            panelTrabaja.Visible = true;
            checkBoxNoTrabaja.Checked = false;
        }

        private void checkBoxNoTrabaja_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTrabaja.Checked = false;
            panelTrabaja.Visible = false;
        }

       

        private void checkBoxHombre_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMujer.Checked = false;
        }

        private void checkBoxMujer_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxHombre.Checked = false;
        }

        private void buttonGuardarFormulario_Click(object sender, EventArgs e)
        {
            ciudad_procedencia = textBoxCiudadProcedencia.Text;
            estado_civil = comboBox_EstadoCivil.Text;
            cantidad_hijos = Convert.ToInt32(maskedTextBoxCantidadHijos.Text);
            if (checkBoxTrabaja.Checked)
            {
                try
                {
                    verifica_trabaja = true;
                    jornada_trabajo = comboBoxJornadas.Text;
                    horas_trabajo = Convert.ToInt32(maskedTextBoxCantidadHorasTrabaja.Text);

                    if ((horas_trabajo <= 0) || horas_trabajo.Equals(null))
                    {
                        MessageBox.Show("Indique cuantas horas trabaja a la semana");

                    }
                    else
                    {
                        MessageBox.Show(ciudad_procedencia + estado_civil + cantidad_hijos + jornada_trabajo + horas_trabajo);
                        this.Close();
                    }
                }
                catch (Exception ) {
                    MessageBox.Show("Ingrese todos los datos solicitados correctamente");
                }
            }
            else if (checkBoxNoTrabaja.Checked)
            {
                verifica_trabaja = false;
                this.Close();
            }
            else {

                MessageBox.Show("Complete todos los checkbox");
            }
            
            


        }

       

      


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBoxNombreAlumno.Enabled = true;
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBoxDireccionPro.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBoxVillaPoblacion.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           textBoxCiudadProcedencia.Enabled = true;
        }



       


        private void checkBoxAlumnoPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFinanciamiento.Checked = false;
            checkBoxFinanciamientoBeca.Checked = false;
            checkBoxFinanciamientoCredito.Checked = false;
            checkBoxFinanciamientoOtros.Checked = false;

            if (checkBoxAlumnoPorcentaje.Checked)
            {

                maskedTextBoxPorcentaje.Visible = true;
                labelPorcentaje.Visible = true;


            }

            if (!checkBoxAlumnoPorcentaje.Checked)
            {

                maskedTextBoxPorcentaje.Visible = false;
                labelPorcentaje.Visible = false;

            }
        }

        private void checkBoxFinanciamiento_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFinanciamientoBeca.Checked = false;
            checkBoxFinanciamientoCredito.Checked = false;
            checkBoxFinanciamientoOtros.Checked = false;
            checkBoxAlumnoPorcentaje.Checked = false;
        }

        private void checkBoxFinanciamientoBeca_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFinanciamientoOtros.Checked = false;
            checkBoxFinanciamientoCredito.Checked = false;
            checkBoxAlumnoPorcentaje.Checked = false;
            checkBoxFinanciamiento.Checked = false;

        }

        private void checkBoxFinanciamientoCredito_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFinanciamientoOtros.Checked = false;
            checkBoxAlumnoPorcentaje.Checked = false;
            checkBoxFinanciamiento.Checked = false;
            checkBoxFinanciamientoBeca.Checked = false;
        }

        private void checkBoxFinanciamientoOtros_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFinanciamientoBeca.Checked = false;
            checkBoxFinanciamientoCredito.Checked = false;
            checkBoxAlumnoPorcentaje.Checked = false;
            checkBoxFinanciamiento.Checked = false;
        }

     
    }
}
