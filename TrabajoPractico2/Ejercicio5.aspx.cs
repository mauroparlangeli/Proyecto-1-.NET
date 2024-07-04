using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico2
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int precioMemoria = int.Parse(ddlMemoria.SelectedValue);
            float precioAccesorios = 0;
            foreach(ListItem item in cblAccesorios.Items)
            {
                if (item.Selected)
                {
                    precioAccesorios += float.Parse(item.Value);
                }
                
            }
            float precioFinal = precioMemoria + precioAccesorios;

            LblTotal.Text = "El precio final es de " + precioFinal.ToString("F2") + "$";
        }
    }
}