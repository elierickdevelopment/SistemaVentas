using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    internal class metodos_negocio
    {
       
        public Boolean ObtenerDatos(string consulta, ref DataSet ds)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=DESKTOP-88I6N9I;Initial Catalog=SistemaVentas;Integrated Security=True";

            using (SqlConnection conX = new SqlConnection(sqlConnection.ConnectionString))
            {
                SqlDataAdapter daConsulta = new SqlDataAdapter(consulta, conX);
                ds = new DataSet();
                daConsulta.Fill(ds, "0");
                return true;
            }
        }

        public void EjecutarQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=DESKTOP-88I6N9I;Initial Catalog=SistemaVentas;Integrated Security=True";

            SqlCommand comando = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            //EJECUTAMOS LA QUERY:
            comando.ExecuteNonQuery();
            sqlConnection.Close();
        }


    }
}
