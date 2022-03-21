using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Rejony
    {
        public DataTable getDataDriver(int driverID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Kierowcy_WyswietlRejon", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kierowcy", driverID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
        public void editArea(int ID, string name, int surface, int price)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.edytujRejon", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_rejonu", ID);
                cmd.Parameters.AddWithValue("@Nazwa_rejonu", name);
                cmd.Parameters.AddWithValue("@Powierzchnia", surface);
                cmd.Parameters.AddWithValue("@Cena_za_km", price);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
