using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mial.logService
{
    public partial class _default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            data.Usuario usuario = data.LogicaUsuarios.getUser(txtNombre.Text, txtPassword.Text);
            if (usuario != null)
            {
                Session[Global._NombreUsuario_] = usuario.loginName;
                Response.Redirect("Inicio.aspx");

            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}