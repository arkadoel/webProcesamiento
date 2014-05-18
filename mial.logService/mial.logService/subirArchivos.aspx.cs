using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mial.logService.logic;

namespace mial.logService
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected string ObtenerNombre()
        {
            return logic.comun.GenerarNombreArchivo(Session[Global._NombreUsuario_] as string);
        }

        protected void btnProcesar_Click(object sender, EventArgs e)
        {
            logic.LogicaXML xml = new LogicaXML(Session[Global._Archivo_a_Procesar] as string);
            xml.Procesar();
            List<logic.LogicaXML.Coincidencia> resultados= xml.ObtenerEstadisticas();

            VerResultados.InnerHtml=@"<table>";
            foreach (logic.LogicaXML.Coincidencia coin in resultados)
            {
                VerResultados.InnerHtml += "<tr><td>" + coin.Titulo + "</td><td>" + coin.NumeroApariciones.ToString() + "</td></tr>";

            }
            VerResultados.InnerHtml += "</table>";
        }

       
    }
}