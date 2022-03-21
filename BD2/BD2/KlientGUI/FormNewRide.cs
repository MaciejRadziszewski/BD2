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
    public partial class FormNewRide : Form
    {
        private int clientID;
        private readonly Kursy kursy = new Kursy();

        public FormNewRide(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
        }

        private void buttonCreateRequest_Click(object sender, EventArgs e)
        {
            if (textBoxStart.Text != "" && textBoxEnd.Text != "")
                try
                {
                    kursy.addNewRide(clientID, textBoxStart.Text, textBoxEnd.Text);
                }
                catch (SqlException error)
                {
                    MessageBox.Show("Bład w bazie danych!");
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    MessageBox.Show("Zlozono prosbe");
                    this.Close();
                }
            else MessageBox.Show("Wprowadz dane!");

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormClientStartscreen newForm = new FormClientStartscreen(clientID);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            //newForm.Closed += (s, args) => this.Show();
            this.Close();
        }
    }
}
