<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calendario.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="WebForm3.aspx" method="post">
    <div>
        
        Tienes una cuenta? Si no, haz clic <a href="WebForm2.aspx">Aquí</a>
     
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
