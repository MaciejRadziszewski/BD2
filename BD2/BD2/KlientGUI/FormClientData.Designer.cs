
namespace BD2.KlientGUI
{
    partial class FormClientData
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
            this.labelUserData = new System.Windows.Forms.Label();
            this.dataGridViewUserData = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserData.Location = new System.Drawing.Point(27, 30);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(115, 24);
            this.labelUserData.TabIndex = 0;
            this.labelUserData.Text = "Twoje dane:";
            // 
            // dataGridViewUserData
            // 
            this.dataGridViewUserData.AllowUserToAddRows = false;
            this.dataGridViewUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserData.Location = new System.Drawing.Point(30, 70);
            this.dataGridViewUserData.Name = "dataGridViewUserData";
            this.dataGridViewUserData.ReadOnly = true;
            this.dataGridViewUserData.RowHeadersWidth = 51;
            this.dataGridViewUserData.RowTemplate.Height = 24;
            this.dataGridViewUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserData.Size = new System.Drawing.Size(679, 150);
            this.dataGridViewUserData.TabIndex = 1;
            this.dataGridViewUserData.SelectionChanged += new System.EventHandler(this.dataGridViewUserData_SelectionChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 250);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Imię:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(46, 278);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 17);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(46, 306);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(109, 17);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Numer telefonu:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 250);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(161, 278);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(122, 22);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(161, 306);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(122, 22);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(37, 365);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 38);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edytuj dane";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(161, 365);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(105, 38);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewUserData);
            this.Controls.Add(this.labelUserData);
            this.Name = "FormClientData";
            this.Text = "FormClientData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.DataGridView dataGridViewUserData;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReturn;
    }
}