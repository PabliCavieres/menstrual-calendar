using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Model {
    public class Usuario {

        private int id;
        private String usser;
        private String pass;



        public Usuario() {
        }

        public int Id { get => id; set => id = value; }
        public string Usser { get => usser; set => usser = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}