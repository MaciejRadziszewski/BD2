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
    public partial class FormClientHistory : Form
    {
        private int clientID;
        private readonly Kursy kursy = new Kursy();

        public FormClientHistory(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            try
            {
                DataTable history = kursy.getClientRideHistory(clientID);
                if (history.Rows.Count > 0) dataGridViewRideHistory.DataSource = history;
                else
                {
                    dataGridViewRideHistory.Visible = false;
                    labelHistory.Text = labelHistory.Text + " BRAK";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
