using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MT.Vista
{
    public partial class FormEditarImportanciaAsignaturas : Form
    {
        public FormEditarImportanciaAsignaturas()
        {
            InitializeComponent();
          //  dataGridViewImportanciaAsignaturas.Columns[0].ReadOnly =true;
            dataGridViewImportanciaAsignaturas.Columns[2].ReadOnly = false;
        }

        Controlador.ControladorMetodos controlador = new Controlador.ControladorMetodos();


        private void FormEditarMalla_Load(object sender, EventArgs e)
        {
            Modelo.DatosExcel datos = new Modelo.DatosExcel();
            datos.CargarDatos_ExcelMalla();

            List<List<string>> Malla = datos.GetArchivoMalla();

            for (int i = 0; i < Malla.Count; i++)
            {
                string Asignatura=Malla[i][0];
                string ImportanciaAsignatura= Malla[i][2];

                //ColumnImportanciaAsignatura
                
                DataGridViewComboBoxCell Importancia_Box= new DataGridViewComboBoxCell();

                if (ImportanciaAsignatura.Equals("Bajo")) {
                    Importancia_Box.Items.Add("Medio");
                    Importancia_Box.Items.Add("Alto");
                }
                else if (ImportanciaAsignatura.Equals("Medio")) {
                    Importancia_Box.Items.Add("Bajo");                   
                    Importancia_Box.Items.Add("Alto");
                }
                else if (ImportanciaAsignatura.Equals("Alto")) {
                    Importancia_Box.Items.Add("Bajo");
                    Importancia_Box.Items.Add("Medio");
                }
                
                dataGridViewImportanciaAsignaturas.Rows.Add(Asignatura,ImportanciaAsignatura);
                dataGridViewImportanciaAsignaturas[2, i] = Importancia_Box;                              
            }
        }

        private void buttonGuardarEdicionMalla_Click(object sender, EventArgs e)
        {

                int cantidad_cambiadas = 0;
          
                for (int i = 0; i < dataGridViewImportanciaAsignaturas.RowCount-1; i++)
                {
                    string NuevaImportanciaAsignatura = Convert.ToString((dataGridViewImportanciaAsignaturas.Rows[i].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString());
                    if (!NuevaImportanciaAsignatura.Equals("")) {

                        try
                        {
                            string Asignatura = dataGridViewImportanciaAsignaturas.Rows[i].Cells[0].Value.ToString();

                            controlador.ActualizarImportanciaAsignatura(Asignatura, NuevaImportanciaAsignatura);
                            dataGridViewImportanciaAsignaturas.Rows[i].Cells[1].Value = NuevaImportanciaAsignatura;
                            DataGridViewComboBoxCell NuevaImportancia = new DataGridViewComboBoxCell();
                             if (NuevaImportanciaAsignatura.Equals("Bajo"))
                              {
                                  NuevaImportancia.Items.Add("Medio");
                                  NuevaImportancia.Items.Add("Alto");
                              }
                              else if (NuevaImportanciaAsignatura.Equals("Medio"))
                              {
                                  NuevaImportancia.Items.Add("Bajo");
                                  NuevaImportancia.Items.Add("Alto");
                              }
                              else if (NuevaImportanciaAsignatura.Equals("Alto"))
                              {
                                  NuevaImportancia.Items.Add("Bajo");
                                  NuevaImportancia.Items.Add("Medio");
                              }
                            dataGridViewImportanciaAsignaturas[2, i] = NuevaImportancia;

                            cantidad_cambiadas++;
                        }
                        catch (Exception ex) {

                            MessageBox.Show(ex + "");
                        }

                    }                                        
                }

                if (cantidad_cambiadas.Equals(0)) {
                    MessageBox.Show("No se ha cambiado la importancia de ninguna asignatura. Seleccione nueva importancia para guardar","Nada que Cambiar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            
        }

       


    }
}
