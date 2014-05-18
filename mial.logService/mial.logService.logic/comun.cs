using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mial.logService.logic
{
    public class comun
    {
        /// <summary>
        /// Genera un nombre aleatorio en base a la fecha-hora y 
        /// el usuario que lo solicita
        /// </summary>
        /// <returns></returns>
        public static string GenerarNombreArchivo(string nombreUsuario)
        {
            string nombre = "";
            nombre += DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString();
            nombre += DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            nombre += nombreUsuario + ".xml";
            return nombre;
        }
    }
}
