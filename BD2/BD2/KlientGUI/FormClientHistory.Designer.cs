
namespace BD2.KlientGUI
{
    partial class FormClientHistory
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
            this.dataGridViewRideHistory = new System.Windows.Forms.DataGridView();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRideHistory
            // 
            this.dataGridViewRideHistory.AllowUserToAddRows = false;
            this.dataGridViewRideHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRideHistory.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewRideHistory.Name = "dataGridViewRideHistory";
            this.dataGridViewRideHistory.ReadOnly = true;
            this.dataGridViewRideHistory.RowHeadersWidth = 51;
            this.dataGridViewRideHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRideHistory.Size = new System.Drawing.Size(776, 315);
            this.dataGridViewRideHistory.TabIndex = 0;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHistory.Location = new System.Drawing.Point(12, 20);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(142, 24);
            this.labelHistory.TabIndex = 1;
            this.labelHistory.Text = "Historia kursów:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(678, 379);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 33);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Wróć";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormClientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.dataGridViewRideHistory);
            this.Name = "FormClientHistory";
            this.Text = "FormHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRideHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRideHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button buttonExit;
    }
}