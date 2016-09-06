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
    public partial class FormSolicitudesAlumno : Form
    {
        public FormSolicitudesAlumno(string key)
        {
            InitializeComponent();
            cargarsolicitudes(key);
        }




        private void cargarsolicitudes(string key)
        {
            DatosExcel datosExcel = new DatosExcel();
            ControladorMetodos controlador = new ControladorMetodos();
            datosExcel.CargarDatos_ExcelSolicitud();
            List<List<string>> datosExcelSolicitudes = datosExcel.GetArchivoSolicitudes();

           for (int i = 0; i < datosExcelSolicitudes.Count; i++)
              {
                 string keyEncontrada = controlador.ObtenerKeyNumerica(datosExcelSolicitudes[i][0].ToString());

                   if (keyEncontrada.Equals(key))
                    {


                       string notaAsignatura = datosExcelSolicitudes[i][16].ToString();
                       Char[] nota_string = notaAsignatura.ToCharArray();

                       if (nota_string.Length > 0)
                       {
                           string asignatura = datosExcelSolicitudes[i][12].ToString();
                           string asignaturaInscritas = datosExcelSolicitudes[i][17].ToString();
                           string asignaturaAprobadas = datosExcelSolicitudes[i][18].ToString();
                           string promedioSemestre = datosExcelSolicitudes[i][19].ToString();
                          // MessageBox.Show(notaAsignatura + "   " + asignatura + "   " + asignaturaAprobadas + "   " + asignaturaInscritas + "   " + promedioSemestre);
                           dataGridViewSolicitudes.Rows.Add(asignatura,notaAsignatura,asignaturaInscritas,asignaturaAprobadas,promedioSemestre);
                       }
                   

                }

            }

           

        
        }
    }
}
