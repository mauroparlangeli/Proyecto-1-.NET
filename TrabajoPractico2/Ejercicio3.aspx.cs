using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TrabajoPractico2
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Rojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Red;
        }

        protected void lbAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Blue;
        }

        protected void lbVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Green;
        }
    }
}