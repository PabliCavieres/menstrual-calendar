using System;
using System.Collections.Generic;

namespace Calendar.Model {
    public class Data {

        private Conexion con;
        private String query;

        public Data() {
            con = new Conexion("calendario_bd");
        }

        public void crearUsuario(Usuario u) {
            query = "INSERT INTO usuario VALUES('" + u.Usser + "', '" + u.Pass + "', '" + u.Sesion + "');";
            con.Ejecutar(query);
        }


        public void SesionUsuario(int id) {
            query = "UPDATE usuario SET sesion = 1 WHERE id = "+id;
            con.Ejecutar(query);
            
        }

        public void crearRegistro(FichaPeriodo f) {
            query = "INSERT INTO fichaPeriodoInicio VALUES('" + f.FechaPeriodo + "', '" + f.duracionCiclo + "', '" + f.duracionPeriodo + "');";
            con.Ejecutar(query);
        }

        public Usuario getUsuario(String nombreUsuario, String passUsuario) {

            query = "SELECT * FROM usuario where usser = '" + nombreUsuario + "' and pass = '"+passUsuario+"'";
            Usuario u = null;
            con.Ejecutar(query);
            while (con.rs.Read()) {
                u = new Usuario();

                u.Id = con.rs.GetInt32(0);
                u.Usser = con.rs.GetString(1);
                u.Pass = con.rs.GetString(2);
                u.Sesion = con.rs.GetBoolean(3);
            }
            return u;
        }

        //Metodo de buscar usuario. Hace sueñoS

        public List<Tips> getTip(int id) {
            query = "SELECT * FROM tips WHERE id = " + id;
            List<Tips> lista = new List<Tips>();
            con.Ejecutar(query);
            Tips tip;
            while (con.rs.Read()) {

                tip = new Tips();

                tip.Id = con.rs.GetInt32(0);
                tip.Descripcion = con.rs.GetString(1);

                lista.Add(tip);
            }
            return lista;
        }

        public void RegistrarChecks(Registro r) {
            query = "INSERT INTO registro VALUES( " +
                "'" + r.InicioOtermino + "', " +
                "'" + r.Observacion + "', " +
                "'" + r.MetodoAnticonceptivo + "', " +
                "'" + r.ActoSexual + "', " +
                "'" + r.Agotada + "', " +
                "'" + r.Ansiosa + "', " +
                "'" + r.Coqueta + "', " +
                "'" + r.Deprimida + "', " +
                "'" + r.Enojada + "', " +
                "'" + r.Nauseas + "', " +
                "'" + r.Libidinosa + "', " +
                "'" + r.Estres + "', " +
                "'" + r.Irritable + "', " +
                "'" + r.Insomnio + "', " +
                "'" + r.Rara + "', " +
                "'" + r.Sensible + "', " +
                "'" + r.DolorCabeza + "', " +
                "'" + r .Migraña + "', " +
                "'" + r.DolorPechos + "', " +
                "'" + r.SensibilidadPechos + "', " +
                "'" + r.DolorEspalda + "', " +
                "'" + r.DolorLumbar + "', " +
                "'" + r.Calambre + "', " +
                "'" + r.Escalosfrios + "', " +
                "'" + r.Sarpullido + "', " +
                "'" + r.Sofoco + "', " +
                "'" + r.DolorPelvis + "', " +
                "'" + r.Hinchazon + "', " +
                "'" + r.Estreñimiento + "', " +
                "'" + r.Diarrea + "', " +
                "'" + r.Antojos + "', " +
                "'" + r.DolorPorOvulacion + "', " +
                "'" + r.Sangrado + "', " +
                "'" + r.Manchado + "', " +
                "'" + r.Seco + "', " +
                "'" + r.Pegajoso + "', " +
                "'" + r.Cremoso + "', " +
                "'" + r.Verde + "', " +
                "'" + r.ConSangre + "', " +
                "'" + r.ConMalOlor + "') ";
            con.Ejecutar(query);

        }
    }
}