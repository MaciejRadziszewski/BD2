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
    public partial class FormAcceptRide : Form
    {
        private int driverID;
        private int taxiID;
        private readonly Kursy kursy = new Kursy();

        public FormAcceptRide(int driverID, int taxiID)
        {
            this.driverID = driverID;
            this.taxiID = taxiID;
            InitializeComponent();
            try
            {
                DataTable availableRides = kursy.getAvaiableRides();
                if (availableRides.Rows.Count > 0) dataGridViewAvailableRides.DataSource = availableRides;
                else
                {
                    dataGridViewAvailableRides.Visible = false;
                    labelAvailableRides.Text = labelAvailableRides.Text + " BRAK";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
            
        }

        private void buttonAcceptRide_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvailableRides.SelectedRows.Count > 0)
            {
                //wybranie pierwszego zaznaczonego wiersza
                DataGridViewRow row = dataGridViewAvailableRides.SelectedRows[0];
                //id kursu nie zmieniamy
                int rideID = int.Parse(row.Cells[0].Value.ToString());
                //start nie zmienamy
                string start = row.Cells[1].Value.ToString();
                //koniec nie zmieniamy
                string end = row.Cells[2].Value.ToString();
                int clientID = int.Parse(row.Cells[6].Value.ToString());
                //dystansu nie zmieniamy
                //statusu nie chcemy zmieniac
                //id kierowcy i id taksowki jest podane
                //platnosc stworzymy potem 
                kursy.acceptRide(rideID, start, end, clientID, driverID, taxiID);
                MessageBox.Show("Zaakceptowano kurs!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz kurs");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
