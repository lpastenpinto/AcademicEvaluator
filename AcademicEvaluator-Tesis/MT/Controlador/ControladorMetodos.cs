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

namespace MT.Controlador
{
    class ControladorMetodos
    {


        public DatosExcel datosExcel = new DatosExcel();
        string RutaArchivoDato;
        string RutaArchivoSolicitudes;
        public double promedioAlumno(string keyAlumno)
        {

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT AVG(NOTA) FROM [Sheet 1$] WHERE KEY='" + keyAlumno + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            double resultado_double = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
           // string resultado = Convert.ToString(Math.Round(resultado_double, 2));
            con.Close();           
            return resultado_double; 
           
        }

        
        public double efectividadAprobacion(string key)
        {

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT COUNT(*) FROM [Sheet 1$] WHERE KEY='" + key + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            double cantidad_total_asignaturas = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            //string resultado = Convert.ToString(Math.Round(resultado_double, 2));           
            
            string strSQL_aprobados = "SELECT COUNT(*) FROM [Sheet 1$] WHERE KEY='" + key + "' AND ESTADO_NOTA='APROBADO'";
            OleDbDataAdapter da_aprobados = new OleDbDataAdapter(strSQL_aprobados, con);
            DataSet ds_aprobados = new DataSet();
            da_aprobados.Fill(ds_aprobados);
            double cantidad_asignaturas_aprobadas = Convert.ToDouble(ds_aprobados.Tables[0].Rows[0].ItemArray[0]);             

            double efectividad = (cantidad_asignaturas_aprobadas * 100) / cantidad_total_asignaturas;
            con.Close();
            return efectividad;
        

        }


        //Convierte el Key en un Rut
        public String keyRut(string p)
        {

            //MessageBox.Show("El Key que trae  :"+ p);
            String buffer = p;
            String buff = "";
            String[] split = Regex.Split(buffer, "[a-zA-Z]");

            try
            {
                for (int i = 0; i < split.Length; i++)
                {
                    String cadena = split[i];

                    // MessageBox.Show(split[i]);

                    int num = Convert.ToInt16(cadena);

                    if (num == 624)
                    {
                        buff = buff + "0";
                        continue;
                    }
                    if (num == 2906)
                    {
                        buff = buff + "1";
                        continue;
                    }
                    if (num == 538)
                    {
                        buff = buff + "2";
                        continue;
                    }
                    if (num == 368)
                    {
                        buff = buff + "3";
                        continue;
                    }
                    if (num == 529)
                    {
                        buff = buff + "4";
                        continue;
                    }
                    if (num == 1802)
                    {
                        buff = buff + "5";
                        continue;
                    }
                    if (num == 1962)
                    {
                        buff = buff + "6";
                        continue;
                    }
                    if (num == 2653)
                    {
                        buff = buff + "7";
                        continue;
                    }
                    if (num == 1794)
                    {
                        buff = buff + "8";
                        continue;
                    }
                    if (num == 1175)
                        buff = buff + "9";

                }
            }
            catch { }

            int M = 0;
            int S = 1;
            for (int T = Convert.ToInt32(buff); T != 0; T /= 10)
                S = (S + (T % 10) * (9 - M++ % 6)) % 11;

            return (Convert.ToString((new StringBuilder()).Append(buff).Append("-").Append((char)(S == 0 ? 75 : S + 47))));
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




        internal List<string> ListaLlenarAsignaturasAprobadas(string key)
        {
            
            List<string> ListaAprobadas = new List<string>();           

            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT NOMBRE FROM [Sheet 1$] WHERE KEY='" + key + "' AND ESTADO_NOTA='APROBADO' ";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int cantidad_asignaturas_aprobadas=Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
          //  MessageBox.Show(cantidad_asignaturas_aprobadas + "");

            for (int i = 0; i < cantidad_asignaturas_aprobadas; i++)
            {   
                ListaAprobadas.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            return ListaAprobadas;
           
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


        internal string TransformarRutaKey(string rutAlumno)
        {
            Char[] rut = rutAlumno.ToCharArray();
            string keyNumerica = "";
            for (int i = 0; i < rut.Length; i++)
            {

                if (rut[i].ToString().Equals("0")) { keyNumerica = keyNumerica + "624"; }
                else if (rut[i].ToString().Equals("1")) { keyNumerica = keyNumerica + "2906"; }
                else if (rut[i].ToString().Equals("2")) { keyNumerica = keyNumerica + "538"; }
                else if (rut[i].ToString().Equals("3")) { keyNumerica = keyNumerica + "368"; }
                else if (rut[i].ToString().Equals("4")) { keyNumerica = keyNumerica + "529"; }
                else if (rut[i].ToString().Equals("5")) { keyNumerica = keyNumerica + "1802"; }
                else if (rut[i].ToString().Equals("6")) { keyNumerica = keyNumerica + "1962"; }
                else if (rut[i].ToString().Equals("7")) { keyNumerica = keyNumerica + "2653"; }
                else if (rut[i].ToString().Equals("8")) { keyNumerica = keyNumerica + "1794"; }
                else if (rut[i].ToString().Equals("9")) { keyNumerica = keyNumerica + "1175"; }


            }
            return keyNumerica;
        }


        public string ConsultaPromedioAsignatura(string asignatura)
        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"'; 
            
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT AVG(NOTA) FROM [Sheet 1$] WHERE NOMBRE='" + asignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            double resultado_double = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            string resultado = Convert.ToString(Math.Round(resultado_double, 2));
            con.Close();
            return resultado;
        }




        public double ConsultaPorcentajeAprobacionAsignatura(string asignatura)
        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT ESTADO_NOTA FROM [Sheet 1$] WHERE NOMBRE='" + asignatura + "'";
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


        public double EfectividadSolicitudesAlumno(string key)
        {
        
            RutaArchivoSolicitudes = FormPrincipal.RutaArchivoSolicitudes;
           
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoSolicitudes + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';

            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT COUNT(*) FROM [Hoja1$] WHERE ID='" + key + "' AND NOTA_ASIGNATURA IS NOT NULL"; 
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            double cantidad_total_solicitudes = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0]);
            //string resultado = Convert.ToString(Math.Round(resultado_double, 2));          

            string strSQL_aprobados = "SELECT COUNT(*) FROM [Hoja1$] WHERE ID='" + key + "' AND NOTA_ASIGNATURA>=4 ";
            OleDbDataAdapter da_aprobados = new OleDbDataAdapter(strSQL_aprobados, con);
            DataSet ds_aprobados = new DataSet();
            da_aprobados.Fill(ds_aprobados);
            double cantidad_solicitudes_aprobadas = Convert.ToDouble(ds_aprobados.Tables[0].Rows[0].ItemArray[0]);

            double efectividad_solicitudes = (cantidad_solicitudes_aprobadas * 100) / cantidad_total_solicitudes;
            con.Close();
   
            return efectividad_solicitudes;                                 

        }




