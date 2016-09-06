using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;
using MT.Modelo;


namespace MT.Modelo
{
    class DatosExcel
    {

        List<List<string>> archivoExcelAlumno = new List<List<string>>();
        List<List<string>> archivoExcelSolicitudes = new List<List<string>>();
        List<List<string>> archivoExcelMalla = new List<List<string>>();
        string RutaArchivoDatos;
        string RutaArchivoSolicitudes;

        internal void CargarDatos_ExcelDatos() {

                List<string> fila = new List<string>();
                //string loQueSea = fromPrincipal.LaVariable;
                RutaArchivoDatos = FormPrincipal.RutaArchivoDatos;
                string CadenaConexion=@"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=" + RutaArchivoDatos + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"'; 
            
                OleDbConnection con=new OleDbConnection(CadenaConexion); 

                //Usuario y dirección son columnas en la hoja de excel 
                string strSQL="SELECT * FROM [Sheet 1$]"; 

                OleDbDataAdapter da=new OleDbDataAdapter(strSQL,con); 
            
                DataSet ds=new DataSet(); 

                da.Fill(ds);

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    fila = new List<string>();                  
                    //fila.Add(Convert.ToString(ds.Tables[0].Rows[i]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[0]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]));
                  //  fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]));
                    fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[11]));

