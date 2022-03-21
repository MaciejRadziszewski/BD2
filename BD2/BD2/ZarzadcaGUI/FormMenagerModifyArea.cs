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
    public partial class FormMenagerModifyArea : Form
    {
        private readonly Rejony rejon = new Rejony();
        public FormMenagerModifyArea()
        {
            InitializeComponent();
        }

        private void buttonEditArea_Click(object sender, EventArgs e)
        {
            rejon.editArea(int.Parse(textBoxID.Text), textBoxName.Text, int.Parse(textBoxSurface.Text), int.Parse(textBoxPrice.Text));
            if (textBoxName.Text != "" && textBoxSurface.Text != "" && textBoxPrice.Text != "" && textBoxID.Text != "")
            {
                try
                {
                    rejon.editArea(int.Parse(textBoxID.Text), textBoxName.Text, int.Parse(textBoxSurface.Text), int.Parse(textBoxPrice.Text)); 
                    MessageBox.Show("Poprawnie edytowano rejon");
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
