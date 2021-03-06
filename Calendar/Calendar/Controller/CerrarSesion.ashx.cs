﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Calendar.Controller {
    /// <summary>
    /// Descripción breve de CerrarSesion
    /// </summary>
    public class CerrarSesion:IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {
            context.Session.RemoveAll();
            context.Response.Redirect("../View/Index.aspx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}