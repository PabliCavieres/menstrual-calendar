<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Calendario.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="WebForm1.aspx" method="post">
    <div>
        <h1>Crear Usuario</h1>

        Usuario: <input type="text" name="txtNomUsuario" required="required" />
        Contraseña: <input type="password" name="txtContrasenia" required="required" />
        <input type="submit" value="Aceptar">

    </div>
    </form>
</body>
</html>
