using BD2.Databse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2.KierowcaGUI
{
    public partial class FormFinishRide : Form
    {
        private int driverID;
        private int currentRideID;
        private readonly Płatności płatności = new Płatności();
        private readonly Kursy kursy = new Kursy();
        public FormFinishRide(int driverID, int currentRideID)
        {
            this.driverID = driverID;
            this.currentRideID = currentRideID;
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEndRide_Click(object sender, EventArgs e)
        {
            if(textBoxDistance.Text != "" && textBoxCost.Text != "" && comboBoxPaymentType.SelectedIndex > -1)
            {
                try
                {
                    //dodajemy nową płatność
                    int paymentID = płatności.addNewPayment(double.Parse(textBoxCost.Text), comboBoxPaymentType.Text, currentRideID);
                    //edytujemy kurs
                    kursy.finishRide(currentRideID, float.Parse(textBoxDistance.Text), paymentID);
                    MessageBox.Show("Zakończono kurs!");
                    this.Close();
                }
                catch (SqlException error)
                {
                    Console.WriteLine(error.Message);
                    MessageBox.Show("Błąd w bazie danych");
                }
            }
            else
            {
                MessageBox.Show("Wypelnij dane");
            }
        }
    }
}
