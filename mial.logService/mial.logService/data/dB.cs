using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mial.logService.data
{
    public class dB
    {
        private static LogServDBEntities tablas;

        public static LogServDBEntities Tablas
        {
            get
            {
                if (tablas == null)
                {
                    tablas = new LogServDBEntities();
                }
                return tablas;
            }
            set
            {
                tablas = value;
            }
        }
    }
}