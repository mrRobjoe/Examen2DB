using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2JoharieEnriquez
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tNombre_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.SetNombre(tNombre.Text);
            
        }

        protected void TCedula_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.SetCedula(TCedula.Text);
        }

        protected void tTelefono_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.SetTelefono(tTelefono.Text);
        }

        protected void tDireccion_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.SetDireccion(tDireccion.Text);
        }

        protected void bElectricidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManejoDatos.aspx");
        }

        protected void bAgua_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManejoDatos.aspx");
        }

        protected void bCable_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManejoDatos.aspx");
        }

        protected void bTelefono_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManejoDatos.aspx");
        }
    }
}