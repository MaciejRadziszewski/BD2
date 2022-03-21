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
    public partial class FormClientRegister : Form
    {
        private readonly Klienci klienci = new Klienci();

        public FormClientRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxPhoneNumber.Text != "")
            {
                try
                {
                    klienci.addClient(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxPhoneNumber.Text));
                    MessageBox.Show("Poprawnie zarejestrowano");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bład w bazie danych!");
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wypelnij pola!");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
