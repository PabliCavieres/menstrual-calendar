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
        
        public Tips getTip(int id) {
            query = "SELECT * FROM tips WHERE id = " + id;
       
            con.Ejecutar(query);
            Tips tip = null;
            while (con.rs.Read()) {

                tip = new Tips();

                tip.Id = con.rs.GetInt32(0);
                tip.Descripcion = con.rs.GetString(1);

                
            }
            return tip;
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
                "'" + r.ConMalOlor + "', " +
                "'"+r.IdUsuario+"', " +
                " GETDATE())";
            con.Ejecutar(query);

        }

        public int getIdUsuario(String nombre) {
            query = "SELECT id FROM usuario where usser = " + nombre;
            Usuario u = null;
            con.Ejecutar(query);
            int id = 0;
            while (con.rs.Read()) {
                u = new Usuario();

                u.Id = con.rs.GetInt32(0);
                id = u.Id;
            }
            return id;

        }

        public List<Registro> getRegistro(int id) {
            query = "SELECT * FROM registro WHERE idUsuario = " + id;
            List<Registro> lista = new List<Registro>();
            con.Ejecutar(query);
            Registro r;
            while (con.rs.Read()) {

                r = new Registro();

                r.Id = con.rs.GetInt32(0);
                r.InicioOtermino = con.rs.GetString(1);
                r.Agotada = con.rs.GetInt32(2);
                r.Ansiosa = con.rs.GetInt32(3);
                r.Coqueta = con.rs.GetInt32(4);
                r.Deprimida = con.rs.GetInt32(5);
                r.Enojada = con.rs.GetInt32(6);
                r.Nauseas = con.rs.GetInt32(7);
                r.Libidinosa = con.rs.GetInt32(8);
                r.Estres = con.rs.GetInt32(9);
                r.Irritable = con.rs.GetInt32(10);
                r.Insomnio = con.rs.GetInt32(11);
                r.Rara = con.rs.GetInt32(12);
                r.Sensible = con.rs.GetInt32(13);
                r.DolorCabeza = con.rs.GetInt32(14);
                r.Migraña = con.rs.GetInt32(15);
                r.DolorPechos = con.rs.GetInt32(16);
                r.SensibilidadPechos = con.rs.GetInt32(17);
                r.DolorEspalda = con.rs.GetInt32(18);
                r.DolorLumbar = con.rs.GetInt32(19);
                r.Calambre = con.rs.GetInt32(20);
                r.Escalosfrios = con.rs.GetInt32(21);
                r.Sarpullido = con.rs.GetInt32(22);
                r.Sofoco = con.rs.GetInt32(23);
                r.DolorPelvis = con.rs.GetInt32(24);
                r.Hinchazon = con.rs.GetInt32(25);
                r.Estreñimiento = con.rs.GetInt32(26);
                r.Diarrea = con.rs.GetInt32(27);
                r.Antojos = con.rs.GetInt32(28);
                r.DolorPorOvulacion = con.rs.GetInt32(29);
                r.Sangrado = con.rs.GetInt32(30);
                r.Manchado = con.rs.GetInt32(32);
                r.Seco = con.rs.GetInt32(32);
                r.Pegajoso = con.rs.GetInt32(33);
                r.Cremoso = con.rs.GetInt32(34);
                r.Verde = con.rs.GetInt32(35);
                r.ConSangre = con.rs.GetInt32(36);
                r.ConMalOlor = con.rs.GetInt32(37);
                r.IdUsuario = con.rs.GetInt32(38);
                r.Fecha = con.rs.GetString(39);
                lista.Add(r);
            }
            return lista;
        }
    }
}