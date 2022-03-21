using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Taksówki
    {
        public DataTable getDataDriver(int driverID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Kierowcy_WyswietlTaksowke", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kierowcy", driverID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
        public void addCab(string brand, string color, string numplate, int driver)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.dodajTaksowke", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Marka_samochodu", brand);
                cmd.Parameters.AddWithValue("@Kolor_samochodu", color);
                cmd.Parameters.AddWithValue("@Nr_rejestracji", numplate);
                cmd.Parameters.AddWithValue("@Akt_kierowca", driver);
                cmd.ExecuteNonQuery();
            }
        }
        public void editCab(int ID, string brand, string color, string numplate, int driver)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.edytujTaksowke", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_taksówki", ID);
                cmd.Parameters.AddWithValue("@Marka_samochodu", brand);
                cmd.Parameters.AddWithValue("@Kolor_samochodu", color);
                cmd.Parameters.AddWithValue("@Nr_rejestracji", numplate);
                cmd.Parameters.AddWithValue("@Akt_kierowca", driver);
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteCab(int ID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.usunTaksowke", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_taksówki", ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
