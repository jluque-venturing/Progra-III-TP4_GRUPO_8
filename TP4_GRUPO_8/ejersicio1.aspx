<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejersicio1.aspx.cs" Inherits="TP4_GRUPO_8.ejersicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Destino Inicio</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2><u>DESTINO INICIO</u></h2>

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblProvinciaInicio" runat="server" Text="PROVINCIA:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProvinciaInicio" runat="server"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblLocalidadInicio" runat="server" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidadInicio" runat="server"></asp:DropDownList>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>