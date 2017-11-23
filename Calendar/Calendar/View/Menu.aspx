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
            nombre = (String)Session["txtUsuarioInicio"];

        } catch (Exception) {
            Response.Redirect("Index.aspx");
        }
    %>
<center>
    <div class="form">
    <form action="../Controller/RegistrarCiclo.ashx" method="post">
       <div class="titulo"><h2>Bienvenida <%=nombre %></h2></div><br>
            <br/>
            Necesitamos que llene estos datos antes de Comenzar
            <br/>
            Fecha de la ultima regla : <input type="text" name="fechaUltimaRegla" placeholder="AAAA/mm/dd"  class="cuadros" required="required"/><br>
            Duración del Ciclo : <input type="number" name="duracionCiclo" class="cuadros" style="margin-right: -45px;" required="required"/><br>
            Duracion del Periodo : <input type="number" name="duracionPeriodo" class="cuadros" style="margin-right: -25px; "required="required"/><br>
            <br/><br/>         
            <input type="submit" value="Aceptar" class="button1"/><br>
    </form>
   </div>
</center>
</body>
<style>
body{
        Background-image:url("../Imagenes/fondoCal.jpg");
    }
    .button1 {
        border-style: none;
        border-color: inherit;
        border-width: medium;
        background: indianred;
        color: #f2f2f2;
        padding: 10px;
        font-size: 18px;
        border-radius: 5px;
        position: relative;
        box-sizing: border-box;
        transition: all 500ms ease;
        top: 0px;
        left: 0px;
    }

     .button1:hover {
        background: rgba(0,0,0,0);
        color: indianred;
        box-shadow: inset 0 0 0 3px indianred;
     }

    .cuadros {
        width: 300px;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid purple;
        border-radius: 4px;
        box-sizing: border-box;
    }

    .form {
        font-family: "Lucida Sans Unicode", "Lucida Grande", sans-serif;
        border-style:outset;
        max-width: 700px;
        border-radius: 30px 30px 30px 30px;
        border-color:indianred;
    }

    .titulo{
        border-color:indianred;
        background-color:indianred;
        border-style:solid;
        width: 400px;
        border-radius: 40px 40px 40px 40px;
        margin-top:-40px;
        color: white;
    }

    .imag{
        width:2px; height:2px;
        margin-right: 300px;
    }
</style>
</html>
