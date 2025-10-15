<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploCookies.aspx.cs" Inherits="Clase09.EjemploCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="cuerpo" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                 <asp:ListItem Text="Blanco" Value="white" />
                 <asp:ListItem Text="Negro" Value="black" />
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
        </div>
    </form>
</body>
</html>
