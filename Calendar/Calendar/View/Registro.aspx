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
            <h4> Registre sus estados de ánimo</h4>
            agotada <input type="checkbox" value="checkagotada" />
            ansiosa <input type="checkbox" value="checkansiona" />
            coqueta <input type="checkbox" value="checkcoqueta" />
            deprimida <input type="checkbox" value="checkdeprimida" />
            enojada <input type="checkbox" value="checkenojada" />
            nauseas <input type="checkbox" value="checknauseas" />
            libidinosa <input type="checkbox" value="checklibidinosa" />
            estres <input type="checkbox" value="checkestres" />
            irritable <input type="checkbox" value="checkirritable" />
            insomnio <input type="checkbox" value="checkinsomnio" />
            rara <input type="checkbox" value="checkrara" />
            sensible <input type="checkbox" value="checksensible" />

            <hr>

            <h4>Registre sus sintomas</h4>
            dolorCabeza <input type="checkbox" value="checkdolordecabeza" />
            migraña <input type="checkbox" value="checkmigraña" />
            dolorPechos <input type="checkbox" value="checkdolorpechos" />
            sensibilidadPechos <input type="checkbox" value="checksensibilidadpechos" />
            dolorEspalda <input type="checkbox" value="checkdolorespalda" />
            dolorLumbar <input type="checkbox" value="checkdolorlumbar" />
            calambre <input type="checkbox" value="checkcalambre" />
            escalosfrios <input type="checkbox" value="checkescalofrios" />
            sarpullido <input type="checkbox" value="checksarpullido" />
            sofoco <input type="checkbox" value="checksofoco" />
            dolorPelvis <input type="checkbox" value="checkdolorpelvis" />
            hinchazon <input type="checkbox" value="checkhinchazon" />
            estreñimiento <input type="checkbox" value="checkestreñimiento" />
            diarrea <input type="checkbox" value="checkdiarrea" />
            antojos <input type="checkbox" value="checkantojos" />
            dolorPorOvulacion <input type="checkbox" value="checkdolorporovulacion" />
            sangrado <input type="checkbox" value="checksangrado" />
            manchado <input type="checkbox" value="checkmanchado" />

            <hr>

            <h4>Tipo de Fluido</h4>
            seco <input type="checkbox" value="checkseco" />
            pegajoso <input type="checkbox" value="checkpegajoso" />
            cremoso <input type="checkbox" value="checkcremoso" />
            verde <input type="checkbox" value="checkverde" />
            conSangre <input type="checkbox" value="checkconSangre" />
            conMalOlor <input type="checkbox" value="checkconMalOlor" />

            <input type="submit" value="Registrar Datos">

        </div>
    </form>
</body>
</html>
