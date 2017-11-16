using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de CerrarSesion
    /// </summary>
    public class CerrarSesion:IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "texto/normal";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}