using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Zarzad
    {
        public int checkMenagerLogin(String surname, String pesel)
        {
            //procedura do dodania!
            string queryGetMenagerID = "SELECT ID_zarządcy FROM Zarząd WHERE Nazwisko = '" + surname + "' AND Pesel = " + pesel + ";";
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(queryGetMenagerID, _connection);
                var menagerID = command.ExecuteScalar();
                _connection.Close();
                if (menagerID == null)
                {
                    return -1;
                }
                else return (int)menagerID;
            }
        }

        public DataTable viewDrivers(int menagerID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Zarzadca_WyswietlKierowcow", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_zarzadcy", menagerID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable viewArea(int menagerID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Zarzadca_WyswietlRejon", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_zarzadcy", menagerID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable viewCabs(int menagerID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Zarzadca_WyswietlTaksowki", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_zarzadcy", menagerID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable viewRides(int menagerID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Zarzadca_WyswietlKursy", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_zarzadcy", menagerID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
    }
}
