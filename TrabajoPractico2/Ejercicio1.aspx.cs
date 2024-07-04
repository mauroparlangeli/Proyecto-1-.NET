using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            
            if(ValidarCamposCompletos())//validacion campos
            {
                int cant1 = int.Parse(txtCantidad1.Text);
                int cant2 = int.Parse(txtCantidad2.Text);
                int suma = cant1 + cant2;

                string tabla = "<table border = '1'>";
                tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";
                //Producto 1
                tabla += "<tr> <td>" + txtNombre1.Text + "</td> <td>" + cant1 + "</td> </tr>";
                //Producto 2
                tabla += "<tr> <td>" + txtNombre2.Text + "</td> <td>" + cant2 + "</td> </tr>";
                //Fila total
                tabla += "<tr> <td>TOTAL</td> <td>" + suma + "</td> </tr>";
                tabla += "</Table>";

                lblTabla.Text = tabla;
            }
        }

        private bool ValidarCamposCompletos()
        {
            if(txtNombre1.Text.Trim()=="" || txtNombre2.Text.Trim() == "" || txtCantidad1.Text.Trim() == "" || txtCantidad2.Text.Trim() == "")
                return false;
            else
                return true;
        }

    }
}