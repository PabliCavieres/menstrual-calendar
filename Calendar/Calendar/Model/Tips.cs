using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Model {
    public class Tips {

        private int id;
        private String descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Tips() {
        }
    }
}