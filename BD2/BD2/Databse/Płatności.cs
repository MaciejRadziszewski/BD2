using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2.Databse
{
    class Płatności
    {
        public int addNewPayment(double cost, string paymentMethod, int currentRideID)
        {
            using (SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.dodajPlatnosc", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Koszt", cost);
                cmd.Parameters.AddWithValue("@Typ_płatności", paymentMethod);
                cmd.Parameters.AddWithValue("@Kurs", currentRideID);
                cmd.ExecuteNonQuery();
                string queryGetIndex = "SELECT MAX(ID_płatności) FROM Płatności;";
                SqlCommand command = new SqlCommand(queryGetIndex, _connection);
                int paymentIndex = (int)command.ExecuteScalar();
                return paymentIndex;
            }
        }
    }
}
