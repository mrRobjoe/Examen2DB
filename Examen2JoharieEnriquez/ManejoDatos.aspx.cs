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

            lCodFactura.Text = ClsCliente.GetFactura().ToString();
            ClsCliente.codSer();
            lCodigoServ.Text = Convert.ToString(ClsCliente.GetTipoServ());
        }

        protected void bSalvar_Click(object sender, EventArgs e)
        {             
            if (ClsCliente.Salvar())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario ha sido guardado');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario no ha sido guardado');", true);
            }

        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            ClsCliente.SetMontoPagar(float.Parse(tMonto.Text));
            ClsCliente.SetDescuento(float.Parse(tDescuento.Text));

            ClsCliente.Calculo();
            lSubTotal.Text = Convert.ToString(ClsCliente.GetSubTotal());
            lIva.Text = Convert.ToString(ClsCliente.GetIVA());
            lTotal.Text = Convert.ToString(ClsCliente.GetTotal());
            lMonto.Text = Convert.ToString(ClsCliente.GetMontoPagar());
            lDescuento.Text = Convert.ToString(ClsCliente.GetDescuento());

        }

        protected void tMonto_TextChanged(object sender, EventArgs e)
        {
            //ClsCliente.SetMontoPagar(float.Parse(tMonto.Text));
        }

        protected void tDescuento_TextChanged(object sender, EventArgs e)
        {
           // ClsCliente.SetDescuento(float.Parse(tDescuento.Text));
        }

        protected void bVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}