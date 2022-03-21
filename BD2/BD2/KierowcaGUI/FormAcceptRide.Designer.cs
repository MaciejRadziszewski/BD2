
namespace BD2.KierowcaGUI
{
    partial class FormAcceptRide
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
            this.labelAvailableRides = new System.Windows.Forms.Label();
            this.dataGridViewAvailableRides = new System.Windows.Forms.DataGridView();
            this.buttonAcceptRide = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRides)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAvailableRides
            // 
            this.labelAvailableRides.AutoSize = true;
            this.labelAvailableRides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvailableRides.Location = new System.Drawing.Point(27, 27);
            this.labelAvailableRides.Name = "labelAvailableRides";
            this.labelAvailableRides.Size = new System.Drawing.Size(145, 24);
            this.labelAvailableRides.TabIndex = 0;
            this.labelAvailableRides.Text = "Dostępne kursy:";
            // 
            // dataGridViewAvailableRides
            // 
            this.dataGridViewAvailableRides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableRides.Location = new System.Drawing.Point(31, 67);
            this.dataGridViewAvailableRides.Name = "dataGridViewAvailableRides";
            this.dataGridViewAvailableRides.ReadOnly = true;
            this.dataGridViewAvailableRides.RowHeadersWidth = 51;
            this.dataGridViewAvailableRides.RowTemplate.Height = 24;
            this.dataGridViewAvailableRides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableRides.Size = new System.Drawing.Size(740, 252);
            this.dataGridViewAvailableRides.TabIndex = 1;
            // 
            // buttonAcceptRide
            // 
            this.buttonAcceptRide.Location = new System.Drawing.Point(31, 338);
            this.buttonAcceptRide.Name = "buttonAcceptRide";
            this.buttonAcceptRide.Size = new System.Drawing.Size(141, 36);
            this.buttonAcceptRide.TabIndex = 2;
            this.buttonAcceptRide.Text = "Przyjmij kurs";
            this.buttonAcceptRide.UseVisualStyleBackColor = true;
            this.buttonAcceptRide.Click += new System.EventHandler(this.buttonAcceptRide_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(31, 380);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(141, 36);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormAcceptRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAcceptRide);
            this.Controls.Add(this.dataGridViewAvailableRides);
            this.Controls.Add(this.labelAvailableRides);
            this.Name = "FormAcceptRide";
            this.Text = "FormAcceptRide";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvailableRides;
        private System.Windows.Forms.DataGridView dataGridViewAvailableRides;
        private System.Windows.Forms.Button buttonAcceptRide;
        private System.Windows.Forms.Button buttonReturn;
    }
}