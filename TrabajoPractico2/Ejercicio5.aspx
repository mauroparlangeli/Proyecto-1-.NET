<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TrabajoPractico2.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 66px;
        }
        .auto-style3 {
            width: 66px;
            height: 59px;
        }
        .auto-style4 {
            height: 59px;
        }
        .auto-style5 {
            height: 407px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
        <asp:Label ID="lblMensaje" runat="server" Text="Elija su configuración" Font-Bold="True" Font-Size="18pt"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <br />
                        <asp:Label ID="lblSelectMemoria" runat="server" Font-Bold="True" Text="Seleccione cantidad de memoria:"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <br />
                        <asp:DropDownList ID="ddlMemoria" runat="server" OnSelectedIndexChanged="ddlMemoria_SelectedIndexChanged">
                            <asp:ListItem Value="200">2GB</asp:ListItem>
                            <asp:ListItem Value="375">4GB</asp:ListItem>
                            <asp:ListItem Value="500">6GB</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblAccesorios" runat="server" Font-Bold="True" Text="Seleccione accesorios:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:CheckBoxList ID="cblAccesorios" runat="server">
                            <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
                            <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                            <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular Precio" OnClick="btnCalcular_Click" />
            <br />
            <br />
            <asp:Label ID="LblTotal" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
