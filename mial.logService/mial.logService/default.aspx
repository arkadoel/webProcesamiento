<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="mial.logService._default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prototipo Servicio Logs</title>
    <link rel="stylesheet" href="css/main.css" type="text/css" />

</head>
<body style="background-color: ghostwhite;">
    <form id="form1" runat="server">
    <div id="Pantalla">
        <h1>Prototipo para el servicio de Logs</h1>
        <p>Por favor inicie sesion en el siguiente formulario</p>
        <br />
        <div style="margin: 0 auto; text-align:center; width: 300px; background-color:gainsboro; padding:20px; ">
            <asp:Label ID="lblError"  runat="server" Text="Error: revise si el nombre de usuario o contraseña son correctos" Visible="False" ForeColor="#CC3300"></asp:Label>
            <br /><br />
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"></asp:TextBox>
            <br />
            Contraseña:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnInicioSesion" runat="server" Text="Entrar" OnClick="btnInicioSesion_Click" />

        </div>

    </div>
    <div id="Pantalla2">
        <h1>Necesitará una pantalla mas ancha para poder ver esta pagina</h1>
    </div>
    </form>
</body>
</html>
