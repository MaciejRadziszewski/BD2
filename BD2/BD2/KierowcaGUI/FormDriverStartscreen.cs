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
    public partial class FormDriverStartscreen : Form
    {
        private readonly int driverID;
        private int taxiID;
        private bool thereIsACurrentRide;
        private int currentRideID;
        private readonly Kierowcy kierowcy = new Kierowcy();
        private readonly Kursy kursy = new Kursy();
        public FormDriverStartscreen(int driverID)
        {
            this.driverID = driverID;
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeeData_Click(object sender, EventArgs e)
        {
            FormDriverData newForm = new FormDriverData(driverID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonDistrictData_Click(object sender, EventArgs e)
        {
            FormDistrictData newForm = new FormDistrictData(driverID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonTaxiData_Click(object sender, EventArgs e)
        {
            FormTaxiData newForm = new FormTaxiData(driverID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonViewRideHistory_Click(object sender, EventArgs e)
        {
            FormDriverHistory newForm = new FormDriverHistory(driverID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonFinishRide_Click(object sender, EventArgs e)
        {
            if (thereIsACurrentRide)
            {
                FormFinishRide newForm = new FormFinishRide(driverID, currentRideID);
                newForm.StartPosition = FormStartPosition.Manual;
                newForm.Location = this.Location;
                newForm.Show();
                newForm.Closed += (s, args) => this.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz aktualnego kursu");
            }
        }

        private void buttonSeeAvaiableRides_Click(object sender, EventArgs e)
        {
            if (!thereIsACurrentRide)
            {
                FormAcceptRide newForm = new FormAcceptRide(driverID, taxiID);
                newForm.StartPosition = FormStartPosition.Manual;
                newForm.Location = this.Location;
                newForm.Show();
                newForm.Closed += (s, args) => this.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Najpierw zakończ obecny kurs!");
            }
        }

        private void FormDriverStartscreen_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                taxiID = kierowcy.getTaxiID(driverID);
                if (taxiID == -1)
                {
                    MessageBox.Show("Nie masz aktualnie przypisanej taksówki!");
                    this.Close();
                }
                currentRideID = kursy.checkDriverCurrentRideID(driverID);
                if (currentRideID == -1)
                {
                    dataGridViewRideData.Visible = false;
                    labelCurrentRide.Text = "BRAK AKTUALNEGO KURSU";
                    thereIsACurrentRide = false;
                    //MessageBox.Show("Brak kursu essa!");
                }
                else
                {
                    DataTable currentRideData = kursy.getRideData(currentRideID);
                    dataGridViewRideData.DataSource = currentRideData;
                    dataGridViewRideData.Visible = true;
                    labelCurrentRide.Text = "AKTUALNY KURS:";
                    thereIsACurrentRide = true;
                    //MessageBox.Show("Jest kurs!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
            //labelCurrentRide.Refresh();
            //dataGridViewRideData.Refresh();
            //this.Refresh();
            //Application.DoEvents();
        }
    }
}
