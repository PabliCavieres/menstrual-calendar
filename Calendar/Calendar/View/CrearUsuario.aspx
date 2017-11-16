<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Calendar.View.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="../Controller/CrearUsuario.ashx" method="post">
    <div>
        <h1>Registro</h1>

        Usuario: <input type="text" name="txtNomUsuario" required="required" />
        Contraseña: <input type="password" name="txtContrasenia" required="required" />
        <input type="submit" value="Aceptar"/>

    </div>
    </form>
</body>
</html>
