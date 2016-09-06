using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MT.Modelo;
using System.Data.OleDb;
using System.Data;
using System.Xml;

namespace MT.Modelo
{
    class Alumno
    {
        string RutAlumno;
        string RutaArchivoDato;
        string RutaArchivoSolicitudes;
        public DatosExcel datosExcel = new DatosExcel();

        public Alumno(string key) {
            RutAlumno= key;
        }

        public double promedioAlumno()
        {

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT AVG(NOTA) FROM [Sheet 1$] WHERE KEY='" + RutAlumno+ "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            double resultado_double = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            // string resultado = Convert.ToString(Math.Round(resultado_double, 2));
            con.Close();
            return resultado_double;

        }

        public double efectividadAprobacion()
        {

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT COUNT(*) FROM [Sheet 1$] WHERE KEY='" + RutAlumno + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            double cantidad_total_asignaturas = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            //string resultado = Convert.ToString(Math.Round(resultado_double, 2));           

            string strSQL_aprobados = "SELECT COUNT(*) FROM [Sheet 1$] WHERE KEY='" + RutAlumno + "' AND ESTADO_NOTA='APROBADO'";
            OleDbDataAdapter da_aprobados = new OleDbDataAdapter(strSQL_aprobados, con);
            DataSet ds_aprobados = new DataSet();
            da_aprobados.Fill(ds_aprobados);
            double cantidad_asignaturas_aprobadas = Convert.ToDouble(ds_aprobados.Tables[0].Rows[0].ItemArray[0]);

            double efectividad = (cantidad_asignaturas_aprobadas * 100) / cantidad_total_asignaturas;
            con.Close();
            return efectividad;


        }


        public double EfectividadSolicitudesAlumno()
        {

            RutaArchivoSolicitudes = FormPrincipal.RutaArchivoSolicitudes;

            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoSolicitudes + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT COUNT(*) FROM [Hoja1$] WHERE ID='" + RutAlumno + "' AND NOTA_ASIGNATURA IS NOT NULL";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            double cantidad_total_solicitudes = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            //string resultado = Convert.ToString(Math.Round(resultado_double, 2));          

            string strSQL_aprobados = "SELECT COUNT(*) FROM [Hoja1$] WHERE ID='" + RutAlumno + "' AND NOTA_ASIGNATURA>=4 ";
            OleDbDataAdapter da_aprobados = new OleDbDataAdapter(strSQL_aprobados, con);
            DataSet ds_aprobados = new DataSet();
            da_aprobados.Fill(ds_aprobados);
            double cantidad_solicitudes_aprobadas = Convert.ToDouble(ds_aprobados.Tables[0].Rows[0].ItemArray[0]);

            double efectividad_solicitudes = (cantidad_solicitudes_aprobadas * 100) / cantidad_total_solicitudes;
            con.Close();

            return efectividad_solicitudes;

        }



        internal List<string> ListaLlenarAsignaturas()
        {
            /*
            List<List<string>> listaDatos = datosExcel.GetArchivoAlumno();
            List<string> listaAsignaturas = new List<string>();

            for (int i = 1; i < listaDatos.Count; i++)
            {

                string asignatura = listaDatos[i][3].ToString();
                if (!listaAsignaturas.Contains(asignatura))
                {
                    listaAsignaturas.Add(asignatura);
                }

            }*/

            List<List<string>> listaMalla = datosExcel.GetArchivoMalla();
            List<string> listaAsignaturas = new List<string>();

            for (int i = 0; i < listaMalla.Count; i++)
            {

                string asignatura = listaMalla[i][0].ToString();

                listaAsignaturas.Add(asignatura);

            }
            return listaAsignaturas;
        }

        internal List<string> ListaLlenarAsignaturasAprobadas()
        {

            List<string> ListaAprobadas = new List<string>();

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT NOMBRE FROM [Sheet 1$] WHERE KEY='" + RutAlumno + "' AND ESTADO_NOTA='APROBADO' ";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int cantidad_asignaturas_aprobadas = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            //  MessageBox.Show(cantidad_asignaturas_aprobadas + "");

            for (int i = 0; i < cantidad_asignaturas_aprobadas; i++)
            {
                ListaAprobadas.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            return ListaAprobadas;

        }

        internal int ConsultaNivelAlumno(List<string> ListaAsignaturasAprobadas, List<string> ListaAsignaturasTotales)
        {


            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
             @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT NIVEL FROM [Hoja1$] ";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cantidad_asignaturas = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            int nivel_alumno = 11;
            int nivel_asignatura;

            try
            {
                for (int i = 0; i < cantidad_asignaturas; i++)
                {
                    //MessageBox.Show(ListaAsignaturasTotales[i] + " " + ds.Tables[0].Rows[i].ItemArray[0]);
                    if (!ListaAsignaturasAprobadas.Contains(ListaAsignaturasTotales[i]))
                    {
                        nivel_asignatura = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                        if (nivel_asignatura < nivel_alumno)
                        {
                            nivel_alumno = nivel_asignatura;
                        }
                    }

                }
                //double resultado_double = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
                // string resultado = Convert.ToString(Math.Round(resultado_double, 2));
                con.Close();
                return nivel_alumno;
            }
            catch
            {
                return nivel_alumno;
            }
        }

        internal int ConsultarOportunidadQueAlumnoCursaAsignatura(string asignatura)
        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT ESTADO_NOTA FROM [Sheet 1$] WHERE NOMBRE='" + asignatura + "' AND KEY ='" + RutAlumno + "' AND ESTADO_NOTA = 'REPROBADO'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int oportunidad = ds.Tables[0].Rows.Count;
            return oportunidad;



        }

    }
}
