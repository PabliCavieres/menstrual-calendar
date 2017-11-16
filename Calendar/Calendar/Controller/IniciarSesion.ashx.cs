using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

using Calendar.Model;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de IniciarSesion
    /// </summary>
    public class IniciarSesion:IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {

            String nombreUsuario = context.Request.Params["txtUsuarioInicio"];
            String passUsuario = context.Request.Params["txtContraseñaInicio"];

            Data d = new Data();
            
            Usuario u = d.getUsuario(nombreUsuario, passUsuario);

            if(u == null){
                context.Session["error"] = "Usuario no encontrado";
                context.Response.Redirect("../View/Error.aspx");
            }else{
                context.Session["nombreUsuario"] = u.Usser;
                context.Session["txtContraseñaInicio"] = u.Pass;
                context.Response.Redirect("../View/Menu.aspx");
            } 
             
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}