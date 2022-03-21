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

namespace BD2.KlientGUI
{
    public partial class FormMenagerStartscreen : Form
    {
        private int ID;
        private readonly Zarząd zarzad = new Zarząd();
        public FormMenagerStartscreen(int menagerID)
        {
            InitializeComponent();
            this.ID = menagerID;
        }

        private void buttonViewDriversInArea_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable drivers = zarzad.viewDrivers(ID);
                dataGridViewData.DataSource = drivers;
            }
            catch (SqlException)
            {
               MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonViewAreaData_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable drivers = zarzad.viewArea(ID);
                dataGridViewData.DataSource = drivers;
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonViewCabsInArea_Click(object sender, EventArgs e)
        {
            //try
            //{
                DataTable drivers = zarzad.viewCabs(ID);
                dataGridViewData.DataSource = drivers;
            //}
            //catch (SqlException)
            //{
              //  MessageBox.Show("Blad w bazie danych!");
            //}
        }

        private void buttonViewRides_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable drivers = zarzad.viewRides(ID);
                dataGridViewData.DataSource = drivers;
            }
            catch (SqlException)
            {
                MessageBox.Show("Blad w bazie danych!");
            }
        }

        private void buttonModifyDrivers_Click(object sender, EventArgs e)
        {
            FormMenagerModifyDrivers newForm = new FormMenagerModifyDrivers();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonModifyCabs_Click(object sender, EventArgs e)
        { 
            FormMenagerModifyCab newForm = new FormMenagerModifyCab();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void buttonModifyArea_Click(object sender, EventArgs e)
        {
            FormMenagerModifyArea newForm = new FormMenagerModifyArea();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
            newForm.Closed += (s, args) => this.Show();
            this.Hide();
        }
    }
}
