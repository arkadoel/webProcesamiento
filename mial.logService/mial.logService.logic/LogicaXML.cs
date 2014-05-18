using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Linq;
using System.Xml;


namespace mial.logService.logic
{
    /// <summary>
    /// Clase encargada de procesar la informacion y extraerla de los archivos
    /// xml que se le pasan.
    /// 
    /// De forma inicial se realizara todo en el mismo hilo y proceso, pero despues se ha de
    /// tender a que se puedan realizar procesamientos en paralelo en distintos procesos e hilos
    /// 
    /// </summary>
    public class LogicaXML
    {
        private string ruta;
        public class Coincidencia
        {
            public string Titulo { get; set; }
            public int NumeroApariciones { get; set; }
            public bool isError { get; set; }
            public string Texto { get; set; }
            public XElement XML { get; set; }
        }
        public List<Coincidencia> Resultados { get; set; }

        public LogicaXML(string _ruta)
        {
            ruta = _ruta;
            Resultados = new List<Coincidencia>();
        }

        /// <summary>
        /// Inicia el procesado de la informacion
        /// </summary>
        public void Procesar()
        {
            XDocument doc = XDocument.Load(ruta);
            try
            {
                
                foreach (XElement accion in doc.Element("Acciones").Elements())
                {
                    string titulo =accion.Attribute("Titulo").Value;

                    int indice = BuscarEnLista(titulo);

                    if (indice == -1)
                    {
                        Coincidencia c = new Coincidencia();
                        c.Titulo = titulo;                        
                        c.NumeroApariciones = 1;
                        Resultados.Add(c);
                    }
                    else
                    {
                        Resultados.ElementAt(indice).NumeroApariciones++;
                    }
                }
            }
            catch { /*..Ignorar errores..*/  }
            finally
            {
                doc = null;
                GC.Collect();
            }
        }

        private int BuscarEnLista(string titulo)
        {
            int pos =-1;
            for (int i = 0; i < Resultados.Count() && pos == -1; i++)
            {
                if (Resultados.ElementAt(i).Titulo.Contains(titulo))
                {
                    pos = i;
                }
            }
            return pos;
        }


        /// <summary>
        /// Consulta como va el procesamiento de la informacion, si termino o no
        /// </summary>
        /// <returns></returns>
        public string ConsultarProceso()
        {
            return "";
        }

        /// <summary>
        /// Una vez terminado el proceso, se pueden obtener las estadisticas y 
        /// resultados generados
        /// </summary>
        public List<Coincidencia> ObtenerEstadisticas()
        {
            return Resultados;
        }
    }
}
