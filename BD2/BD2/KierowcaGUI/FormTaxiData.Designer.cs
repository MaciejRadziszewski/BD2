
namespace BD2.KierowcaGUI
{
    partial class FormTaxiData
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
            this.labelTaxiData = new System.Windows.Forms.Label();
            this.dataGridViewTaxiData = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxiData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaxiData
            // 
            this.labelTaxiData.AutoSize = true;
            this.labelTaxiData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTaxiData.Location = new System.Drawing.Point(28, 25);
            this.labelTaxiData.Name = "labelTaxiData";
            this.labelTaxiData.Size = new System.Drawing.Size(135, 24);
            this.labelTaxiData.TabIndex = 0;
            this.labelTaxiData.Text = "Dane taksówki:";
            // 
            // dataGridViewTaxiData
            // 
            this.dataGridViewTaxiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaxiData.Location = new System.Drawing.Point(32, 76);
            this.dataGridViewTaxiData.Name = "dataGridViewTaxiData";
            this.dataGridViewTaxiData.ReadOnly = true;
            this.dataGridViewTaxiData.RowHeadersWidth = 51;
            this.dataGridViewTaxiData.RowTemplate.Height = 24;
            this.dataGridViewTaxiData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTaxiData.Size = new System.Drawing.Size(739, 150);
            this.dataGridViewTaxiData.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(32, 267);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(91, 40);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormTaxiData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewTaxiData);
            this.Controls.Add(this.labelTaxiData);
            this.Name = "FormTaxiData";
            this.Text = "FormTaxiData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxiData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaxiData;
        private System.Windows.Forms.DataGridView dataGridViewTaxiData;
        private System.Windows.Forms.Button buttonReturn;
    }
}