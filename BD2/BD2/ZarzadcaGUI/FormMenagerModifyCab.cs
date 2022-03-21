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

namespace BD2.ZarzadcaGUI
{
    public partial class FormMenagerModifyCab : Form
    {
        private readonly Taksówki taksowki = new Taksówki();
        public FormMenagerModifyCab()
        {
            InitializeComponent();
        }

        private void buttonAddCab_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.Text != "" && textBoxColor.Text != "" && textBoxNumPlate.Text != "" && textBoxDriver.Text != "")
            {
                try
                {
                    taksowki.addCab(textBoxBrand.Text, textBoxColor.Text, textBoxNumPlate.Text, int.Parse(textBoxDriver.Text));
                    MessageBox.Show("Poprawnie dodano taksówkę!");
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

        private void buttonEditCab_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxBrand.Text != "" && textBoxColor.Text != "" && textBoxNumPlate.Text != "" && textBoxDriver.Text != "")
            {
                try
                {
                    taksowki.editCab(int.Parse(textBoxID.Text), textBoxBrand.Text, textBoxColor.Text, textBoxNumPlate.Text, int.Parse(textBoxDriver.Text));
                    MessageBox.Show("Poprawnie edytowano taksówkę!");
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

        private void buttonDeleteCab_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" )
            {
                try
                {
                    taksowki.deleteCab(int.Parse(textBoxID.Text));
                    MessageBox.Show("Poprawnie usunięto taksówkę!");
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
