using System;

/*imports*/
using System.Data;
using System.Data.SqlClient;
/*imports*/

namespace Calendar.Model{

    public class Conexion {

        private SqlConnection con; // Connection
        private SqlCommand sen; // Statement
        public SqlDataReader rs; // ResultSet

        public Conexion(String bd) {

            /* con = new SqlConnection(
                      "Data Source=LAPTOP-NVBBT3RA\\SQLEXPRESS;" +
                      "Initial Catalog=" + bd + "; " +
                      "User id=sa; " +
                      "Password=;"
                  );


              Autenticación de windows*/
            // DESKTOP - TC26VSD\\SQLEXPRESS LAPTOP-65BDVNLT\\BERNY

            con = new SqlConnection("server= LAPTOP-65BDVNLT\\BERNY;" +
                                      "database=calendario_bd;" +
                                      "Integrated Security=true;");
            
              // url de conexión

        }

        public void Ejecutar(String query) {
            Console.WriteLine("QUERY=" + query);

            con.Open();
            sen = new SqlCommand(query, con);
            
            if (query.ToLower().Contains("select")) {
                rs = sen.ExecuteReader();
            } else { //insert, update, delete
                sen.ExecuteNonQuery();
                Cerrar();
            }
        }

        public void Cerrar() {
            con.Close();
        }

    }
}