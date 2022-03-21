using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Kierowcy
    {
        public void addDriver(string name, string surname, string pesel, int salary, int area, int currentCab)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.dodajKierowce", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imię", name);
                cmd.Parameters.AddWithValue("@Nazwisko", surname);
                cmd.Parameters.AddWithValue("@Pesel", pesel);
                cmd.Parameters.AddWithValue("@Wypłata", salary);
                cmd.Parameters.AddWithValue("@Rejon", area);
                cmd.Parameters.AddWithValue("@Akt_taksówka", currentCab);
                cmd.ExecuteNonQuery();
            }
        }
        public void editDriver(int ID, string name, string surname, string pesel, int salary, int area, int currentCab)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.edytujKierowce", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kierowcy", ID);
                cmd.Parameters.AddWithValue("@Imię", name);
                cmd.Parameters.AddWithValue("@Nazwisko", surname);
                cmd.Parameters.AddWithValue("@Pesel", pesel);
                cmd.Parameters.AddWithValue("@Wypłata", salary);
                cmd.Parameters.AddWithValue("@Rejon", area);
                cmd.Parameters.AddWithValue("@Akt_taksówka", currentCab);
                cmd.ExecuteNonQuery();
            }
        }
        public void deleteDriver(int ID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.usunKierowce", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kierowcy", ID);
                cmd.ExecuteNonQuery();
            }
        }
        public int checkDriverLogin(string surname, string pesel)
        {
            //procedura do dodania!
            string queryGetClientID = "SELECT ID_kierowcy FROM Kierowcy WHERE Nazwisko = '" + surname + "' AND Pesel = '" + pesel + "';";
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(queryGetClientID, _connection);
                var clientID = command.ExecuteScalar();
                _connection.Close();
                if (clientID == null)
                {
                    return -1;
                }
                else return (int)clientID;
            }
        }

        internal DataTable getDriverData(int driverID)
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string query = "SELECT TOP 1 * FROM Kierowcy WHERE ID_kierowcy = " + driverID.ToString() + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int getTaxiID(int driverID)
        {
            //procedura do dodania!
            string queryGetClientID = "SELECT ID_taksówki FROM Taksówki WHERE Akt_kierowca = " + driverID + ";";
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(queryGetClientID, _connection);
                var taxiID = command.ExecuteScalar();
                _connection.Close();
                if (taxiID == null)
                {
                    return -1;
                }
                else return (int)taxiID;
            }
        }
    }
}
