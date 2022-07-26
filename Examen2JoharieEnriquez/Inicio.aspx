<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2JoharieEnriquez.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/estilos.css" rel="stylesheet" />
    <p>
        Nombre:
        <asp:TextBox ID="tNombre" runat="server" OnTextChanged="tNombre_TextChanged"></asp:TextBox>
    </p>
    <p>
        Cedula:
        <asp:TextBox ID="TCedula" runat="server" OnTextChanged="TCedula_TextChanged"></asp:TextBox>
    </p>
    <p>
        Telefono:
        <asp:TextBox ID="tTelefono" runat="server" OnTextChanged="tTelefono_TextChanged"></asp:TextBox>
    </p>
    <p>
        Direccion:
        <asp:TextBox ID="tDireccion" runat="server" OnTextChanged="tDireccion_TextChanged"></asp:TextBox>
    </p>

    <div class="cent">

        <asp:ImageButton Class="button" ImageUrl="~/images/electricidad.png" runat="server" ID="bElectricidadd" Height="90px" Width="212px" OnClick="bElectricidadd_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="~/images/Agua.png" runat="server" ID="bAguaa" Height="90px" Width="212px" OnClick="bAguaa_Click" />
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="~/images/Cable.jpg" runat="server" ID="bCablee" Height="90px" Width="212px" OnClick="bCablee_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="~/images/phone.jpg" runat="server" ID="bTelefonno" Height="90px" Width="212px" OnClick="bTelefonno_Click" />

    </div>
</asp:Content>
