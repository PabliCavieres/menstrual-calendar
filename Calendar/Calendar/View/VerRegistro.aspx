<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerRegistro.aspx.cs" Inherits="Calendar.View.VerRegistro" %>

<%@ Import Namespace="Calendar.Model" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<center>
   <form action="Calendario.aspx" method="post" id="checkForm">
 <br><br><br>

        <% Data d = new Data();
            String idUsuarios = Request.Params["idUsuario"];
            // Registro r = d.getRegistro("idUsuarios");
            Registro r = new Registro();

            %>

       <div class="form"> 
           <div class="titulo"><h2>Datos</h2></div>
           <p align="left" style="margin-left:40px;" >          

            Inicio: <input type="radio" value="Inicio" name="checkinicio" checked="checked"/><br/>
            Termino: <input type="radio"  value="Termino" name="checkinicio"/><br/>
            Se encuentra usando Metodos Anticonceptivos?
            <input type="radio" name="Metodo" value="Si" checked="checked"/> Si 
            <input type="radio" name="Metodo" value="No"/> No<br/>
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
            <input type="checkbox" name="checkagotada" value="<%=r.Agotada%>" />Agotada <br/>
            <input type="checkbox" name="checkansiosa" value="<%=r.Ansiosa%>"/>Ansiosa <br/>
            <input type="checkbox" name="checkcoqueta" value="<%=r.Coqueta%>"/>Coqueta <br/>
            <input type="checkbox" name="checkdeprimida" value="<%=r.Deprimida%>"/>Deprimida <br/>
            <input type="checkbox" name="checkenojada" value="<%=r.Enojada%>"/>Enojada <br/>
            <input type="checkbox" name="checknauseas" value="<%=r.Nauseas%>"/>Nauseas <br/>
           </p>
           <p align="right" style="margin-top:-150px; margin-right:40px;">
            Libidinosa <input type="checkbox" name="checklibidinosa" value="<%=r.Libidinosa%>"/><br>
            Estres <input type="checkbox" name="checkestres" value="<%=r.Estres%>"/><br>
            Irritable <input type="checkbox" name="checkirritable" value="<%=r.Irritable%>"/><br>
            Insomnio <input type="checkbox" name="checkinsomnio" value="<%=r.Insomnio%>"/><br>
            Rara <input type="checkbox" name="checkrara" value="<%=r.Rara%>"/><br>
            Sensible <input type="checkbox" name="checksensible" value="<%=r.Sensible%>"/><br>
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
            <input type="checkbox" name="checkdolordecabeza" value="<%=r.DolorCabeza%>"/>Dolor de cabeza <br/>
            <input type="checkbox" name="checkmigraña" value="<%=r.Migraña%>"/>Migraña <br/>
            <input type="checkbox" name="checkdolorpechos" value="<%=r.DolorPechos%>"/> Dolor de pechos <br/>
            <input type="checkbox" name="checksensibilidadpechos" value="<%=r.SensibilidadPechos%>"/>Sensibilidad pechos <br/>
            <input type="checkbox" name="checkdolorespalda" value="<%=r.DolorEspalda%>"/>Dolor espalda <br/>
            <input type="checkbox" name="checkdolorlumbar" value="<%=r.DolorLumbar%>"/>Dolor lumbar <br/>
            <input type="checkbox" name="checkcalambre" value="<%=r.Calambre%>"/>Calambre <br/>
            <input type="checkbox" name="checkescalofrios" value="<%=r.Escalosfrios%>"/>Escalosfrios <br/>
            <input type="checkbox" name="checksarpullido" value="<%=r.Sarpullido%>" />Sarpullido <br/>
            </p>

           <p align="right" style="margin-top:-236px; margin-right:40px;">
            Sofoco <input type="checkbox" name="checksofoco" value="true"/><br/>
            Dolor de Pelvis <input type="checkbox" name="checkdolorpelvis" value="<%=r.DolorPelvis%>"/><br/>
            Hinchazon <input type="checkbox" name="checkhinchazon" value="<%=r.Hinchazon%>"/><br/>
            Estreñimiento <input type="checkbox" name="checkestreñimiento" value="<%=r.Estreñimiento%>"/><br/>
            Diarrea <input type="checkbox" name="checkdiarrea" value="<%=r.Diarrea%>"/><br/>
            Antojos <input type="checkbox" name="checkantojos" value="<%=r.Antojos%>"/><br/>
            Dolor por ovulacion <input type="checkbox" name="checkdolorporovulacion" value="<%=r.DolorPorOvulacion%>"/><br/>
            Sangrado <input type="checkbox" name="checksangrado" value="<%=r.Sangrado%>"/><br/>
            Manchado <input type="checkbox" name="checkmanchado" value="<%=r.Manchado%>"/><br/><br/>
            </p>
           </div><br/><br/>

             <div class="form"> 
            <h4>Tipo de Fluido</h4>
            <hr/>
           <div class="carita">
                <img src="../Imagenes/carita.gif" width="300" height="170">
            </div>

            <p align="left" style="margin-left:40px; margin-top:-170px">
            <input type="checkbox" name="checkseco" value="<%=r.Seco%>"/>Seco <br/>
            <input type="checkbox" name="checkpegajoso" value="<%=r.Pegajoso%>"/>Pegajoso <br/>
            <input type="checkbox" name="checkcremoso" value="<%=r.Cremoso%>"/>Cremoso <br/>
            </p>

           <p align="right" style="margin-top:-90px; margin-right:40px;">
            Verde <input type="checkbox" name="checkverde" value="<%=r.Verde%>"/><br/>
            Con Sangre <input type="checkbox" name="checkconSangre" value="<%=r.ConSangre%>"/><br/>
            Con Mal Olor <input type="checkbox" name="checkconMalOlor" value="<%=r.ConMalOlor%>"/><br/><br/>
            </p><br/><br/>
           </div><br/><br/>
            <br>

            <input type="submit" value="Volver" class="button1"/><br/><br/>
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
