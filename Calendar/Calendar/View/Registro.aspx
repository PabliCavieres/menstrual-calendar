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
           <p align="left" style="margin-left:40px;" >

            

            Inicio: <input type="checkbox" value="true" name="checkinicio"/><br/>
            Termino: <input type="checkbox"  value="true" name="checktermino"/><br/>
            Se encuentra usando Metodos Anticonceptivos?
            <input type="radio" name="Metodo" value="s" checked="checked"/> Si 
            <input type="radio" name="Metodo" value="n"/> No<br/>
            Acto Sexual <input type="checkbox" value="true" name="checkActosexual"/><br/>
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
            Agotada <input type="checkbox" name="checkagotada" value="true" /><br/>
            Ansiosa <input type="checkbox" name="checkansiosa" value="true"/><br/>
            Coqueta <input type="checkbox" name="checkcoqueta" value="true"/><br/>
            Deprimida <input type="checkbox" name="checkdeprimida" value="true"/><br/>
            Enojada <input type="checkbox" name="checkenojada" value="true"/><br/>
            Nauseas <input type="checkbox" name="checknauseas" value="true"/><br/>
           </p>
           <p align="right" style="margin-top:-150px; margin-right:40px;">
            Libidinosa <input type="checkbox" name="checklibidinosa" value="true"/><br>
            Estres <input type="checkbox" name="checkestres" value="true"/><br>
            Irritable <input type="checkbox" name="checkirritable" value="true"/><br>
            Insomnio <input type="checkbox" name="checkinsomnio" value="true"/><br>
            Rara <input type="checkbox" name="checkrara" value="true"/><br>
            Sensible <input type="checkbox" name="checksensible" value="true"/><br>
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
            Dolor cabeza <input type="checkbox" name="checkdolordecabeza" value="true"/><br>
            Migraña <input type="checkbox" name="checkmigraña" value="true"/><br>
            Dolor pechos <input type="checkbox" name="checkdolorpechos" value="true"/><br>
            Sensibilidad pechos <input type="checkbox" name="checksensibilidadpechos" value="true"/><br>
            Dolor espalda <input type="checkbox" name="checkdolorespalda" value="true"/><br>
            Dolor lumbar <input type="checkbox" name="checkdolorlumbar" value="true"/><br>
            Calambre <input type="checkbox" name="checkcalambre" value="true"/><br>
            Escalosfrios <input type="checkbox" name="checkescalofrios" value="true"/><br>
            Sarpullido <input type="checkbox" name="checksarpullido" value="true" /><br>
            </p>

           <p align="right" style="margin-top:-236px; margin-right:40px;">
            Sofoco <input type="checkbox" name="checksofoco" value="true"/><br>
            Dolor de Pelvis <input type="checkbox" name="checkdolorpelvis" value="true"/><br>
            Hinchazon <input type="checkbox" name="checkhinchazon" value="true"/><br>
            Estreñimiento <input type="checkbox" name="checkestreñimiento" value="true"/><br>
            Diarrea <input type="checkbox" name="checkdiarrea" value="true"/><br>
            Antojos <input type="checkbox" name="checkantojos" value="true"/><br>
            Dolor por ovulacion <input type="checkbox" name="checkdolorporovulacion" value="true"/><br>
            Sangrado <input type="checkbox" name="checksangrado" value="true"/><br>
            Manchado <input type="checkbox" name="checkmanchado" value="true"/><br><br>
            </p>
           </div><br><br>

             <div class="form"> 
            <h4>Tipo de Fluido</h4>
            <hr>
           <div class="carita">
                <img src="../Imagenes/carita.gif" width="300" height="170">
            </div>

            <p align="left" style="margin-left:40px; margin-top:-170px">
            Seco <input type="checkbox" name="checkseco" value="true"/><br>
            Pegajoso <input type="checkbox" name="checkpegajoso" value="true"/><br>
            Cremoso <input type="checkbox" name="checkcremoso" value="true"/><br>
            </p>

           <p align="right" style="margin-top:-90px; margin-right:40px;">
            Verde <input type="checkbox" name="checkverde" value="true"/><br>
            Con Sangre <input type="checkbox" name="checkconSangre" value="true"/><br>
            Con Mal Olor <input type="checkbox" name="checkconMalOlor" value="true"/><br><br>
            </p><br><br>
           </div><br><br>
            <br>

            <input type="submit" value="Registrar Datos" class="button1"/><br><br>
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
