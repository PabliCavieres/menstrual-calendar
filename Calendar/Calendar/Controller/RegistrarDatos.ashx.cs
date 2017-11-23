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

                if (r.Inicio == checked(true)) {
                    r.Inicio = Boolean.Parse(context.Request.Params[0]);
                } else if (r.Inicio == checked(false)){
                    r.Inicio = Boolean.Parse(context.Request.Params[0]);
                }

            // r.Inicio = Boolean.Parse(context.Request.Params["checkinicio"]);

                if (r.Termino == checked(true)) {
                    r.Termino = Boolean.Parse(context.Request.Params[1]);
                } else if (r.Termino == checked(false)) {
                    r.Termino = Boolean.Parse(context.Request.Params[0]);
                }


                //r.Termino = Boolean.Parse(context.Request.Params["checktermino"]);

                r.Observacion = context.Request.Params["observacion"];
                r.MetodoAnticonceptivo = context.Request.Params["Metodo"];

                if (r.ActoSexual == checked(true)) {
                    r.ActoSexual = Boolean.Parse(context.Request.Params[1]);
                } else if (r.ActoSexual == checked(false)) {
                    r.ActoSexual = Boolean.Parse(context.Request.Params[0]);
                }

            // r.ActoSexual = Boolean.Parse(context.Request.Params["checkActosexual"]);

                if (r.Agotada == checked(true)) {
                    r.Agotada = Boolean.Parse(context.Request.Params[1]);
                } else if (r.Agotada == checked(false)) {
                    r.Agotada = Boolean.Parse(context.Request.Params[0]);
                }

            //r.Agotada = Boolean.Parse(context.Request.Params["checkagotada"]);

            if (r.Ansiosa == checked(true)) {
                r.Ansiosa = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Ansiosa == checked(false)) {
                r.Ansiosa = Boolean.Parse(context.Request.Params[0]);
            }

            //r.Ansiosa = Boolean.Parse(context.Request.Params["checkansiosa"]);

            if (r.Coqueta == checked(true)) {
                r.Coqueta = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Coqueta == checked(false)) {
                r.Coqueta = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Coqueta = Boolean.Parse(context.Request.Params["checkcoqueta"]);

            if (r.Deprimida == checked(true)) {
                r.Deprimida = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Deprimida == checked(false)) {
                r.Deprimida = Boolean.Parse(context.Request.Params[0]);
            }

            //r.Deprimida = Boolean.Parse(context.Request.Params["checkdeprimida"]);

            if (r.Enojada == checked(true)) {
                r.Enojada = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Enojada == checked(false)) {
                r.Enojada = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Enojada = Boolean.Parse(context.Request.Params["checkenojada"]);

            if (r.Nauseas == checked(true)) {
                r.Nauseas = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Nauseas == checked(false)) {
                r.Nauseas = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Nauseas = Boolean.Parse(context.Request.Params["checknauseas"]);

            if (r.Libidinosa == checked(true)) {
                r.Libidinosa = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Libidinosa == checked(false)) {
                r.Libidinosa = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Libidinosa = Boolean.Parse(context.Request.Params["checklibidinosa"]);

            if (r.Estres == checked(true)) {
                r.Estres = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Estres == checked(false)) {
                r.Estres = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Estres = Boolean.Parse(context.Request.Params["checkestres"]);

            if (r.Irritable == checked(true)) {
                r.Irritable = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Irritable == checked(false)) {
                r.Irritable = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Irritable = Boolean.Parse(context.Request.Params["checkirritable"]);

            if (r.Insomnio == checked(true)) {
                r.Insomnio = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Insomnio == checked(false)) {
                r.Insomnio = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Insomnio = Boolean.Parse(context.Request.Params["checkinsomnio"]);

            if (r.Rara == checked(true)) {
                r.Rara = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Rara == checked(false)) {
                r.Rara = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Rara = Boolean.Parse(context.Request.Params["checkrara"]);

            if (r.Sensible == checked(true)) {
                r.Sensible = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Sensible == checked(false)) {
                r.Sensible = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Sensible = Boolean.Parse(context.Request.Params["checksensible"]);

            if (r.DolorCabeza == checked(true)) {
                r.DolorCabeza = Boolean.Parse(context.Request.Params[1]);
            } else if (r.DolorCabeza == checked(false)) {
                r.DolorCabeza = Boolean.Parse(context.Request.Params[0]);
            }
            //r.DolorCabeza = Boolean.Parse(context.Request.Params["checkdolordecabeza"]);

            if (r.Migraña == checked(true)) {
                r.Migraña = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Migraña == checked(false)) {
                r.Migraña = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Migraña = Boolean.Parse(context.Request.Params["checkmigraña"]);

            if (r.DolorPechos == checked(true)) {
                r.DolorPechos = Boolean.Parse(context.Request.Params[1]);
            } else if (r.DolorPechos == checked(false)) {
                r.DolorPechos = Boolean.Parse(context.Request.Params[0]);
            }
            //r.DolorPechos = Boolean.Parse(context.Request.Params["checkdolorpechos"]);

            if (r.SensibilidadPechos == checked(true)) {
                r.SensibilidadPechos = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Libidinosa == checked(false)) {
                r.SensibilidadPechos = Boolean.Parse(context.Request.Params[0]);
            }
            //r.SensibilidadPechos = Boolean.Parse(context.Request.Params["checksensibilidadpechos"]);

            if (r.DolorLumbar == checked(true)) {
                r.DolorLumbar = Boolean.Parse(context.Request.Params[1]);
            } else if (r.DolorLumbar == checked(false)) {
                r.DolorLumbar = Boolean.Parse(context.Request.Params[0]);
            }
            //r.DolorLumbar = Boolean.Parse(context.Request.Params["checkdolorlumbar"]);

            if (r.Calambre == checked(true)) {
                r.Calambre = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Calambre == checked(false)) {
                r.Calambre = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Calambre = Boolean.Parse(context.Request.Params["checkcalambre"]);

            if (r.Escalosfrios == checked(true)) {
                r.Escalosfrios = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Escalosfrios == checked(false)) {
                r.Escalosfrios = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Escalosfrios = Boolean.Parse(context.Request.Params["checkescalofrios"]);

            if (r.Sarpullido == checked(true)) {
                r.Sarpullido = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Sarpullido == checked(false)) {
                r.Sarpullido = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Sarpullido = Boolean.Parse(context.Request.Params["checksarpullido"]);

            if (r.Sofoco == checked(true)) {
                r.Sofoco = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Sofoco == checked(false)) {
                r.Sofoco = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Sofoco = Boolean.Parse(context.Request.Params["checksofoco"]);

            if (r.DolorPelvis == checked(true)) {
                r.DolorPelvis = Boolean.Parse(context.Request.Params[1]);
            } else if (r.DolorPelvis == checked(false)) {
                r.DolorPelvis = Boolean.Parse(context.Request.Params[0]);
            }
            //r.DolorPelvis = Boolean.Parse(context.Request.Params["checkdolorpelvis"]);

            if (r.Hinchazon == checked(true)) {
                r.Hinchazon = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Hinchazon == checked(false)) {
                r.Hinchazon = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Hinchazon = Boolean.Parse(context.Request.Params["checkhinchazon"]);

            if (r.Estreñimiento == checked(true)) {
                r.Estreñimiento = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Estreñimiento == checked(false)) {
                r.Estreñimiento = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Estreñimiento = Boolean.Parse(context.Request.Params["checkestreñimiento"]);

            if (r.Diarrea == checked(true)) {
                r.Diarrea = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Diarrea == checked(false)) {
                r.Diarrea = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Diarrea = Boolean.Parse(context.Request.Params["checkdiarrea"]);

            if (r.Antojos == checked(true)) {
                r.Antojos = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Antojos == checked(false)) {
                r.Antojos = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Antojos = Boolean.Parse(context.Request.Params["checkantojos"]);

            if (r.DolorPorOvulacion == checked(true)) {
                r.DolorPorOvulacion = Boolean.Parse(context.Request.Params[1]);
            } else if (r.DolorPorOvulacion == checked(false)) {
                r.DolorPorOvulacion = Boolean.Parse(context.Request.Params[0]);
            }
            //r.DolorPorOvulacion = Boolean.Parse(context.Request.Params["checkdolorporovulacion"]);

            if (r.Sangrado == checked(true)) {
                r.Sangrado = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Sangrado == checked(false)) {
                r.Sangrado = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Sangrado = Boolean.Parse(context.Request.Params["checksangrado"]);

            if (r.Manchado == checked(true)) {
                r.Manchado = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Manchado == checked(false)) {
                r.Manchado = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Manchado = Boolean.Parse(context.Request.Params["checkmanchado"]);

            if (r.Seco == checked(true)) {
                r.Seco = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Seco == checked(false)) {
                r.Seco = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Seco = Boolean.Parse(context.Request.Params["checkseco"]);

            if (r.Pegajoso == checked(true)) {
                r.Pegajoso = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Pegajoso == checked(false)) {
                r.Pegajoso = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Pegajoso = Boolean.Parse(context.Request.Params["checkpegajoso"]);

            if (r.Cremoso == checked(true)) {
                r.Cremoso = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Cremoso == checked(false)) {
                r.Cremoso = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Cremoso = Boolean.Parse(context.Request.Params["checkcremoso"]);

            if (r.Verde == checked(true)) {
                r.Verde = Boolean.Parse(context.Request.Params[1]);
            } else if (r.Verde == checked(false)) {
                r.Verde = Boolean.Parse(context.Request.Params[0]);
            }
            //r.Verde = Boolean.Parse(context.Request.Params["checkverde"]);

            if (r.ConSangre == checked(true)) {
                r.ConSangre = Boolean.Parse(context.Request.Params[1]);
            } else if (r.ConSangre == checked(false)) {
                r.ConSangre = Boolean.Parse(context.Request.Params[0]);
            }
            //r.ConSangre = Boolean.Parse(context.Request.Params["checkconSangre"]);

            if (r.ConMalOlor == checked(true)) {
                r.ConMalOlor = Boolean.Parse(context.Request.Params[1]);
            } else if (r.ConMalOlor == checked(false)) {
                r.ConMalOlor = Boolean.Parse(context.Request.Params[0]);
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