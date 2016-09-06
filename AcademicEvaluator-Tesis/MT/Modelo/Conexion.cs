using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MT.Modelo
{
    class Conexion
    {
        /*public string obtener_ruta_datos() {

            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Datos MemoriaTitulo en C\ruta_datos.txt", System.Text.Encoding.Default);

            string ruta;
            ruta = sr.ReadToEnd();
            sr.Close();
            return ruta;
        }
           public string obtener_ruta_solicitudes()
        {

            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Datos MemoriaTitulo en C\ruta_solicitudes.txt", System.Text.Encoding.Default);
            string ruta;
            ruta = sr.ReadToEnd();
            sr.Close();
            return ruta;
        }

         
         
         */

        public string obtener_ruta_datos() {

           XmlDocument xDoc = new XmlDocument();
           xDoc.Load(@"C:\Datos MemoriaTitulo en C\rutas.xml");
           XmlNodeList rutas = xDoc.GetElementsByTagName("rutas");
           XmlNodeList ruta_archivo_datos =
               ((XmlElement)rutas[0]).GetElementsByTagName("ruta_archivo_datos");
           return ruta_archivo_datos[0].InnerText;
           
       }
        public string obtener_ruta_solicitudes()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Datos MemoriaTitulo en C\rutas.xml");
            XmlNodeList rutas = xDoc.GetElementsByTagName("rutas");
            XmlNodeList ruta_archivo_solicitudes =
                ((XmlElement)rutas[0]).GetElementsByTagName("ruta_archivo_solicitudes");
            return ruta_archivo_solicitudes[0].InnerText;
           
        }

    }
}
