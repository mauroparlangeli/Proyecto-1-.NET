using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "claudio" &&  txtClave.Text == "casas")
            {
                Response.Redirect("Ejercicio4Valido.aspx?Nom=" + txtUsuario.Text);
            }
            else
            {
                Response.Redirect("Ejercicio4Invalido.aspx");
            }
            
        }
    }
}