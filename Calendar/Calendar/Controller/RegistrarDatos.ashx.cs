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

            int idForm = int.Parse(context.Request.Params["checkForm"]);
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}