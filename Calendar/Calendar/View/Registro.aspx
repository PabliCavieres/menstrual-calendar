<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Calendar.View.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<center>
   <form action="../Controller/RegistrarDatos.ashx" method="post" id="checkForm">
       <br><br><br>
       <div class="form"> 
           <div class="titulo"><h2>Cuentenos..</h2></div>
           <p align="left" style="margin-left:40px;">
            Inicio: <input type="checkbox" value="true" name="checkinicio"/><br>
            Termino: <input type="checkbox"  value="true" name="checktermino"/><br>
            Se encuentra usando Metodos Anticonceptivos?
            <input type="radio" name="Metodo" value="SI" checked="checked"/> Si 
            <input type="radio" name="Metodo" value="NO"/> No<br>
            Acto Sexual <input type="checkbox" value="true" name="checkActosexual"/><br>
            Observaciones: 
            <input type="text" name="observacion"/><br/>
            </p>
            </div>
            <br><br>
          <div class="form"> 
            <h4> Sus estados de ánimo</h4>
           <hr>
            <div class="carita">
                <img src="../Imagenes/carita.gif" width="300" height="170">
            </div>
            
            <p align="left" style="margin-left:40px; margin-top:-170px">
            Agotada <input type="checkbox" value="checkagotada" /><br>
            Ansiosa <input type="checkbox" value="checkansiona" /><br>
            Coqueta <input type="checkbox" value="checkcoqueta" /><br>
            Deprimida <input type="checkbox" value="checkdeprimida"/><br>
            Enojada <input type="checkbox" value="checkenojada" /><br>
            Nauseas <input type="checkbox" value="checknauseas" /><br>
           </p>
           <p align="right" style="margin-top:-150px; margin-right:40px;">
            Libidinosa <input type="checkbox" value="checklibidinosa" /><br>
            Estres <input type="checkbox" value="checkestres" /><br>
            Irritable <input type="checkbox" value="checkirritable" /><br>
            Insomnio <input type="checkbox" value="checkinsomnio" /><br>
            Rara <input type="checkbox" value="checkrara" /><br>
            Sensible <input type="checkbox" value="checksensible" /><br>
           </p>
           <br><br>
           </div><br><br>

           <div class="form"> 
           <h4>Registre sus sintomas</h4>
           <hr>
            <div class="carita">
                <img src="../Imagenes/carita.gif" width="300" height="170">
            </div>
           <p align="left" style="margin-left:40px; margin-top:-170px">
            Dolor cabeza <input type="checkbox" value="checkdolordecabeza" /><br>
            Migraña <input type="checkbox" value="checkmigraña" /><br>
            Dolor pechos <input type="checkbox" value="checkdolorpechos" /><br>
            Sensibilidad pechos <input type="checkbox" value="checksensibilidadpechos" /><br>
            Dolor espalda <input type="checkbox" value="checkdolorespalda" /><br>
            Dolor lumbar <input type="checkbox" value="checkdolorlumbar" /><br>
            Calambre <input type="checkbox" value="checkcalambre" /><br>
            Escalosfrios <input type="checkbox" value="checkescalofrios" /><br>
            Sarpullido <input type="checkbox" value="checksarpullido" /><br>
            </p>

           <p align="right" style="margin-top:-236px; margin-right:40px;">
            Sofoco <input type="checkbox" value="checksofoco" /><br>
            Dolor de Pelvis <input type="checkbox" value="checkdolorpelvis" /><br>
            Hinchazon <input type="checkbox" value="checkhinchazon" /><br>
            Estreñimiento <input type="checkbox" value="checkestreñimiento" /><br>
            Diarrea <input type="checkbox" value="checkdiarrea" /><br>
            Antojos <input type="checkbox" value="checkantojos" /><br>
            Dolor por ovulacion <input type="checkbox" value="checkdolorporovulacion" /><br>
            Sangrado <input type="checkbox" value="checksangrado" /><br>
            Manchado <input type="checkbox" value="checkmanchado" /><br><br>
            </p>
           </div><br><br>

             <div class="form"> 
            <h4>Tipo de Fluido</h4>
            <hr>
           <div class="carita">
                <img src="../Imagenes/carita.gif" width="300" height="170">
            </div>

            <p align="left" style="margin-left:40px; margin-top:-170px">
            Seco <input type="checkbox" value="checkseco" /><br>
            Pegajoso <input type="checkbox" value="checkpegajoso" /><br>
            Cremoso <input type="checkbox" value="checkcremoso" /><br>
            </p>

           <p align="right" style="margin-top:-90px; margin-right:40px;">
            Verde <input type="checkbox" value="checkverde" /><br>
            Con Sangre <input type="checkbox" value="checkconSangre" /><br>
            Con Mal Olor <input type="checkbox" value="checkconMalOlor" /><br><br>
            </p><br><br>
           </div><br><br>
            <br>

            <input type="submit" value="Registrar Datos" class="button1"><br><br>
    </form>
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

    .carita{
        width:300px; height:170px;
    }
  
</style>
</html>
