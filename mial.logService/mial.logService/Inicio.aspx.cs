using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mial.logService
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Session[Global._NombreUsuario_] as string;

            if (string.IsNullOrWhiteSpace(nombre) == true)
            {
                Response.Redirect("default.aspx");
            }
            else
            {

                lblNombre.Text = nombre;
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session[Global._NombreUsuario_] = "";
            Response.Redirect("default.aspx");
        }
    }
}