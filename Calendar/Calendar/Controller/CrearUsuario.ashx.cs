using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Calendar.Model;
using System.Web.SessionState;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de CrearUsuario
    /// </summary>
    public class CrearUsuario:IHttpHandler, IRequiresSessionState {
        
        public void ProcessRequest(HttpContext context ) {
            Data d = new Data();

            Usuario nuevo = new Usuario();

            nuevo.Usser = context.Request.Params["txtNomUsuario"];
            nuevo.Pass = context.Request.Params["txtContrasenia"];
            nuevo.Sesion = false;

            d.crearUsuario(nuevo);
            
            context.Response.Redirect("../View/Index.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}