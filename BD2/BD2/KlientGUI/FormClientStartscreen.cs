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

namespace BD2.KlientGUI
{
    public partial class FormClientStartscreen : Form
    {
        private int clientID;
        bool thereIsACurrentRide = false;
        private readonly Kursy kursy = new Kursy();
        public FormClientStartscreen(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            try
            {
                int clientRideID = kursy.checkClientCurrentRideID(clientID);
                if (clientRideID == -1)
                {
                    dataGridViewRideData.Visible = false;
                    labelCurrentRide.Text = "BRAK AKTUALNEGO KURSU";
                    thereIsACurrentRide = false;
                }
                else
                {
                    DataTable currentRideData = kursy.getRideData(clientRideID);
                    dataGridViewRideData.DataSource = currentRideData;
                    thereIsACurrentRide = true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonCreateNewRide_Click(object sender, EventArgs e)
        {
            if (thereIsACurrentRide) MessageBox.Show("Nie możesz zamówić nowego kursu przed zakończeniem obecnego!");
            else
            {
                FormNewRide newForm = new FormNewRide(clientID);
                newForm.StartPosition = FormStartPosition.Manual;
                newForm.Location = this.Location;
                newForm.Show();
                newForm.Closed += (s, args) => this.Show();
                this.Hide();
            }
        }

        private void buttonViewRideHistory_Click(object sender, EventArgs e)
        {
            FormClientHistory newForm = new FormClientHistory(clientID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            FormClientData newForm = new FormClientData(clientID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientStartscreen_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                int clientRideID = kursy.checkClientCurrentRideID(clientID);
                if (clientRideID == -1)
                {
                    dataGridViewRideData.Visible = false;
                    labelCurrentRide.Text = "BRAK AKTUALNEGO KURSU";
                    thereIsACurrentRide = false;
                    //MessageBox.Show("Brak kursu essa!");
                }
                else
                {
                    DataTable currentRideData = kursy.getRideData(clientRideID);
                    dataGridViewRideData.DataSource = currentRideData;
                    dataGridViewRideData.Visible = true;
                    labelCurrentRide.Text = "AKTUALNY KURS: ";
                    thereIsACurrentRide = true;
                    //MessageBox.Show("Jest kurs!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
            labelCurrentRide.Refresh();
            dataGridViewRideData.Refresh();
        }
    }
}
