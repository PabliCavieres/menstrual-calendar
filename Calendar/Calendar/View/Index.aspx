<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Calendar.View.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="../Controller/IniciarSesion.ashx" method="post">
    <div>
        
        Tienes una cuenta? Si no, haz clic <a href="CrearUsuario.aspx">Aquí</a>
     
        Iniciar sesión
        <br />
        
            Usuario: <input type="text" name="txtUsuarioInicio" required="required"  />
            <br />
            Contraseña: <input type="password" name="txtContraseñaInicio"  required="required"/>
            <br />
            <input type="submit" name="btnAceptar" value="Iniciar Sesion" />
       
    </div>
    </form>
</body>
</html>
