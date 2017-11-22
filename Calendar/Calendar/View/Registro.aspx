<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Calendar.View.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

   <form action="../Controller/RegistrarDatos.ashx" method="post" id="checkForm">
        <div>  
            
            inicio: <input type="checkbox" value="true" name="checkinicio"/>
            Termino: <input type="checkbox"  value="true" name="checktermino"/>

            Observaciones: 
            <input type="text" name="observacion"/><br/>
            Se encuentra usando Metodos Anticonceptivos?
            <input type="radio" name="Metodo" value="SI" checked="checked"/> Si 
            <input type="radio" name="Metodo" value="NO"/> No
            Acto Sexual <input type="checkbox" name="checkactosexual"/>

            <h4> Registre sus estados de ánimo</h4>
            agotada <input type="checkbox" value="true" name="checkagotada" />
            ansiosa <input type="checkbox" value="true"  name="checkansiona"/>
            coqueta <input type="checkbox" value="true" name="checkcoqueta"/>
            deprimida <input type="checkbox" value="true" name="checkdeprimida"/>
            enojada <input type="checkbox" value="true" name="checkenojada"/>
            nauseas <input type="checkbox" value="true" name="checknauseas"/>
            libidinosa <input type="checkbox" value="true" name="checklibidinosa"/>
            estres <input type="checkbox" value="true" name="checkestres"/>
            irritable <input type="checkbox" value="true" name="checkirritable"/>
            insomnio <input type="checkbox" value="true" name="checkinsomnio"/>
            rara <input type="checkbox" value="true" name="checkrara"/>
            sensible <input type="checkbox" value="true" name="checksensible"/>

            <hr/>

            <h4>Registre sus sintomas</h4>
            dolorCabeza <input type="checkbox" value="true" name="checkdolordecabeza" />
            migraña <input type="checkbox" value="true" name="checkmigraña"/>
            dolorPechos <input type="checkbox" value="true" name="checkdolorpechos"/>
            sensibilidadPechos <input type="checkbox" value="true" name="checksensibilidadpechos" />
            dolorEspalda <input type="checkbox" value="true" name="checkdolorespalda"/>
            dolorLumbar <input type="checkbox" value="true" name="checkdolorlumbar"/>
            calambre <input type="checkbox" value="true" name="checkcalambre"/>
            escalosfrios <input type="checkbox" value="true" name="checkescalofrios"/>
            sarpullido <input type="checkbox"value="true" name="checksarpullido"/>
            sofoco <input type="checkbox" value="true" name="checksofoco"/>
            dolorPelvis <input type="checkbox" value="true" name="checkdolorpelvis"/>
            hinchazon <input type="checkbox" value="true" name="checkhinchazon"/>
            estreñimiento <input type="checkbox" value="true" name="checkestreñimiento"/>
            diarrea <input type="checkbox" value="true" name="checkdiarrea"/>
            antojos <input type="checkbox" value="true" name="checkantojos"/>
            dolorPorOvulacion <input type="checkbox" value="true" name="checkdolorporovulacion"/>
            sangrado <input type="checkbox" value="true" name="checksangrado"/>
            manchado <input type="checkbox" value="true" name="checkmanchado"/>

            <hr>

            <h4>Tipo de Fluido</h4>
            seco <input type="checkbox" value="true" name="checkseco"/>
            pegajoso <input type="checkbox" value="true" name="checkpegajoso"/>
            cremoso <input type="checkbox" value="true" name="checkcremoso"/>
            verde <input type="checkbox" value="true" name="checkverde"/>
            conSangre <input type="checkbox" value="true" name="checkconSangre"/>
            conMalOlor <input type="checkbox" value="true" name="checkconMalOlor"/>

            <input type="submit" value="Registrar Datos"/>

        </div>
    </form>
</body>
</html>
