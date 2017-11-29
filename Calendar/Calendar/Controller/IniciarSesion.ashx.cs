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

            try {
                String nombreUsuario = context.Request.Params["txtUsuarioInicio"];
                String passUsuario = context.Request.Params["txtContraseñaInicio"];


                Data d = new Data();

                Usuario u = d.getUsuario(nombreUsuario, passUsuario);

                if (u == null) {                 
                    context.Session["error"] = "Usuario no encontrado";
                    context.Response.Redirect("../View/Error.aspx");
                    
                } else {                 
                    context.Session["txtUsuarioInicio"] = u.Usser;
                    context.Session["txtContraseñaInicio"] = u.Pass;
                    
                    if (u.Sesion == false) {
                        //d.SesionUsuario(u.Id);
                        u.Sesion = true;
                        context.Response.Redirect("../View/Menu.aspx");
                    } else if(u.Sesion == true) {
                        context.Response.Redirect("../View/Calendario.aspx");
                    }


                    
                        
                    
                }
            } catch (Exception e) {

                context.Response.Write("Error"+e);
            }
             
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}