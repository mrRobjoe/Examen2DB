<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2JoharieEnriquez.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    <div>

        <asp:Button ID="bElectricidad" runat="server" Height="60px" Text="Electricidad" Width="212px" OnClick="bElectricidad_Click" />
&nbsp;
        <asp:Button ID="bAgua" runat="server" Height="60px" Text="Agua" Width="212px" OnClick="bAgua_Click" />
&nbsp;&nbsp;
        <asp:Button ID="bCable" runat="server" Height="60px" Text="Cable" Width="212px" OnClick="bCable_Click" />
&nbsp;&nbsp;
        <asp:Button ID="bTelefono" runat="server" Height="60px" Text="Telefono" Width="212px" OnClick="bTelefono_Click" />

    </div>
</asp:Content>
