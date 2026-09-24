<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP4_GRUPO_8.ejersicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Destino Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 123px;
        }

        .auto-style4 {
            width: 146px;
            height: 9px;
        }

        .auto-style5 {
            height: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style4" colspan="2">

                    <h2 style="width: 302px"><u>DESTINO INICIO</u></h2>

                </td>

                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblProvinciaInicio" runat="server" Text="PROVINCIA:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProvinciaInicio" runat="server" Width="152px"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblLocalidadInicio" runat="server" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidadInicio" runat="server" Height="16px" Width="152px"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <h2 style="width: 302px"><u>DESTINO INICIO</u></h2>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblProvinciaFinal" runat="server" Text="PROVINCIA:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProvinciaFinal" runat="server" Width="152px"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblLocalidadFinal" runat="server" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidadFinal" runat="server" Height="16px" Width="152px"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </form>
</body>
</html>
