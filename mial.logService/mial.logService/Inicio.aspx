<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="mial.logService.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <!-- Mis css -->
    <link rel="stylesheet" href="css/main.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Bienvenido:<asp:Label ID="lblNombre" runat="server" Text="_"></asp:Label></h1>
        <a href="subirArchivos.aspx" >Subir un archivo para procesar automaticamente</a>
        <br />
         <a href="enviarArchivo.aspx" >Enviar un archivo para que lo procesemos</a>
        <br /><br />
        <asp:Button ID="btnCerrarSesion" runat="server" Text="Salir" OnClick="btnCerrarSesion_Click" />
    </div>
    </form>
</body>
</html>
