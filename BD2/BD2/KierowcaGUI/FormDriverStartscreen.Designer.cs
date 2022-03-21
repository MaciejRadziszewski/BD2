
namespace BD2.KierowcaGUI
{
    partial class FormDriverStartscreen
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
            this.labelCurrentRide = new System.Windows.Forms.Label();
            this.dataGridViewRideData = new System.Windows.Forms.DataGridView();
            this.buttonSeeAvaiableRides = new System.Windows.Forms.Button();
            this.buttonViewRideHistory = new System.Windows.Forms.Button();
            this.buttonSeeData = new System.Windows.Forms.Button();
            this.buttonFinishRide = new System.Windows.Forms.Button();
            this.buttonTaxiData = new System.Windows.Forms.Button();
            this.buttonDistrictData = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentRide
            // 
            this.labelCurrentRide.AutoSize = true;
            this.labelCurrentRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentRide.Location = new System.Drawing.Point(12, 25);
            this.labelCurrentRide.Name = "labelCurrentRide";
            this.labelCurrentRide.Size = new System.Drawing.Size(126, 24);
            this.labelCurrentRide.TabIndex = 0;
            this.labelCurrentRide.Text = "Aktualny kurs:";
            // 
            // dataGridViewRideData
            // 
            this.dataGridViewRideData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRideData.Location = new System.Drawing.Point(16, 63);
            this.dataGridViewRideData.Name = "dataGridViewRideData";
            this.dataGridViewRideData.RowHeadersWidth = 51;
            this.dataGridViewRideData.RowTemplate.Height = 24;
            this.dataGridViewRideData.Size = new System.Drawing.Size(757, 144);
            this.dataGridViewRideData.TabIndex = 1;
            // 
            // buttonSeeAvaiableRides
            // 
            this.buttonSeeAvaiableRides.Location = new System.Drawing.Point(16, 235);
            this.buttonSeeAvaiableRides.Name = "buttonSeeAvaiableRides";
            this.buttonSeeAvaiableRides.Size = new System.Drawing.Size(278, 35);
            this.buttonSeeAvaiableRides.TabIndex = 2;
            this.buttonSeeAvaiableRides.Text = "Zobacz kursy oczekujące na kierowcę";
            this.buttonSeeAvaiableRides.UseVisualStyleBackColor = true;
            this.buttonSeeAvaiableRides.Click += new System.EventHandler(this.buttonSeeAvaiableRides_Click);
            // 
            // buttonViewRideHistory
            // 
            this.buttonViewRideHistory.Location = new System.Drawing.Point(16, 276);
            this.buttonViewRideHistory.Name = "buttonViewRideHistory";
            this.buttonViewRideHistory.Size = new System.Drawing.Size(278, 35);
            this.buttonViewRideHistory.TabIndex = 3;
            this.buttonViewRideHistory.Text = "Zobacz historię swoich kursów";
            this.buttonViewRideHistory.UseVisualStyleBackColor = true;
            this.buttonViewRideHistory.Click += new System.EventHandler(this.buttonViewRideHistory_Click);
            // 
            // buttonSeeData
            // 
            this.buttonSeeData.Location = new System.Drawing.Point(16, 317);
            this.buttonSeeData.Name = "buttonSeeData";
            this.buttonSeeData.Size = new System.Drawing.Size(278, 35);
            this.buttonSeeData.TabIndex = 4;
            this.buttonSeeData.Text = "Wyświetl swoje dane";
            this.buttonSeeData.UseVisualStyleBackColor = true;
            this.buttonSeeData.Click += new System.EventHandler(this.buttonSeeData_Click);
            // 
            // buttonFinishRide
            // 
            this.buttonFinishRide.Location = new System.Drawing.Point(300, 235);
            this.buttonFinishRide.Name = "buttonFinishRide";
            this.buttonFinishRide.Size = new System.Drawing.Size(278, 35);
            this.buttonFinishRide.TabIndex = 5;
            this.buttonFinishRide.Text = "Zakończ aktualny kurs";
            this.buttonFinishRide.UseVisualStyleBackColor = true;
            this.buttonFinishRide.Click += new System.EventHandler(this.buttonFinishRide_Click);
            // 
            // buttonTaxiData
            // 
            this.buttonTaxiData.Location = new System.Drawing.Point(300, 276);
            this.buttonTaxiData.Name = "buttonTaxiData";
            this.buttonTaxiData.Size = new System.Drawing.Size(278, 35);
            this.buttonTaxiData.TabIndex = 6;
            this.buttonTaxiData.Text = "Wyświetl dane taksówki";
            this.buttonTaxiData.UseVisualStyleBackColor = true;
            this.buttonTaxiData.Click += new System.EventHandler(this.buttonTaxiData_Click);
            // 
            // buttonDistrictData
            // 
            this.buttonDistrictData.Location = new System.Drawing.Point(300, 317);
            this.buttonDistrictData.Name = "buttonDistrictData";
            this.buttonDistrictData.Size = new System.Drawing.Size(278, 35);
            this.buttonDistrictData.TabIndex = 7;
            this.buttonDistrictData.Text = "Wyświetl dane rejonu";
            this.buttonDistrictData.UseVisualStyleBackColor = true;
            this.buttonDistrictData.Click += new System.EventHandler(this.buttonDistrictData_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(16, 358);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(278, 35);
            this.buttonLogOut.TabIndex = 8;
            this.buttonLogOut.Text = "Wyloguj się";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // FormDriverStartscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonDistrictData);
            this.Controls.Add(this.buttonTaxiData);
            this.Controls.Add(this.buttonFinishRide);
            this.Controls.Add(this.buttonSeeData);
            this.Controls.Add(this.buttonViewRideHistory);
            this.Controls.Add(this.buttonSeeAvaiableRides);
            this.Controls.Add(this.dataGridViewRideData);
            this.Controls.Add(this.labelCurrentRide);
            this.Name = "FormDriverStartscreen";
            this.Text = "FormDriverStartscreen";
            this.VisibleChanged += new System.EventHandler(this.FormDriverStartscreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentRide;
        private System.Windows.Forms.DataGridView dataGridViewRideData;
        private System.Windows.Forms.Button buttonSeeAvaiableRides;
        private System.Windows.Forms.Button buttonViewRideHistory;
        private System.Windows.Forms.Button buttonSeeData;
        private System.Windows.Forms.Button buttonFinishRide;
        private System.Windows.Forms.Button buttonTaxiData;
        private System.Windows.Forms.Button buttonDistrictData;
        private System.Windows.Forms.Button buttonLogOut;
    }
}