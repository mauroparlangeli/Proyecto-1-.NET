using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cblTemas.Items.Add("Ciencias");
                cblTemas.Items.Add("Literatura");
                cblTemas.Items.Add("Historia");
            }

            lblNombreVacio.Text = "";
            lblApellidoVacio.Text = "";

        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="" & txtApellido.Text!="")
            {
                Server.Transfer("Ejercicio2b.aspx");
            }
            else
            {
                if (txtNombre.Text == "" )
                {
                    lblNombreVacio.Text = "Debe ingresar su nombre!";

                    if (txtApellido.Text == "")
                    {
                        lblApellidoVacio.Text = "Debe ingresar su apellido!";
                    }
                }

                else
                {
                    lblApellidoVacio.Text = "Debe ingresar su apellido!";
                }
            }

            
        }

        protected void ddlCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}