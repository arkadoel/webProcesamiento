using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mial.logService.data
{
    public class LogicaUsuarios
    {
        /// <summary>
        /// Devuelve un usuario sacado de la base de datos por su
        /// loginName y su contraseña
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static Usuario getUser(string name, string pass)
        {
            var us = from g in dB.Tablas.Usuarios
                     where g.loginName == name && g.password == pass
                     select g;

            if (us.Count() > 0)
            {
                return us.First();
            }
            else return null;
        }
    }
}