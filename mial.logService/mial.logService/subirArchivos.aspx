<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="subirArchivos.aspx.cs" Inherits="mial.logService._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mi Alejandría Servicio Logs</title>
    
    <!-- Mis css -->
    <link rel="stylesheet" href="css/main.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div >

		<h1>Subida de archivos y procesamiento automatico</h1>
        <h2>Actualmente solo procesamos aquellos archivos generados por las librerias de codigo abierto y gratuitas que ofrecemos
             en nuestro perfil de gitHub. Con el tiempo iremos implementando otros sistemas.
        </h2>
	        
            <div id="Subida" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Label">Seleccione un archivo xml para procesar</asp:Label>

	            <asp:FileUpload ID="FileUpload1" runat="server" />

	            <br />
                <asp:Button ID="btnSubir"  runat="server" Text="Subir" OnClick="btnSubir_Click" />
                <script runat="server">
                    protected void btnSubir_Click(object sender, EventArgs e)
                    {
                        string extn = string.Empty;
                        if (FileUpload1.HasFile)
                        {
                            extn = System.IO.Path.GetExtension(FileUpload1.FileName);
                            if (".xml" == extn)
                            {
                                string ruta = Server.MapPath("~/subidas/" + ObtenerNombre()  );
                                FileUpload1.SaveAs(ruta);
                                Label1.Text = "Se ha subido el archivo con exito";
                                Session[global_asax._Archivo_a_Procesar] = ruta;
                                

                                if (string.IsNullOrWhiteSpace(Session[global_asax._Archivo_a_Procesar] as string) == false && 
                                    System.IO.File.Exists(Session[global_asax._Archivo_a_Procesar]as string) == true)
                                {
                                    Subida.Visible = false;
                                    Procesado.Visible = true; 
                                }
                                else
                                {
                                    Label1.Text = "Sucedio un error inesperado";
                                }
                                
                            }
                            else
                            {
                                Label1.Text = "Solo se admiten archivos XML";
                            }
                        }
                        else
                        {
                            Label1.Text = "Seleccione un archivo a subir";
                        }
                    }
                </script>
	        </div>
            <div id="Procesado" runat="server" visible="false">
                <br />
                <h3 style="color: orange;">
                    El archivo esta subido, pulse <span style="font-weight:bold;">Procesar</span> 
                    para comenzar</h3>
                <asp:Button ID="btnProcesar" runat="server" Text="Procesar archivo" OnClick="btnProcesar_Click" />
                <br /><br />
                <div runat="server" id="VerResultados">
                    
                </div>
            </div>
    </div>
    </form>
</body>
</html>
