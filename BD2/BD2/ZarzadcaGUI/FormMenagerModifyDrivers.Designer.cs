namespace BD2.ZarzadcaGUI
{
    partial class FormMenagerModifyDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.buttonEditDriver = new System.Windows.Forms.Button();
            this.buttonDeleteDriver = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCurrentCab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(251, 13);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(119, 28);
            this.buttonAddDriver.TabIndex = 0;
            this.buttonAddDriver.Text = "Dodaj kierowcę";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // buttonEditDriver
            // 
            this.buttonEditDriver.Location = new System.Drawing.Point(251, 52);
            this.buttonEditDriver.Name = "buttonEditDriver";
            this.buttonEditDriver.Size = new System.Drawing.Size(119, 32);
            this.buttonEditDriver.TabIndex = 1;
            this.buttonEditDriver.Text = "Edytuj dane kierowcy";
            this.buttonEditDriver.UseVisualStyleBackColor = true;
            this.buttonEditDriver.Click += new System.EventHandler(this.buttonEditDriver_Click);
            // 
            // buttonDeleteDriver
            // 
            this.buttonDeleteDriver.Location = new System.Drawing.Point(251, 99);
            this.buttonDeleteDriver.Name = "buttonDeleteDriver";
            this.buttonDeleteDriver.Size = new System.Drawing.Size(119, 28);
            this.buttonDeleteDriver.TabIndex = 2;
            this.buttonDeleteDriver.Text = "Usuń kierowcę";
            this.buttonDeleteDriver.UseVisualStyleBackColor = true;
            this.buttonDeleteDriver.Click += new System.EventHandler(this.buttonDeleteDriver_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(121, 75);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(121, 111);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesel.TabIndex = 5;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(121, 148);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 6;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(121, 184);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wypłata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(37, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rejon";
            // 
            // textBoxCurrentCab
            // 
            this.textBoxCurrentCab.Location = new System.Drawing.Point(121, 220);
            this.textBoxCurrentCab.Name = "textBoxCurrentCab";
            this.textBoxCurrentCab.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentCab.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(4, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aktualna Taksówka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID (Edycja i usuwanie)";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(121, 6);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 16;
            // 
            // FormMenagerModifyDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 258);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCurrentCab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDeleteDriver);
            this.Controls.Add(this.buttonEditDriver);
            this.Controls.Add(this.buttonAddDriver);
            this.Name = "FormMenagerModifyDrivers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Button buttonEditDriver;
        private System.Windows.Forms.Button buttonDeleteDriver;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCurrentCab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
    }
}