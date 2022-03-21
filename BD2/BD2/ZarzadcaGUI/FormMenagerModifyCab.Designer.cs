namespace BD2.ZarzadcaGUI
{
    partial class FormMenagerModifyCab
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDriver = new System.Windows.Forms.TextBox();
            this.textBoxNumPlate = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.buttonDeleteCab = new System.Windows.Forms.Button();
            this.buttonEditCab = new System.Windows.Forms.Button();
            this.buttonAddCab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(129, 6);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID (Edycja i usuwanie)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Aktualny Kierowca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nr rejestracji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kolor samochodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marka Samochodu";
            // 
            // textBoxDriver
            // 
            this.textBoxDriver.Location = new System.Drawing.Point(129, 148);
            this.textBoxDriver.Name = "textBoxDriver";
            this.textBoxDriver.Size = new System.Drawing.Size(100, 20);
            this.textBoxDriver.TabIndex = 23;
            // 
            // textBoxNumPlate
            // 
            this.textBoxNumPlate.Location = new System.Drawing.Point(129, 111);
            this.textBoxNumPlate.Name = "textBoxNumPlate";
            this.textBoxNumPlate.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumPlate.TabIndex = 22;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(129, 75);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 21;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(129, 39);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 20;
            // 
            // buttonDeleteCab
            // 
            this.buttonDeleteCab.Location = new System.Drawing.Point(259, 99);
            this.buttonDeleteCab.Name = "buttonDeleteCab";
            this.buttonDeleteCab.Size = new System.Drawing.Size(119, 28);
            this.buttonDeleteCab.TabIndex = 19;
            this.buttonDeleteCab.Text = "Usuń taksówkę";
            this.buttonDeleteCab.UseVisualStyleBackColor = true;
            this.buttonDeleteCab.Click += new System.EventHandler(this.buttonDeleteCab_Click);
            // 
            // buttonEditCab
            // 
            this.buttonEditCab.Location = new System.Drawing.Point(259, 52);
            this.buttonEditCab.Name = "buttonEditCab";
            this.buttonEditCab.Size = new System.Drawing.Size(119, 32);
            this.buttonEditCab.TabIndex = 18;
            this.buttonEditCab.Text = "Edytuj dane taksówki";
            this.buttonEditCab.UseVisualStyleBackColor = true;
            this.buttonEditCab.Click += new System.EventHandler(this.buttonEditCab_Click);
            // 
            // buttonAddCab
            // 
            this.buttonAddCab.Location = new System.Drawing.Point(259, 13);
            this.buttonAddCab.Name = "buttonAddCab";
            this.buttonAddCab.Size = new System.Drawing.Size(119, 28);
            this.buttonAddCab.TabIndex = 17;
            this.buttonAddCab.Text = "Dodaj taksówkę";
            this.buttonAddCab.UseVisualStyleBackColor = true;
            this.buttonAddCab.Click += new System.EventHandler(this.buttonAddCab_Click);
            // 
            // FormMenagerModifyCab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 189);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDriver);
            this.Controls.Add(this.textBoxNumPlate);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.buttonDeleteCab);
            this.Controls.Add(this.buttonEditCab);
            this.Controls.Add(this.buttonAddCab);
            this.Name = "FormMenagerModifyCab";
            this.Text = "FormMenagerModifyCab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDriver;
        private System.Windows.Forms.TextBox textBoxNumPlate;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Button buttonDeleteCab;
        private System.Windows.Forms.Button buttonEditCab;
        private System.Windows.Forms.Button buttonAddCab;
    }
}