using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Comando
    {
        private string _configConnection = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public DataTable ObjDataTable(string spName) {

            var dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_configConnection))
            {
                SqlCommand vComando = new SqlCommand();
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.CommandText = spName;
                vComando.Connection = con;

                using (var da = new SqlDataAdapter(vComando))
                {
                    con.Open();
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
