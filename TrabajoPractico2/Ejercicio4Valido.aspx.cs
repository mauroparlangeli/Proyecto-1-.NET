using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class Ejercicio4Valido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            nombre = Request.QueryString["Nom"];
            LblBienvenida.Text = "Bienvenido a mi página Sr./a " + nombre;
        }
    }
}