
namespace BD2.KierowcaGUI
{
    partial class FormDistrictData
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
            this.labelDistrict = new System.Windows.Forms.Label();
            this.dataGridViewDistrictData = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistrictData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDistrict.Location = new System.Drawing.Point(12, 37);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(190, 24);
            this.labelDistrict.TabIndex = 0;
            this.labelDistrict.Text = "Dane twojego rejonu:";
            // 
            // dataGridViewDistrictData
            // 
            this.dataGridViewDistrictData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistrictData.Location = new System.Drawing.Point(16, 82);
            this.dataGridViewDistrictData.Name = "dataGridViewDistrictData";
            this.dataGridViewDistrictData.ReadOnly = true;
            this.dataGridViewDistrictData.RowHeadersWidth = 51;
            this.dataGridViewDistrictData.RowTemplate.Height = 24;
            this.dataGridViewDistrictData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDistrictData.Size = new System.Drawing.Size(772, 119);
            this.dataGridViewDistrictData.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(16, 244);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(114, 34);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormDistrictData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewDistrictData);
            this.Controls.Add(this.labelDistrict);
            this.Name = "FormDistrictData";
            this.Text = "FormDistrictData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistrictData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.DataGridView dataGridViewDistrictData;
        private System.Windows.Forms.Button buttonReturn;
    }
}