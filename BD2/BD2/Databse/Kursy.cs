using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Kursy
    {
        public int checkClientCurrentRideID(int clientID)
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string queryGetClientID = "SELECT ID_kursu FROM Kursy WHERE Klient = " + clientID.ToString() +
                    "AND (Status_kursu =  'Aktywny' OR Status_kursu =  'Czeka na akceptację');";
                SqlCommand command = new SqlCommand(queryGetClientID, _connection);
                var rideID = command.ExecuteScalar();
                if (rideID == null)
                {
                    return -1;
                }
                else return (int)rideID;
            }
        }

        public DataTable getDriverRideHistory(int driverID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Kierowca_WyswietlKursy", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kierowcy", driverID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }

        public void finishRide(int currentRideID, float distance, int paymentID)
        {
            //procedura do dodania
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string helper = distance.ToString().Replace(",", ".");
                _connection.Open();
                string updateRide = "UPDATE Kursy SET Status_kursu = 'Zakończony', Dystans_km = " + helper +
                    ", Płatność =" + paymentID.ToString() + " WHERE ID_kursu = " + currentRideID.ToString();
                SqlCommand command = new SqlCommand(updateRide, _connection);
                command.ExecuteNonQuery();
            }
        }

        public DataTable getAvaiableRides()
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                //treść pytania które skierujemy do bazy danych
                string query = "SELECT * FROM Kursy WHERE  Status_kursu= 'Czeka na akceptację';";
                //tworzenie nowego obiektu klasy SqlDataAdapter, jako parametry przekazywane są pytanie do bazy danych i połączenie z bazą danych
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                //tworzenie nowego obiektu DataTable
                DataTable table = new DataTable();
                //wypełnienie tabeli
                adapter.Fill(table);
                //zwracamy wypełnioną tabelę
                return table;
            }
        }

        public int checkDriverCurrentRideID(int driverID)
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string queryGetClientID = "SELECT ID_kursu FROM Kursy WHERE Kierowca = " + driverID.ToString() + "AND Status_kursu = 'Aktywny';";
                SqlCommand command = new SqlCommand(queryGetClientID, _connection);
                var rideID = command.ExecuteScalar();
                if (rideID == null)
                {
                    return -1;
                }
                else return (int)rideID;
            }
        }

        public void acceptRide(int rideID, string start, string end, int clientID, int driverID, int taxiID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.edytujKurs", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_kursu", rideID);
                cmd.Parameters.AddWithValue("@Początek", start);
                cmd.Parameters.AddWithValue("@Koniec", end);
                cmd.Parameters.AddWithValue("@Dystans_km", DBNull.Value);
                cmd.Parameters.AddWithValue("@Status_kursu", "Aktywny");
                cmd.Parameters.AddWithValue("@Kierowca", driverID);
                cmd.Parameters.AddWithValue("@Klient", clientID);
                cmd.Parameters.AddWithValue("@Taksówka", taxiID);
                cmd.Parameters.AddWithValue("@Płatność", DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void addNewRide(int clientID, string start, string end)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.dodajKurs", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Początek", start);
                cmd.Parameters.AddWithValue("@Koniec", end);
                cmd.Parameters.AddWithValue("@Dystans_km", DBNull.Value);
                cmd.Parameters.AddWithValue("@Status_kursu", "Czeka na akceptację");
                cmd.Parameters.AddWithValue("@Kierowca", DBNull.Value);
                cmd.Parameters.AddWithValue("@Klient", clientID);
                cmd.Parameters.AddWithValue("@Taksówka", DBNull.Value);
                cmd.Parameters.AddWithValue("@Płatność", DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getRideData(int rideID)
        {
            //procedura do dodania!
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                //treść pytania które skierujemy do bazy danych
                string query = "SELECT TOP 1 * FROM Kursy WHERE ID_kursu = " + rideID.ToString() + ";";
                //tworzenie nowego obiektu klasy SqlDataAdapter, jako parametry przekazywane są pytanie do bazy danych i połączenie z bazą danych
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                //tworzenie nowego obiektu DataTable
                DataTable table = new DataTable();
                //wypełnienie tabeli
                adapter.Fill(table);
                //zwracamy wypełnioną tabelę
                return table;
            }
        }

        public DataTable getClientRideHistory(int clientID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("dbo.Klient_WyswietlKursy", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_klienta", clientID);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
    }
}
