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

            r.InicioOtermino = context.Request.Params["checkinicio"];
            r.Observacion = context.Request.Params["observacion"];
            r.MetodoAnticonceptivo = context.Request.Params["Metodo"];

            string checkSexual = context.Request.Params["checkActosexual"];
            if (checkSexual == "true") {
                r.ActoSexual = 1;
            }
            else if (checkSexual == null) {
                r.ActoSexual = 0;
            }

            // r.ActoSexual = Boolean.Parse(context.Request.Params["checkActosexual"]);
            string checkagotada = context.Request.Params["checkagotada"];
            if (checkagotada == "true") {
                    r.Agotada = 1;
                } else if (checkagotada == null) {
                    r.Agotada = 0;
                }

            //r.Agotada = Boolean.Parse(context.Request.Params["checkagotada"]);
            string checkAnsionsa = context.Request.Params["checkansiosa"];
            if (checkAnsionsa == "true") {
                r.Ansiosa = 1;
            } else if (checkAnsionsa == null) {
                r.Ansiosa = 0;
            }

            //r.Ansiosa = Boolean.Parse(context.Request.Params["checkansiosa"]);

            String checkcoqueta = context.Request.Params["checkcoqueta"];
            if (checkcoqueta == "true") {
                r.Coqueta = 1;
            } else if (checkcoqueta == null) {
                r.Coqueta = 0;
            }
            //r.Coqueta = Boolean.Parse(context.Request.Params["checkcoqueta"]);

            string checkDeprimida = context.Request.Params["checkdeprimida"];
            if (checkDeprimida == "true") {
                r.Deprimida = 1;
            } else if (checkDeprimida == null) {
                r.Deprimida = 0;
            }

            //r.Deprimida = Boolean.Parse(context.Request.Params["checkdeprimida"]);

            string checkEnojada = context.Request.Params["checkenojada"];
            if (checkEnojada == "true") {
                r.Enojada = 1;
            } else if (checkEnojada == null) {
                r.Enojada = 0;
            }
            //r.Enojada = Boolean.Parse(context.Request.Params["checkenojada"]);

            string checkNauseas = context.Request.Params["checknauseas"];
            if (checkNauseas == "true") {
                r.Nauseas = 1;
            } else if (checkNauseas == null) {
                r.Nauseas = 0;
            }
            //r.Nauseas = Boolean.Parse(context.Request.Params["checknauseas"]);

            string checkLibidinosa = context.Request.Params["checklibidinosa"];
            if (checkLibidinosa == "true") {
                r.Libidinosa = 1;
            } else if (checkLibidinosa == null) {
                r.Libidinosa = 0;
            }
            //r.Libidinosa = Boolean.Parse(context.Request.Params["checklibidinosa"]);

            string checkEstres = context.Request.Params["checkestres"];
            if (checkEstres == "true") {
                r.Estres = 1;
            } else if (checkEstres == null) {
                r.Estres = 0;
            }
            //r.Estres = Boolean.Parse(context.Request.Params["checkestres"]);

            string checkIrritable = context.Request.Params["checkirritable"];
            if (checkIrritable == "true") {
                r.Irritable = 1;
            } else if (checkIrritable == null) {
                r.Irritable = 0;
            }
            //r.Irritable = Boolean.Parse(context.Request.Params["checkirritable"]);

            string checkInsomnio = context.Request.Params["checkinsomnio"];
            if (checkInsomnio == "true") {
                r.Insomnio = 1;
            } else if (checkInsomnio == null) {
                r.Insomnio = 0;
            }
            //r.Insomnio = Boolean.Parse(context.Request.Params["checkinsomnio"]);

            string checkRara = context.Request.Params["checkrara"];
            if (checkRara == "true") {
                r.Rara = 1;
            } else if (checkRara == null) {
                r.Rara = 0;
            }
            //r.Rara = Boolean.Parse(context.Request.Params["checkrara"]);

            string checkSensible = context.Request.Params["checksensible"];
            if (checkSensible == "true") {
                r.Sensible = 1;
            } else if (checkSensible == null) {
                r.Sensible = 0;
            }
            //r.Sensible = Boolean.Parse(context.Request.Params["checksensible"]);

            string checkDolorCabeza = context.Request.Params["checkdolordecabeza"];
            if (checkDolorCabeza == "true") {
                r.DolorCabeza = 1;
            } else if (checkDolorCabeza == null) {
                r.DolorCabeza = 0;
            }
            //r.DolorCabeza = Boolean.Parse(context.Request.Params["checkdolordecabeza"]);

            string checkMigraña = context.Request.Params["checkmigraña"];
            if (checkMigraña == "true") {
                r.Migraña = 1;
            } else if (checkMigraña == null) {
                r.Migraña = 0;
            }
            //r.Migraña = Boolean.Parse(context.Request.Params["checkmigraña"]);

            string checkDolorpeshos = context.Request.Params["checkdolorpechos"];
            if (checkDolorpeshos == "true") {
                r.DolorPechos = 1;
            } else if (checkDolorpeshos == null) {
                r.DolorPechos = 0;
            }
            //r.DolorPechos = Boolean.Parse(context.Request.Params["checkdolorpechos"]);

            string checkSensibilidadPeshos = context.Request.Params["checksensibilidadpechos"];
            if (checkSensibilidadPeshos == "true") {
                r.SensibilidadPechos = 1;
            } else if (checkSensibilidadPeshos == null) {
                r.SensibilidadPechos = 0;
            }
            //r.SensibilidadPechos = Boolean.Parse(context.Request.Params["checksensibilidadpechos"]);

            string checkDolorLumbar = context.Request.Params["checkdolorlumbar"];
            if (checkDolorLumbar == "true") {
                r.DolorLumbar = 1;
            } else if (checkDolorLumbar == null) {
                r.DolorLumbar = 0;
            }
            //r.DolorLumbar = Boolean.Parse(context.Request.Params["checkdolorlumbar"]);

            string checkCalambre = context.Request.Params["checkcalambre"];
            if (checkCalambre == "true") {
                r.Calambre = 1;
            } else if (checkCalambre == null) {
                r.Calambre = 0;
            }
            //r.Calambre = Boolean.Parse(context.Request.Params["checkcalambre"]);

            string checkEscalosfrios = context.Request.Params["checkescalofrios"];
            if (checkEscalosfrios == "true") {
                r.Escalosfrios = 1;
            } else if (checkEscalosfrios == null) {
                r.Escalosfrios = 0;
            }
            //r.Escalosfrios = Boolean.Parse(context.Request.Params["checkescalofrios"]);

            string checkSarpullidos = context.Request.Params["checksarpullido"];
            if (checkSarpullidos == "true") {
                r.Sarpullido = 1;
            } else if (checkSarpullidos == null) {
                r.Sarpullido = 0;
            }
            //r.Sarpullido = Boolean.Parse(context.Request.Params["checksarpullido"]);

            string checkSofoco = context.Request.Params["checksofoco"];
            if (checkSofoco == "true") {
                r.Sofoco = 1;
            } else if (checkSofoco == null) {
                r.Sofoco = 0;
            }
            //r.Sofoco = Boolean.Parse(context.Request.Params["checksofoco"]);

            string checkDolorPelvis = context.Request.Params["checkdolorpelvis"];
            if (checkDolorPelvis == "true") {
                r.DolorPelvis = 1;
            } else if (checkDolorPelvis == null) {
                r.DolorPelvis = 0;
            }
            //r.DolorPelvis = Boolean.Parse(context.Request.Params["checkdolorpelvis"]);

            string checkHinchazon = context.Request.Params["checkhinchazon"];
            if (checkHinchazon == "true") {
                r.Hinchazon = 1;
            } else if (checkHinchazon == null) {
                r.Hinchazon = 0;
            }
            //r.Hinchazon = Boolean.Parse(context.Request.Params["checkhinchazon"]);

            string checkEstreñimiento = context.Request.Params["checkestreñimiento"];
            if (checkEstreñimiento == "true") {
                r.Estreñimiento = 1;
            } else if (checkEstreñimiento == null) {
                r.Estreñimiento = 0;
            }
            //r.Estreñimiento = Boolean.Parse(context.Request.Params["checkestreñimiento"]);

            string checkDiarrea = context.Request.Params["checkdiarrea"];
            if (checkDiarrea == "true") {
                r.Diarrea = 1;
            } else if (checkDiarrea == null) {
                r.Diarrea = 0;
            }
            //r.Diarrea = Boolean.Parse(context.Request.Params["checkdiarrea"]);

            string checkAnteojos = context.Request.Params["checkantojos"];
            if (checkAnteojos == "true") {
                r.Antojos = 1;
            } else if (checkAnteojos == null) {
                r.Antojos = 0;
            }
            //r.Antojos = Boolean.Parse(context.Request.Params["checkantojos"]);

            string checkDolorOvulacion = context.Request.Params["checkdolorporovulacion"];
            if (checkDolorOvulacion == "true") {
                r.DolorPorOvulacion = 1;
            } else if (checkDolorOvulacion == null) {
                r.DolorPorOvulacion = 0;
            }
            //r.DolorPorOvulacion = Boolean.Parse(context.Request.Params["checkdolorporovulacion"]);

            string checkSangrado = context.Request.Params["checksangrado"];
            if (checkSangrado == "true") {
                r.Sangrado = 1;
            } else if (checkSangrado == null) {
                r.Sangrado = 0;
            }
            //r.Sangrado = Boolean.Parse(context.Request.Params["checksangrado"]);

            string checkManchado = context.Request.Params["checkmanchado"];
            if (checkManchado == "true") {
                r.Manchado = 1;
            } else if (checkManchado == null) {
                r.Manchado = 0;
            }
            //r.Manchado = Boolean.Parse(context.Request.Params["checkmanchado"]);

            string checkSeco = context.Request.Params["checkseco"];
            if (checkSeco == "true") {
                r.Seco = 1;
            } else if (checkSeco == null) {
                r.Seco = 0;
            }
            //r.Seco = Boolean.Parse(context.Request.Params["checkseco"]);

            string checkPegajoso = context.Request.Params["checkpegajoso"];
            if (checkPegajoso == "true") {
                r.Pegajoso = 1;
            } else if (checkPegajoso == null) {
                r.Pegajoso = 0;
            }
            //r.Pegajoso = Boolean.Parse(context.Request.Params["checkpegajoso"]);

            string checkCremoso = context.Request.Params["checkcremoso"];
            if (checkCremoso == "true") {
                r.Cremoso = 1;
            } else if (checkCremoso == null) {
                r.Cremoso = 0;
            }
            //r.Cremoso = Boolean.Parse(context.Request.Params["checkcremoso"]);

            string checkVerde = context.Request.Params["checkverde"];
            if (checkVerde == "true") {
                r.Verde = 1;
            } else if (checkVerde == null) {
                r.Verde = 0;
            }
            //r.Verde = Boolean.Parse(context.Request.Params["checkverde"]);

            string checkConSangre = context.Request.Params["checkconSangre"];
            if (checkConSangre == "true") {
                r.ConSangre = 1;
            } else if (checkConSangre == null) {
                r.ConSangre = 0;
            }
            //r.ConSangre = Boolean.Parse(context.Request.Params["checkconSangre"]);

            string checkMalOlor = context.Request.Params["checkconMalOlor"];
            if (checkMalOlor == "true") {
                r.ConMalOlor = 1;
            } else if (checkMalOlor == null) {
                r.ConMalOlor = 0;
            }
            //r.ConMalOlor = Boolean.Parse(context.Request.Params["checkconMalOlor"]);

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