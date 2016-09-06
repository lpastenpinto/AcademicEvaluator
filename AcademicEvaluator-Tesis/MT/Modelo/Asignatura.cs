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
    class Asignatura
    {   
        string NombreAsignatura;       
        string RutaArchivoDato;
        string RutaArchivoSolicitudes;

        public Asignatura(string nombre) {
            NombreAsignatura = nombre;
        }


        public string ConsultaPromedioAsignatura()
        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT AVG(NOTA) FROM [Sheet 1$] WHERE NOMBRE='" + NombreAsignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            double resultado_double = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            string resultado = Convert.ToString(Math.Round(resultado_double, 2));
            con.Close();
            return resultado;
        }

        public double ConsultaPorcentajeAprobacionAsignatura()
        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT ESTADO_NOTA FROM [Sheet 1$] WHERE NOMBRE='" + NombreAsignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int cantidad_total_asignatura = ds.Tables[0].Rows.Count;
            int cantidad_asignatura_aprobado = 0;


            for (int i = 0; i < cantidad_total_asignatura; i++)
            {

                string aprobado = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[0]);

                if (aprobado.Equals("APROBADO"))
                {
                    cantidad_asignatura_aprobado++;

                }
            }
            con.Close();

            return Math.Round((double)cantidad_asignatura_aprobado / cantidad_total_asignatura, 2);

        }

        internal int ConsultaNivelAsignatura()
        {

            try
            {
                string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
                OleDbConnection con = new OleDbConnection(CadenaConexion);

                string strSQL = "SELECT NIVEL FROM [Hoja1$] WHERE ASIGNATURA='" + NombreAsignatura + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int nivel = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
                con.Close();
                return nivel;
            }
            catch { return 0; }



        }

        internal int ConsultarCreditosAsignatura()
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
           @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT CREDITOS FROM [Hoja1$] WHERE ASIGNATURA='" + NombreAsignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int nivel = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            con.Close();
            return nivel;

        }

        internal string ConsultarImportancia()
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT IMPORTANCIA FROM [Hoja1$] WHERE ASIGNATURA='" + NombreAsignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string importancia = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            return importancia;


        }

        internal string ConsultarPrerrequisito()
        {
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT PRERREQUISITOS FROM [Hoja1$] WHERE ASIGNATURA='" + NombreAsignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string prerrequisito = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            con.Close();
            return prerrequisito;
        }

        internal void ActualizarImportanciaAsignatura(string NuevaImportanciaAsignatura)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "UPDATE [Hoja1$] SET IMPORTANCIA = '" + NuevaImportanciaAsignatura + "' WHERE ASIGNATURA = '" + NombreAsignatura + "'";
                OleDbCommand updateCommand = new OleDbCommand(strSQL, con);
                con.Open();
                updateCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
            }

        }

    }
}
