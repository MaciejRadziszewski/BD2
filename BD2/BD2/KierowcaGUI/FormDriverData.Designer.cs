
namespace BD2.KierowcaGUI
{
    partial class FormDriverData
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
            this.labelDriverData = new System.Windows.Forms.Label();
            this.dataGridViewDriverData = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDriverData
            // 
            this.labelDriverData.AutoSize = true;
            this.labelDriverData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDriverData.Location = new System.Drawing.Point(23, 39);
            this.labelDriverData.Name = "labelDriverData";
            this.labelDriverData.Size = new System.Drawing.Size(115, 24);
            this.labelDriverData.TabIndex = 0;
            this.labelDriverData.Text = "Twoje dane:";
            // 
            // dataGridViewDriverData
            // 
            this.dataGridViewDriverData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriverData.Location = new System.Drawing.Point(27, 83);
            this.dataGridViewDriverData.Name = "dataGridViewDriverData";
            this.dataGridViewDriverData.ReadOnly = true;
            this.dataGridViewDriverData.RowHeadersWidth = 51;
            this.dataGridViewDriverData.RowTemplate.Height = 24;
            this.dataGridViewDriverData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDriverData.Size = new System.Drawing.Size(743, 150);
            this.dataGridViewDriverData.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(27, 264);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(136, 38);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormDriverData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewDriverData);
            this.Controls.Add(this.labelDriverData);
            this.Name = "FormDriverData";
            this.Text = "FormDriverData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDriverData;
        private System.Windows.Forms.DataGridView dataGridViewDriverData;
        private System.Windows.Forms.Button buttonReturn;
    }
}