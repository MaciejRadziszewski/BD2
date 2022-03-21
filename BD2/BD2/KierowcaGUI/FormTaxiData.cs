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
    public partial class FormTaxiData : Form
    {
        private int driverID;
        private readonly Taksówki taksówki = new Taksówki();

        public FormTaxiData(int driverID)
        {
            this.driverID = driverID;
            InitializeComponent();
            try
            {
                DataTable taxiData = taksówki.getDataDriver(driverID);
                if (taxiData.Rows.Count > 0) dataGridViewTaxiData.DataSource = taxiData;
                else
                {
                    dataGridViewTaxiData.Visible = false;
                    labelTaxiData.Text = "NIE MASZ PRZYPISANEGO AKTUALNIE TAKSÓWKI";
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
