<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Calendar.View.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <%
        String nombre = null;
        try {
            nombre = Session["nombre"].ToString();

            if (nombre == null) {
                Response.Redirect("Index.aspx");
            }
        } catch (Exception) {
            Response.Redirect("Index.aspx");
        }

    %>

    <form action="Calendario.aspx" method="post">
        <div>
            Bienvenida<%=nombre %>
            <br/>
            Necesitamos que llene estos datos antes de Comenzar
            <br/>
            Fecha de la ultima regla : <input type="text" value="fechaUltimaRegla"/><br/>
            Duración del Ciclo : <input type="number"/><br/>
            Duracion del Periodo : <input type="number"/><br/>
            <br/>
            <input type="submit" value="Aceptar"/>
        </div>
    </form>
</body>
</html>
