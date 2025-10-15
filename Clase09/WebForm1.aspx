<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clase09.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="icon" href="favicon.ico" type="image/x-icon">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            COOKIES<br />
            <br />
            Valor cookie:
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Valor<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Segundos Expiracion<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear Cookie" />
            <br />
            <br />
            SESSIONS<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Crear Session" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar Session" />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
    <script>
        function getCookie(cookieName) {
            
            const cookieArray = document.cookie.split(';');

            for (let i = 0; i < cookieArray.length; i++) {
                const cookie = cookieArray[i];

                while (cookie.charAt(0) === ' ') {
                    cookie = cookie.substring(1);
                }

                if (cookie.indexOf(cookieName + '=') === 0) {
                    return cookie.substring(cookieName.length + 1);
                }
            }
            return "no existe";
        }

        let miValorDeCookie = getCookie("nombreCookie");
        miValorDeCookie ? console.log("Desde JS cookie es: " + miValorDeCookie) : console.log("Error");
    </script>
</body>
</html>
