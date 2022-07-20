using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2JoharieEnriquez
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lNombre.Text = ClsCliente.GetNombre();
            lCedula.Text=ClsCliente.GetCedula();
            lTelefono.Text=ClsCliente.GetTelefono();
            lDireccion.Text=ClsCliente.GetDireccion();
        }

        protected void bSalvar_Click(object sender, EventArgs e)
        {
            
        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            //lMonto.Text=ClsCliente.Get
        }

        protected void tMonto_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.SetMontoPagar(tMonto.Text);
        }
    }
}