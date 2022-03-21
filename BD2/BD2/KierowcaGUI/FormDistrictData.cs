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
    public partial class FormDistrictData : Form
    {
        private int driverID;
        private readonly Rejony rejony = new Rejony();


        public FormDistrictData(int driverID)
        {
            this.driverID = driverID;
            InitializeComponent();
            try
            {
                DataTable districtData = rejony.getDataDriver(driverID);
                if (districtData.Rows.Count > 0) dataGridViewDistrictData.DataSource = districtData;
                else
                {
                    dataGridViewDistrictData.Visible = false;
                    labelDistrict.Text =  "NIE MASZ PRZYPISANEGO AKTUALNIE REJONU";
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
