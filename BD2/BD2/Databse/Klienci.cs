using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Klienci
    {

        public int checkClientLogin(String surname, int phoneNumber)
        {
            //procedura do dodania!
            string queryGetClientID = "SELECT ID_klienta FROM Klienci WHERE Nazwisko = '" + surname + "' AND Nr_telefonu = " + phoneNumber.ToString() + ";";
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

        public void addClient(string name, string surname, int phoneNumber)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.dodajKlienta", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imię", name);
                cmd.Parameters.AddWithValue("@Nazwisko", surname);
                cmd.Parameters.AddWithValue("@Nr_telefonu", phoneNumber);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getClientData(int clientID)
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string query = "SELECT TOP 1 * FROM Klienci WHERE ID_klienta = " + clientID.ToString() + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void editClient(int clientID, string name, string surname, int phoneNumber)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.edytujKlienta", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_klienta", clientID);
                cmd.Parameters.AddWithValue("@Imię", name);
                cmd.Parameters.AddWithValue("@Nazwisko", surname);
                cmd.Parameters.AddWithValue("@Nr_telefonu", phoneNumber);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
