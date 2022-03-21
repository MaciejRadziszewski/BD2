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
    public partial class FormDriverHistory : Form
    {
        private int driverID;
        private readonly Kursy kursy = new Kursy();

        public FormDriverHistory(int driverID)
        {
            this.driverID = driverID;
            InitializeComponent();
            try
            {
                DataTable history = kursy.getDriverRideHistory(driverID);
                if (history.Rows.Count > 0) dataGridViewRideHistory.DataSource = history;
                else
                {
                    dataGridViewRideHistory.Visible = false;
                    labelRideHistory.Text = labelRideHistory.Text + " BRAK";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
