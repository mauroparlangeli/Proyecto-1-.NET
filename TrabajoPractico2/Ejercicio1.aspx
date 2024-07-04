<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TrabajoPractico2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;
            Ingrese nombre del producto:<asp:TextBox ID="txtNombre1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:
            <asp:TextBox ID="txtCantidad1" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;
            Ingrese nombre del producto:<asp:TextBox ID="txtNombre2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:
            <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
            <br />
&nbsp;<br />
&nbsp;
            <asp:Button ID="btnGenerarTabla" runat="server" Text="Generar Tabla" OnClick="btnGenerarTabla_Click" />
            <br />
            <br />
&nbsp;
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
