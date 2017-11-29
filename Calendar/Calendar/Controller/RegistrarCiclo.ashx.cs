using Calendar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de RegistrarCiclo
    /// </summary>
    public class RegistrarCiclo:IHttpHandler ,IRequiresSessionState{

        public void ProcessRequest(HttpContext context) {

            try {
                FichaPeriodo fp = new FichaPeriodo();
                Data d = new Data();


                fp.fechaPeriodo = DateTime.Parse(context.Request.Params["fechaUltimaRegla"]);
                fp.DuracionCiclo = int.Parse(context.Request.Params["duracionCiclo"]);
                fp.DuracionPeriodo = int.Parse(context.Request.Params["duracionPeriodo"]);

                d.crearRegistro(fp);

                context.Session["fechaUltimaRegla"] = fp.FechaPeriodo;
                context.Session["duracionCiclo"] = fp.DuracionCiclo;

                context.Response.Redirect("../View/Calendario.aspx");
            } catch (Exception) {

                throw;
            }

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}