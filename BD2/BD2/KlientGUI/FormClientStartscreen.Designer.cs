
namespace BD2.KlientGUI
{
    partial class FormClientStartscreen
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
            this.dataGridViewRideData = new System.Windows.Forms.DataGridView();
            this.labelCurrentRide = new System.Windows.Forms.Label();
            this.buttonViewRideHistory = new System.Windows.Forms.Button();
            this.buttonCreateNewRide = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonChangeData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRideData
            // 
            this.dataGridViewRideData.AllowUserToAddRows = false;
            this.dataGridViewRideData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRideData.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewRideData.Name = "dataGridViewRideData";
            this.dataGridViewRideData.ReadOnly = true;
            this.dataGridViewRideData.RowHeadersWidth = 51;
            this.dataGridViewRideData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRideData.Size = new System.Drawing.Size(762, 145);
            this.dataGridViewRideData.TabIndex = 0;
            // 
            // labelCurrentRide
            // 
            this.labelCurrentRide.AutoSize = true;
            this.labelCurrentRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentRide.Location = new System.Drawing.Point(8, 24);
            this.labelCurrentRide.Name = "labelCurrentRide";
            this.labelCurrentRide.Size = new System.Drawing.Size(126, 24);
            this.labelCurrentRide.TabIndex = 1;
            this.labelCurrentRide.Text = "Aktualny kurs:";
            // 
            // buttonViewRideHistory
            // 
            this.buttonViewRideHistory.Location = new System.Drawing.Point(12, 261);
            this.buttonViewRideHistory.Name = "buttonViewRideHistory";
            this.buttonViewRideHistory.Size = new System.Drawing.Size(280, 32);
            this.buttonViewRideHistory.TabIndex = 2;
            this.buttonViewRideHistory.Text = "Zobacz historię swoich kursów";
            this.buttonViewRideHistory.UseVisualStyleBackColor = true;
            this.buttonViewRideHistory.Click += new System.EventHandler(this.buttonViewRideHistory_Click);
            // 
            // buttonCreateNewRide
            // 
            this.buttonCreateNewRide.Location = new System.Drawing.Point(12, 223);
            this.buttonCreateNewRide.Name = "buttonCreateNewRide";
            this.buttonCreateNewRide.Size = new System.Drawing.Size(280, 32);
            this.buttonCreateNewRide.TabIndex = 3;
            this.buttonCreateNewRide.Text = "Zamów kurs";
            this.buttonCreateNewRide.UseVisualStyleBackColor = true;
            this.buttonCreateNewRide.Click += new System.EventHandler(this.buttonCreateNewRide_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(12, 335);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(280, 32);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Wyloguj się";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Location = new System.Drawing.Point(12, 297);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(280, 32);
            this.buttonChangeData.TabIndex = 5;
            this.buttonChangeData.Text = "Wyświetl/zmień swoje dane";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // FormClientStartscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeData);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonCreateNewRide);
            this.Controls.Add(this.buttonViewRideHistory);
            this.Controls.Add(this.labelCurrentRide);
            this.Controls.Add(this.dataGridViewRideData);
            this.Name = "FormClientStartscreen";
            this.Text = "FormStartscreen";
            this.VisibleChanged += new System.EventHandler(this.FormClientStartscreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRideData;
        private System.Windows.Forms.Label labelCurrentRide;
        private System.Windows.Forms.Button buttonViewRideHistory;
        private System.Windows.Forms.Button buttonCreateNewRide;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonChangeData;
    }
}