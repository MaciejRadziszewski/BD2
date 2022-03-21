using BD2.Databse;
using BD2.KierowcaGUI;
using BD2.KlientGUI;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BD2
{
    public partial class FormLogin : Form
    {
        private readonly Kierowcy kierowcy = new Kierowcy();
        private readonly Klienci klienci = new Klienci();
        private readonly Zarząd zarząd = new Zarząd();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(comboBoxUser.Text == "Klient")
            {
                try
                {
                    int result = klienci.checkClientLogin(textBoxLogin.Text, int.Parse(textBoxPassword.Text));
                    if (result == -1) MessageBox.Show("Brak takiego użytkownika");
                    else
                    {
                        FormClientStartscreen clientForm = new FormClientStartscreen(result);
                        clientForm.StartPosition = FormStartPosition.Manual;
                        clientForm.Location = this.Location;
                        this.Hide();
                        clientForm.Show();
                        clientForm.Closed += (s, args) => this.Show();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Wystąpił błąd w bazie danych");
                }
            }
            else if(comboBoxUser.Text == "Kierowca")
            {
                try
                {
                    int result = kierowcy.checkDriverLogin(textBoxLogin.Text, textBoxPassword.Text);
                    if (result == -1) MessageBox.Show("Brak takiego użytkownika");
                    else
                    {
                        FormDriverStartscreen driverForm = new FormDriverStartscreen(result);
                        driverForm.StartPosition = FormStartPosition.Manual;
                        driverForm.Location = this.Location;
                        this.Hide();
                        driverForm.Show();
                        driverForm.Closed += (s, args) => this.Show();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Wystąpił błąd w bazie danych");
                }
            }
            else if(comboBoxUser.Text == "Zarządca")
            {

            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUser.Text == "Klient")
            {
                buttonRegister.Visible = true;
            }
            else
            {
                buttonRegister.Visible = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormClientRegister clientRegisterForm = new FormClientRegister();
            clientRegisterForm.StartPosition = FormStartPosition.Manual;
            clientRegisterForm.Location = this.Location;
            this.Hide();
            clientRegisterForm.Show();
            clientRegisterForm.Closed += (s, args) => this.Show();
        }
    }
}
