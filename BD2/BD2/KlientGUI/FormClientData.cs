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
    public partial class FormClientData : Form
    {
        private int clientID;
        private readonly Klienci klienci = new Klienci();

        public FormClientData(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            try
            {
                DataTable clientData = klienci.getClientData(clientID);
                if (clientData.Rows.Count > 0) dataGridViewUserData.DataSource = clientData;
                else
                {
                    dataGridViewUserData.Visible = false;
                    labelUserData.Text += labelUserData.Text + " BRAK";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxPhoneNumber.Text != "")
            {
                try
                {
                    klienci.editClient(clientID, textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxPhoneNumber.Text)); 
                }
                catch (SqlException)
                {
                    MessageBox.Show("Blad w bazie danych!");
                }
                finally
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Wprowadz poprawne dane!");
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewUserData_SelectionChanged(object sender, EventArgs e)
        {
            //sprawdzenie czy jest zaznaczony jakiś wiersz, jeśli nie to nic nie rób
            int rowsCount = dataGridViewUserData.SelectedRows.Count;
            if (rowsCount == 0)
                return;
            //wybranie pierwszego zaznaczonego wiersza
            DataGridViewRow row = dataGridViewUserData.SelectedRows[0];

            string name = row.Cells[1].Value.ToString();
            string surname = row.Cells[2].Value.ToString();
            int phoneNumber = int.Parse(row.Cells[3].Value.ToString());

            textBoxName.Text = name;
            textBoxSurname.Text = surname;
            textBoxPhoneNumber.Text = phoneNumber.ToString();

        }
    }
}
