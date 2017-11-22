<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Calendar.View.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sesion</title>
</head>
<body>
    <br><br><br><br><br>
    <center>
      <div class="form">
          <br><br>
      <h1>¡Oh! Lo sentimos, el usuario ingresado no esta registrado :c</h1><br>
        <div class="imag">
            <img src="../Imagenes/pucca.gif" width="300" height="300">
        </div>
          <br><br>
        <input type="button" onclick="location.href = 'Index.aspx'" value="Volver a intentar" class="button1" /> 
          <br>
      </div>
    </center>
</body>
<style>
   h1{
       color:indianred;
   }
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
        margin-top: 140px;
    }

     .button1:hover {
        background: rgba(0,0,0,0);
        color: indianred;
        box-shadow: inset 0 0 0 3px indianred;
     }

    .form {
        font-family: "Lucida Sans Unicode", "Lucida Grande", sans-serif;
        border-style:outset;
        max-width: 800px;
        height:370px;
        border-radius: 90px 90px 90px 90px;
        border-color:indianred;
        background-color:white;
    }

    .titulo{
        border-color:indianred;
        background-color:indianred;
        border-style:solid;
        width: 700px;
        border-radius: 40px 40px 40px 40px;
        margin-top:40px;
        color: white;
    }

    .imag{
        width:2px; height:2px;
        margin-right: 300px;
        margin-top:-120px;
    }

</style>
</html>
