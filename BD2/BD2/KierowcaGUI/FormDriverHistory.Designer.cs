
namespace BD2.KierowcaGUI
{
    partial class FormDriverHistory
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
            this.labelRideHistory = new System.Windows.Forms.Label();
            this.dataGridViewRideHistory = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRideHistory
            // 
            this.labelRideHistory.AutoSize = true;
            this.labelRideHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRideHistory.Location = new System.Drawing.Point(28, 32);
            this.labelRideHistory.Name = "labelRideHistory";
            this.labelRideHistory.Size = new System.Drawing.Size(142, 24);
            this.labelRideHistory.TabIndex = 0;
            this.labelRideHistory.Text = "Historia kursów:";
            // 
            // dataGridViewRideHistory
            // 
            this.dataGridViewRideHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRideHistory.Location = new System.Drawing.Point(32, 76);
            this.dataGridViewRideHistory.Name = "dataGridViewRideHistory";
            this.dataGridViewRideHistory.ReadOnly = true;
            this.dataGridViewRideHistory.RowHeadersWidth = 51;
            this.dataGridViewRideHistory.RowTemplate.Height = 24;
            this.dataGridViewRideHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRideHistory.Size = new System.Drawing.Size(730, 281);
            this.dataGridViewRideHistory.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(32, 386);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(117, 35);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormDriverHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewRideHistory);
            this.Controls.Add(this.labelRideHistory);
            this.Name = "FormDriverHistory";
            this.Text = "FormDriverHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRideHistory;
        private System.Windows.Forms.DataGridView dataGridViewRideHistory;
        private System.Windows.Forms.Button buttonReturn;
    }
}