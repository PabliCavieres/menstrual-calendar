using Calendar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de RegistrarDatos
    /// </summary>
    public class RegistrarDatos:IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Registro r = new Registro();
            Data d = new Data();

            r.Inicio = Boolean.Parse(context.Request.Params["checkinicio"]);
            r.Termino = Boolean.Parse(context.Request.Params["checktermino"]);
            r.Observacion = context.Request.Params["observacion"];
            r.MetodoAnticonceptivo = Boolean.Parse(context.Request.Params["Metodo"]);
            r.ActoSexual = Boolean.Parse(context.Request.Params["checkactosexual"]);
            r.Agotada = Boolean.Parse(context.Request.Params["checkagotada"]);
            r.Ansiosa = Boolean.Parse(context.Request.Params["checkansiosa"]);
            r.Coqueta = Boolean.Parse(context.Request.Params["checkcoqueta"]);
            r.Deprimida = Boolean.Parse(context.Request.Params["checkdeprimida"]);
            r.Enojada = Boolean.Parse(context.Request.Params["checkenojada"]);
            r.Nauseas = Boolean.Parse(context.Request.Params["checknauseas"]);
            r.Libidinosa = Boolean.Parse(context.Request.Params["checklibidinosa"]);
            r.Estres = Boolean.Parse(context.Request.Params["checkestres"]);
            r.Irritable = Boolean.Parse(context.Request.Params["checkirritable"]);
            r.Insomnio = Boolean.Parse(context.Request.Params["checkinsomnio"]);
            r.Rara = Boolean.Parse(context.Request.Params["checkrara"]);
            r.Sensible = Boolean.Parse(context.Request.Params["checksensible"]);
            r.DolorCabeza = Boolean.Parse(context.Request.Params["checkdolordecabeza"]);
            r.Migraña = Boolean.Parse(context.Request.Params["checkmigraña"]);
            r.DolorPechos = Boolean.Parse(context.Request.Params["checkdolorpechos"]);
            r.SensibilidadPechos = Boolean.Parse(context.Request.Params["checksensibilidadpechos"]);
            r.DolorLumbar = Boolean.Parse(context.Request.Params["checkdolorlumbar"]);
            r.Calambre = Boolean.Parse(context.Request.Params["checkcalambre"]);
            r.Escalosfrios = Boolean.Parse(context.Request.Params["checkescalosfrios"]);
            r.Sarpullido = Boolean.Parse(context.Request.Params["checksarpullido"]);
            r.Sofoco = Boolean.Parse(context.Request.Params["checksofoco"]);
            r.DolorPelvis = Boolean.Parse(context.Request.Params["checkdolorpelvis"]);
            r.Hinchazon = Boolean.Parse(context.Request.Params["checkhinchazon"]);
            r.Estreñimiento = Boolean.Parse(context.Request.Params["checkestreñimiento"]);
            r.Diarrea = Boolean.Parse(context.Request.Params["checkdiarrea"]);
            r.Antojos = Boolean.Parse(context.Request.Params["checkantojos"]);
            r.DolorPorOvulacion = Boolean.Parse(context.Request.Params["checkdolorporovulacion"]);
            r.Sangrado = Boolean.Parse(context.Request.Params["checksangrado"]);
            r.Manchado = Boolean.Parse(context.Request.Params["checkmanchado"]);
            r.Seco = Boolean.Parse(context.Request.Params["checkseco"]);
            r.Pegajoso = Boolean.Parse(context.Request.Params["checkpegajoso"]);
            r.Cremoso = Boolean.Parse(context.Request.Params["checkcremoso"]);
            r.Verde = Boolean.Parse(context.Request.Params["checkverde"]);
            r.ConSangre = Boolean.Parse(context.Request.Params["checkconSangre"]);
            r.ConMalOlor = Boolean.Parse(context.Request.Params["checkconMalOlor"]);
             

            d.RegistrarChecks(r);

            context.Response.Redirect("../View/Calendario.aspx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}