﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Calendar.View.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<div class="imag">
       <img src="https://data.whicdn.com/images/239644643/original.gif">
    </div>
    <br><br><br>
    <center> 
    <div class="form">
         <div class="titulo"><h1>Crear nuevo usuari@</h1></div><br>
            <div class="imag">
                <img src="https://data.whicdn.com/images/239644643/original.gif">
            </div>


    <form action="../Controller/CrearUsuario.ashx" method="post">
        Usuario: <input type="text" name="txtNomUsuario" required="required" class="cuadros" style="margin-right: -20px;"/><br>
        Contraseña: <input type="password" name="txtContrasenia" required="required" class="cuadros"/><br><br>
        <input type="submit" value="Crear Usuario" class="button1" />
        <input type="button" value="Volver a inicio" class="button1" onclick="location.href='Index.aspx'" />
   </form>
        <div class="imag">
            <img src="https://data.whicdn.com/images/239644643/original.gif">
        </div>
        <br><br>
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
        background-color:white;
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
