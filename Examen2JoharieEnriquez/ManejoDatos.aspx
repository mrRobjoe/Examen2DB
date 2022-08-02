<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ManejoDatos.aspx.cs" Inherits="Examen2JoharieEnriquez.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/estilos.css" rel="stylesheet" />
    <fieldset>
        <legend>Facturación</legend>
        <p>
        Cod Factura:
        <asp:Label ID="lCodFactura" runat="server" Text="Label"></asp:Label><br />
        Codigo Servicio: <asp:Label ID="lCodigoServ" runat="server" Text=""></asp:Label><br />
        </p> 
        <p>
         Mes:
        <asp:DropDownList ID="DropDownList1" runat="server" Height="27px">
            <asp:ListItem>Enero</asp:ListItem>
            <asp:ListItem>Febrero</asp:ListItem>
            <asp:ListItem>Marzo</asp:ListItem>
            <asp:ListItem>Abril</asp:ListItem>
            <asp:ListItem>Mayo</asp:ListItem>
            <asp:ListItem>Junio</asp:ListItem>
            <asp:ListItem>Julio</asp:ListItem>
            <asp:ListItem>Agosto</asp:ListItem>
            <asp:ListItem>Septiembre</asp:ListItem>
            <asp:ListItem>Octubre</asp:ListItem>
            <asp:ListItem>Noviembre</asp:ListItem>
            <asp:ListItem>Diciembre</asp:ListItem>
        </asp:DropDownList><br />
        </p>
        <p>
        Monto: <asp:TextBox ID="tMonto" runat="server" OnTextChanged="tMonto_TextChanged"></asp:TextBox>              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;              Descuento: <asp:TextBox ID="tDescuento" runat="server" OnTextChanged="tDescuento_TextChanged"></asp:TextBox><br />
        </p>
        <div>
        <asp:Button ID="bAgregar" runat="server" Text="Agregar" OnClick="bAgregar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bSalvar" runat="server" Text="Salvar" OnClick="bSalvar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bVolver" runat="server" Text="Volver" OnClick="bVolver_Click" />    
        </div>
    </fieldset>

    <fieldset>
        <legend>Cliente</legend>
        <p>
            Nombre:
            <asp:Label ID="lNombre" runat="server"></asp:Label><br />
            Cedula:
            <asp:Label ID="lCedula" runat="server"></asp:Label><br />
            Telefono:
            <asp:Label ID="lTelefono" runat="server"></asp:Label><br />
            Direccion:
            <asp:Label ID="lDireccion" runat="server"></asp:Label>
        </p>

    </fieldset>
   
        
    <fieldset>
        <legend>Facturación</legend>   
        <p>
            Monto: 
            <asp:Label ID="lMonto" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp; Descuento:<asp:Label ID="lDescuento" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp; SubTotal:
            <asp:Label ID="lSubTotal" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; IVA:
            <asp:Label ID="lIva" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; Total:<asp:Label ID="lTotal" runat="server" Text="Label"></asp:Label>

       </p>
    </fieldset>
    
</asp:Content>
