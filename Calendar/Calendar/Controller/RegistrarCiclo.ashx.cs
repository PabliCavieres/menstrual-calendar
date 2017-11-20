using Calendar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de RegistrarCiclo
    /// </summary>
    public class RegistrarCiclo:IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            FichaPeriodo fp = new FichaPeriodo();
            Data d = new Data();


            fp.fechaPeriodo = DateTime.Parse(context.Request.Params["fechaUltimaRegla"]);
            fp.DuracionCiclo = int.Parse(context.Request.Params["duracionCiclo"]);
            fp.DuracionPeriodo = int.Parse(context.Request.Params["duracionPeriodo"]);

            d.crearRegistro(fp);

            context.Response.Redirect("../View/Calendario.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}