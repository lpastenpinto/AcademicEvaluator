using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace MT.Controlador
{
    class ParserReglas
    {

        XmlDocument xDoc = new XmlDocument();

        public ParserReglas() {
            xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");
        }

        internal string ObtenerConsecuenteReglaRiesgoTotal(List<string> ListaAntecedentes) {

            string riesgo_asignaturas_totales;
            string riesgo_academico_alumno;            
            string riesgo_generales_universidad;
            string riesgo_entorno_alumno;

           // XmlDocument xDoc = new XmlDocument();


           // xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");

            XmlNodeList lista_reglas = xDoc.GetElementsByTagName("reglas");

            XmlNodeList regla =
                ((XmlElement)lista_reglas[0]).GetElementsByTagName("regla_riesgo_total");

            int numero_regla = 0;

            riesgo_asignaturas_totales = ListaAntecedentes[0].ToString();
            riesgo_academico_alumno = ListaAntecedentes[1].ToString();
            riesgo_generales_universidad = ListaAntecedentes[2].ToString();
            riesgo_entorno_alumno = ListaAntecedentes[3].ToString();
                
           
            foreach (XmlElement nodo in regla)
            {

                int i = 0;
                //riesgoalumno = "BAJO";
                //riesgoasignatura = "MEDIO";
                XmlNodeList antecedente1 =
                nodo.GetElementsByTagName("riesgo_asignaturas_totales");

                XmlNodeList antecedente2 =
                nodo.GetElementsByTagName("riesgo_academico_alumno");

                XmlNodeList antecedente3 =
                nodo.GetElementsByTagName("riesgo_generales_universidad");

                XmlNodeList antecedente4 =
                nodo.GetElementsByTagName("riesgo_entorno_alumno");

                XmlNodeList consecuente =
                nodo.GetElementsByTagName("then");
                numero_regla++;
                if (riesgo_asignaturas_totales.Equals(antecedente1[i].InnerText) && riesgo_academico_alumno.Equals(antecedente2[i].InnerText) && riesgo_generales_universidad.Equals(antecedente3[i].InnerText) && riesgo_entorno_alumno.Equals(antecedente4[i].InnerText))
                {
                    //MessageBox.Show(consecuente[i++].InnerText);
                    return (consecuente[i++].InnerText);
                    //break;
                }

            }
           // MessageBox.Show("" + numero_regla);
            return "";
        }

        internal string ObtenerConsecuenteReglaRiesgoAsignatura(List<string> ListaAntecedentes)
        {

            string promedio_general_asignatura;
            string porcentaje_aprobacion_asignatura;
            string importancia_asignatura;
            string oportunidad_toma_asignatura;

          //  XmlDocument xDoc = new XmlDocument();

         
         //   xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");

            XmlNodeList lista_reglas = xDoc.GetElementsByTagName("reglas");

            XmlNodeList regla =
                ((XmlElement)lista_reglas[0]).GetElementsByTagName("regla_riesgo_asignatura");

            int numero_regla = 0;

            promedio_general_asignatura = ListaAntecedentes[0].ToString();
            porcentaje_aprobacion_asignatura = ListaAntecedentes[1].ToString();
            importancia_asignatura = ListaAntecedentes[2].ToString();
            oportunidad_toma_asignatura = ListaAntecedentes[3].ToString();   

            foreach (XmlElement nodo in regla)
            {

                int i = 0;
                //riesgoalumno = "BAJO";
                //riesgoasignatura = "MEDIO";
                XmlNodeList antecedente1 =
                nodo.GetElementsByTagName("promedio_general_asignatura");

                XmlNodeList antecedente2 =
                nodo.GetElementsByTagName("porcentaje_aprobacion_asignatura");

                XmlNodeList antecedente3 =
                nodo.GetElementsByTagName("importancia_asignatura");


                XmlNodeList antecedente4 =
                nodo.GetElementsByTagName("oportunidad_toma_asignatura");

                XmlNodeList consecuente =
                nodo.GetElementsByTagName("then");
                numero_regla++;

                if (promedio_general_asignatura.Equals(antecedente1[i].InnerText) && porcentaje_aprobacion_asignatura.Equals(antecedente2[i].InnerText) && importancia_asignatura.Equals(antecedente3[i].InnerText) && oportunidad_toma_asignatura.Equals(antecedente4[i].InnerText))
                {
                    //MessageBox.Show(consecuente[i++].InnerText);
                    return (consecuente[i++].InnerText);
                    //break;
                }

            }
            // MessageBox.Show("" + numero_regla);
            return "";
        }
        internal void ObtenerConsecuenteReglaRiesgoAsignaturasTotales(List<List<string>> ListaAntecedentesAsignaturas)
        {
            int cantidad_asignaturas = ListaAntecedentesAsignaturas.Count;
            List<string> ListaRiesgoAsignatura= new List<string>();

            for (int i = 0; i < cantidad_asignaturas; i++){                 
                List<string> Antecedentes=new List<string>();
                Antecedentes.Add(ListaAntecedentesAsignaturas[i][0]);
                Antecedentes.Add(ListaAntecedentesAsignaturas[i][1]);
                Antecedentes.Add(ListaAntecedentesAsignaturas[i][2]);
                Antecedentes.Add(ListaAntecedentesAsignaturas[i][3]);
                MessageBox.Show(ListaAntecedentesAsignaturas[i][0]+"  "+ ListaAntecedentesAsignaturas[i][1]+"  "+ListaAntecedentesAsignaturas[i][2]+"  "+ListaAntecedentesAsignaturas[i][3]);
                ListaRiesgoAsignatura.Add(ObtenerConsecuenteReglaRiesgoAsignatura(Antecedentes));
                MessageBox.Show(ObtenerConsecuenteReglaRiesgoAsignatura(Antecedentes));
            }

            //Retornar riesgo total asignatura
        }



        internal string ObtenerConsecuenteReglaRiesgoAcademicoAlumno(List<string> ListaAntecedentes)
        {

            string promedio_general_alumno;
            string porcentaje_efectividad_aprobacion;
            string porcentaje_efectividad_solicitudes;

        //    XmlDocument xDoc = new XmlDocument();

        
          //  xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");

            XmlNodeList lista_reglas = xDoc.GetElementsByTagName("reglas");

            XmlNodeList regla =
                ((XmlElement)lista_reglas[0]).GetElementsByTagName("regla_riesgos_academico_alumno");

            int numero_regla = 0;

            promedio_general_alumno = ListaAntecedentes[0].ToString();
            porcentaje_efectividad_aprobacion = ListaAntecedentes[1].ToString();
            porcentaje_efectividad_solicitudes = ListaAntecedentes[2].ToString();


            foreach (XmlElement nodo in regla)
            {

                int i = 0;
                //riesgoalumno = "BAJO";
                //riesgoasignatura = "MEDIO";
                XmlNodeList antecedente1 =
                nodo.GetElementsByTagName("promedio_general_alumno");

                XmlNodeList antecedente2 =
                nodo.GetElementsByTagName("porcentaje_efectividad_aprobacion");

                XmlNodeList antecedente3 =
                nodo.GetElementsByTagName("porcentaje_efectividad_solicitudes");

                XmlNodeList consecuente =
                nodo.GetElementsByTagName("then");
                numero_regla++;

                if (promedio_general_alumno.Equals(antecedente1[i].InnerText) && porcentaje_efectividad_aprobacion.Equals(antecedente2[i].InnerText) && porcentaje_efectividad_solicitudes.Equals(antecedente3[i].InnerText))
                {
                    //MessageBox.Show(consecuente[i++].InnerText);
                    return (consecuente[i++].InnerText);
                    //break;
                }

            }
            // MessageBox.Show("" + numero_regla);
            return "";
        }

        internal string ObtenerConsecuenteReglaRiesgoGeneralesUniversidad(List<string> ListaAntecedentes)
        {

            string creditos_totales_inscritos;
            string prerequisitos;
            string atraso_nivel;

         //   XmlDocument xDoc = new XmlDocument();

          //  xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");

            XmlNodeList lista_reglas = xDoc.GetElementsByTagName("reglas");

            XmlNodeList regla =
                ((XmlElement)lista_reglas[0]).GetElementsByTagName("regla_riesgos_generales_universidad");

            int numero_regla = 0;

            creditos_totales_inscritos = ListaAntecedentes[0].ToString();
            prerequisitos = ListaAntecedentes[1].ToString();
            atraso_nivel = ListaAntecedentes[2].ToString();


            foreach (XmlElement nodo in regla)
            {

                int i = 0;
                //riesgoalumno = "BAJO";
                //riesgoasignatura = "MEDIO";
                XmlNodeList antecedente1 =
                nodo.GetElementsByTagName("creditos_totales_inscritos");

                XmlNodeList antecedente2 =
                nodo.GetElementsByTagName("prerequisitos");

                XmlNodeList antecedente3 =
                nodo.GetElementsByTagName("atraso_nivel");

                XmlNodeList consecuente =
                nodo.GetElementsByTagName("then");
                numero_regla++;

                if (creditos_totales_inscritos.Equals(antecedente1[i].InnerText) && prerequisitos.Equals(antecedente2[i].InnerText) && atraso_nivel.Equals(antecedente3[i].InnerText))
                {
                    //MessageBox.Show(consecuente[i++].InnerText);
                    return (consecuente[i++].InnerText);
                    //break;
                }

            }
            // MessageBox.Show("" + numero_regla);
            return "";
        }

        internal string ObtenerConsecuenteReglaRiesgoEntornoAlumno(List<string> ListaAntecedentes)
        {

            string situacion_laboral;
            string financiamiento_estudios;
            string tiene_hijos;
            string procedencia;

          //  XmlDocument xDoc = new XmlDocument();

          //  xDoc.Load(@"C:\Datos MemoriaTitulo en C\reglas.xml");

            XmlNodeList lista_reglas = xDoc.GetElementsByTagName("reglas");

            XmlNodeList regla =
                ((XmlElement)lista_reglas[0]).GetElementsByTagName("regla_riesgo_entorno_alumno");

            int numero_regla = 0;

            situacion_laboral = ListaAntecedentes[0].ToString();
            financiamiento_estudios = ListaAntecedentes[1].ToString();
            tiene_hijos = ListaAntecedentes[2].ToString();
            procedencia = ListaAntecedentes[3].ToString();

            foreach (XmlElement nodo in regla)
            {

                
                XmlNodeList antecedente1 =
                nodo.GetElementsByTagName("situacion_laboral");

                XmlNodeList antecedente2 =
                nodo.GetElementsByTagName("financiamiento_estudios");

                XmlNodeList antecedente3 =
                nodo.GetElementsByTagName("tiene_hijos");

                XmlNodeList antecedente4 =
               nodo.GetElementsByTagName("procedencia");

                XmlNodeList consecuente =
                nodo.GetElementsByTagName("then");
                numero_regla++;
                /*
                if (creditos_totales_inscritos.Equals(antecedente1[i].InnerText) && prerequisitos.Equals(antecedente2[i].InnerText) && atraso_nivel.Equals(antecedente3[i].InnerText))
                {
                    
                    return (consecuente[i++].InnerText);
                    
                }*/

            }
           
            return "";
        }
       
    }
}
