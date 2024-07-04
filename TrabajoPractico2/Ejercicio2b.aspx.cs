using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //temas
            LblTemas.Text = ObtenerTemas();
            lblDatos.Text = ObtenerDatos();

        }

        private string ObtenerTemas()
        {
            CheckBoxList temas = (CheckBoxList)PreviousPage.FindControl("cblTemas");

            string TxtTemas = "Los Temas elegidos son: " + "\n" + "<br>";
            foreach (ListItem item in temas.Items)
            {
                if (item.Selected) { TxtTemas += "&emsp;&emsp;&emsp;<b>" + item.Text + "</b>" + "\n" + "<br>"; }
            }
            return TxtTemas;
        }

        private string ObtenerDatos()
        {
            string Nombre;
            string Apellido;
            string Zona;

            Nombre = ((TextBox)PreviousPage.FindControl("txtNombre")).Text;
            Apellido = ((TextBox)PreviousPage.FindControl("txtApellido")).Text;
            Zona = ((DropDownList)PreviousPage.FindControl("ddlCiudad")).SelectedValue;


            string txtDatos = "Nombre: " + "<b>" + Nombre + "</b>"+ "<br> " +  "Apellido: " + "<b>" + Apellido + "</b>" + "<br> " + "Zona: " + "<b>" +Zona + "</b>";

            return txtDatos;
        }
    }
}