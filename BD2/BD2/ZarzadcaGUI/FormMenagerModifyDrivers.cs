using BD2.Databse;
using BD2.ZarzadcaGUI;
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

namespace BD2.ZarzadcaGUI
{
    public partial class FormMenagerModifyDrivers : Form
    {
        private readonly Kierowcy kierowcy = new Kierowcy();
        public FormMenagerModifyDrivers()
        {
            InitializeComponent();
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxPesel.Text != "" && textBoxSalary.Text != "" && textBoxArea.Text != "" && textBoxCurrentCab.Text != "")
            {
                try
                {
                    kierowcy.addDriver(textBoxName.Text, textBoxSurname.Text, textBoxPesel.Text, int.Parse(textBoxSalary.Text), int.Parse(textBoxArea.Text), int.Parse(textBoxCurrentCab.Text));
                    MessageBox.Show("Poprawnie dodano kierowcę");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bład w bazie danych!");
                }
            }
            else
            {
                MessageBox.Show("Wypelnij pola!");
            }
        }

        private void buttonEditDriver_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != ""&& textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxPesel.Text != "" && textBoxSalary.Text != "" && textBoxArea.Text != "" && textBoxCurrentCab.Text != "")
            {
                try
                {
                    kierowcy.editDriver(int.Parse(textBoxID.Text), textBoxName.Text, textBoxSurname.Text, textBoxPesel.Text, int.Parse(textBoxSalary.Text), int.Parse(textBoxArea.Text), int.Parse(textBoxCurrentCab.Text));
                    MessageBox.Show("Poprawnie edytowano dane kierowcy");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bład w bazie danych!");
                }
            }
            else
            {
                MessageBox.Show("Wypelnij pola!");
            }
        }

        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                try
                {
                    kierowcy.deleteDriver(int.Parse(textBoxID.Text));
                    MessageBox.Show("Poprawnie usunięto kierowcę");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bład w bazie danych!");
                }
            }
            else
            {
                MessageBox.Show("Wypelnij pola!");
            }
        }
    }
}