        internal int ConsultaNivelAsignatura(string asignatura)
        {

            try
            {
                string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
                OleDbConnection con = new OleDbConnection(CadenaConexion);

                string strSQL = "SELECT NIVEL FROM [Hoja1$] WHERE ASIGNATURA='" + asignatura + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int nivel = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
                con.Close();
                return nivel;
            }
            catch { return 0; }



        }



        internal int ConsultaNivelAlumno(List<string> ListaAsignaturasAprobadas, List<string> ListaAsignaturasTotales) {

        
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
            catch {
                return nivel_alumno;
            }
        }


        

        internal int ConsultarCreditosAsignatura(string asignatura)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
           @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT CREDITOS FROM [Hoja1$] WHERE ASIGNATURA='" + asignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int nivel = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            con.Close();
            return nivel;

        }





        internal string ConsultarImportancia(string asignatura)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT IMPORTANCIA FROM [Hoja1$] WHERE ASIGNATURA='" + asignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string importancia = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            return importancia;


        }





        internal bool alumnoexiste(string rut)
        {   
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "SELECT KEY FROM [Sheet 1$] WHERE KEY='"+rut+"'";
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string key = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                if (!key.Equals(null)){
                    return true;
                }
                
                return false;
            }
            catch 
            {

                return false;
            }

        }

        internal void ActualizarImportanciaAsignatura(string Asignatura, string ImportanciaAsignatura) {
           
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            try
            {
                string strSQL = "UPDATE [Hoja1$] SET IMPORTANCIA = '" + ImportanciaAsignatura + "' WHERE ASIGNATURA = '" + Asignatura + "'";
                OleDbCommand updateCommand = new OleDbCommand(strSQL, con);
                con.Open();
                updateCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception ex) {

                MessageBox.Show(ex+"");
            }            
        
        }




        internal bool VerificarEstructuraArchivoDatos(string ruta)
        {

            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source="+ruta+";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=NO" + '"';
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
            catch {

                return false;
            }
        }



        internal bool CambiarRutaArchivoDatos(string RutaArchivo) {
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
            catch (Exception ex) {

                MessageBox.Show(ex+"");
                return false;
            }
        }



        internal bool VerificarEstructuraArchivoSolicitudes(string ruta)
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



        internal bool CambiarRutaArchivoSolicitudes(string RutaArchivoSolicitudes)
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




        internal void CambiarKeysExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oXL;
                Microsoft.Office.Interop.Excel._Workbook oWB;
                Microsoft.Office.Interop.Excel._Worksheet excelWorkSheet;
                Microsoft.Office.Interop.Excel.Range range;
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = false;
                oWB = oXL.Workbooks.Open("C:/Datos MemoriaTitulo en C/datos.xls");
                excelWorkSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
                //Cambia los Valores
                range = excelWorkSheet.UsedRange;
                for (int i = 2; i < 7053; i++)
                {
                    String valor = Convert.ToString(range.Cells[i, 6].Value);
                   
                    string keyNumerica = ObtenerKeyNumerica(valor);
                  
                    excelWorkSheet.Cells[i, 6] = keyNumerica;
                }


                oWB.Save();
                oWB.Close(null, null, null);
                oXL.Workbooks.Close();
                oXL.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oWB);
                excelWorkSheet = null;
                oWB = null;
                oXL = null;
                GC.Collect();
                MessageBox.Show("Termine");
            }
            catch(Exception ex) {
                MessageBox.Show(ex+"");
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



        internal int ConsultarOportunidad(string asignatura, string rut)

        {
            RutaArchivoDato = FormPrincipal.RutaArchivoDatos;
            string CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + RutaArchivoDato + ";" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT ESTADO_NOTA FROM [Sheet 1$] WHERE NOMBRE='" + asignatura + "' AND KEY ='" + rut + "' AND ESTADO_NOTA = 'REPROBADO'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int oportunidad = ds.Tables[0].Rows.Count;
            return oportunidad;

             
            
        }

        internal string ConsultarPrerrequisito(string asignatura)
        {
            string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @"Data Source=C:\Datos MemoriaTitulo en C\Malla2534.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"';
            OleDbConnection con = new OleDbConnection(CadenaConexion);

            string strSQL = "SELECT PRERREQUISITOS FROM [Hoja1$] WHERE ASIGNATURA='" + asignatura + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string prerrequisito = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            
            con.Close();
            return prerrequisito;
        }
    }

}