                    //MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1] + " -- " + ds.Tables[0].Rows[i].ItemArray[2] + " -- " + ds.Tables[0].Rows[i].ItemArray[3] + " -- " + ds.Tables[0].Rows[i].ItemArray[4] + " -- " + ds.Tables[0].Rows[i].ItemArray[5] + " -- " + ds.Tables[0].Rows[i].ItemArray[6] + " -- " + ds.Tables[0].Rows[i].ItemArray[7] + " -- " + ds.Tables[0].Rows[i].ItemArray[8] + " -- " + ds.Tables[0].Rows[i].ItemArray[9] + " -- " + ds.Tables[0].Rows[i].ItemArray[10] + " -- " + ds.Tables[0].Rows[i].ItemArray[11]);                    
                    archivoExcelAlumno.Add(fila);
                }                
        }


        internal void CargarDatos_ExcelSolicitud()
        {
            RutaArchivoSolicitudes = FormPrincipal.RutaArchivoSolicitudes;
            List<string> fila = new List<string>();
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoSolicitudes + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            //Usuario y dirección son columnas en la hoja de excel 
            string strSQL = "SELECT * FROM [Hoja1$]";

            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);

            DataSet ds = new DataSet();

            da.Fill(ds);

            for (int i = 1; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                fila = new List<string>();

                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[0]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[11]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[12]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[13]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[14]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[15]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[16]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[17]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[18]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[19]));
               
                archivoExcelSolicitudes.Add(fila);
            }

        }


        internal void CargarDatos_ExcelMalla()
        {

            List<string> fila = new List<string>();
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);            

            //Usuario y dirección son columnas en la hoja de excel 
            string strSQL = "SELECT * FROM [Hoja1$]";

            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);

            DataSet ds = new DataSet();

            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                fila = new List<string>();
                //fila.Add(Convert.ToString(ds.Tables[0].Rows[i]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[0]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]));
                fila.Add(Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]));               
                //MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1] + " -- " + ds.Tables[0].Rows[i].ItemArray[2] + " -- " + ds.Tables[0].Rows[i].ItemArray[3] + " -- " + ds.Tables[0].Rows[i].ItemArray[4] + " -- " + ds.Tables[0].Rows[i].ItemArray[5] + " -- " + ds.Tables[0].Rows[i].ItemArray[6] + " -- " + ds.Tables[0].Rows[i].ItemArray[7] + " -- " + ds.Tables[0].Rows[i].ItemArray[8] + " -- " + ds.Tables[0].Rows[i].ItemArray[9] + " -- " + ds.Tables[0].Rows[i].ItemArray[10] + " -- " + ds.Tables[0].Rows[i].ItemArray[11]);                    
                archivoExcelMalla.Add(fila);
            }
            con.Close();
        }

       
        public List<List<string>> GetArchivoAlumno() {
            return archivoExcelAlumno; 
        }

      
        public List<List<string>> GetArchivoSolicitudes()
        {
            return archivoExcelSolicitudes;
        }


        public List<List<string>> GetArchivoMalla()
        {
            return archivoExcelMalla;
        }


        internal bool VerificarEstructuraArchivoHistoricosAsignaturas(string ruta)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=" + ruta + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=NO" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "SELECT TOP 1 * FROM [Sheet 1$] ";
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string key = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                //  MessageBox.Show(key);
                string carrera = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                // MessageBox.Show(carrera);
                string resolucion = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                // MessageBox.Show(resolucion);
                string estado_nota = ds.Tables[0].Rows[0].ItemArray[11].ToString();
                // MessageBox.Show(estado_nota);

                if (key.Equals("AÑO") && carrera.Equals("SEMESTRE") && resolucion.Equals("RESOLUCIÓN") && estado_nota.Equals("ESTADO_NOTA"))
                {
                    return true;
                }
                return false;
            }
            catch
            {

                return false;
            }
        }



        internal bool CambiarRutaArchivoHistoricoAsignaturas(string RutaArchivo)
        {
            //string lines = "First line.\r\nSecond line.\r\nThird line.";  
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"C:\Datos MemoriaTitulo en C\rutas.xml");
                XmlNodeList rutas = xDoc.GetElementsByTagName("rutas");
                XmlNodeList ruta_archivo_datos =
                    ((XmlElement)rutas[0]).GetElementsByTagName("ruta_archivo_datos");
                ruta_archivo_datos[0].InnerText = RutaArchivo;
                xDoc.Save(@"C:\Datos MemoriaTitulo en C\rutas.xml");
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
                return false;
            }
        }



        internal bool VerificarEstructuraArchivoHistoricoSolicitudes(string ruta)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=" + ruta + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=NO" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "SELECT TOP 1 * FROM [Hoja1$] ";
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string id = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                //MessageBox.Show(id);
                string carrera = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                //MessageBox.Show(carrera);
                string estado_asignatura = ds.Tables[0].Rows[0].ItemArray[14].ToString();
                // MessageBox.Show(estado_asignatura);
                string estado_alumno = ds.Tables[0].Rows[0].ItemArray[15].ToString();
                // MessageBox.Show(estado_alumno);

                if (id.Equals("ID") && carrera.Equals("CARRERA") && estado_asignatura.Equals("ESTADO ASIGNATURA") && estado_alumno.Equals("ESTADO ALUMNO"))
                {
                    return true;
                }
                return false;
            }
            catch
            {

                return false;
            }
        }



        internal bool CambiarRutaArchivoHistoricoSolicitudes(string RutaArchivoSolicitudes)
        {
            //string lines = "First line.\r\nSecond line.\r\nThird line.";  
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"C:\Datos MemoriaTitulo en C\rutas.xml");
                XmlNodeList rutas = xDoc.GetElementsByTagName("rutas");
                XmlNodeList ruta_archivo_datos =
                    ((XmlElement)rutas[0]).GetElementsByTagName("ruta_archivo_solicitudes");
                ruta_archivo_datos[0].InnerText = RutaArchivoSolicitudes;
                xDoc.Save(@"C:\Datos MemoriaTitulo en C\rutas.xml");
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
                return false;
            }
        }


        internal void CambiarKeyNumericaExcelHistoricos(string Nueva_Ruta)
        {
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=" + Nueva_Ruta + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "SELECT KEY FROM [Sheet 1$]";

                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int cantidad_keys = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
                con.Open();

                for (int i = 0; i < cantidad_keys; i++)
                {

                    string key = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string nueva_key = ObtenerKeyNumerica(key);

                    //cmd.CommandText = "update employees set name = 'Jonathan' where name = 'John'";
                    //string sr = " update [Sheet 1$] set [KEY] = '2906I1802A624A368F1802B529I529I1962B' where SEMESTRE = '1'";
                    string strSQL_Update = "UPDATE [Sheet 1$] SET [KEY] = '" + nueva_key + "' WHERE [KEY]= '" + key + "'";

                    OleDbCommand updateCommand = new OleDbCommand(strSQL_Update, con);
                    updateCommand.ExecuteNonQuery();

                }

                con.Close();

                MessageBox.Show("Cargado Correctamente Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        internal void CambiarKeyNumericaExcelSolicitudes(string Nueva_Ruta)
        {
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=" + Nueva_Ruta + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "SELECT ID FROM [Hoja1$]";

                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int cantidad_keys = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
                con.Open();

                for (int i = 0; i < cantidad_keys; i++)
                {

                    string key = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string nueva_key = ObtenerKeyNumerica(key);

                    //cmd.CommandText = "update employees set name = 'Jonathan' where name = 'John'";
                    //string sr = " update [Sheet 1$] set [KEY] = '2906I1802A624A368F1802B529I529I1962B' where SEMESTRE = '1'";
                    string strSQL_Update = "UPDATE [Hoja1$] SET [ID] = '" + nueva_key + "' WHERE [ID]= '" + key + "'";

                    OleDbCommand updateCommand = new OleDbCommand(strSQL_Update, con);
                    updateCommand.ExecuteNonQuery();

                }

                con.Close();

                MessageBox.Show("Cargado Correctamente Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        internal string ObtenerKeyNumerica(string llave)
        {
            // Solo Digitos
            string pattern = @"\d";
            StringBuilder sb = new StringBuilder();
            foreach (Match m in Regex.Matches(llave, pattern))
            {
                sb.Append(m);
            }
            return sb.ToString();
        }

    }
}
