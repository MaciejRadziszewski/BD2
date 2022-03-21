namespace BD2.KlientGUI
{
    partial class FormMenagerStartscreen
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
            this.buttonViewDriversInArea = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonViewAreaData = new System.Windows.Forms.Button();
            this.buttonViewCabsInArea = new System.Windows.Forms.Button();
            this.buttonViewRides = new System.Windows.Forms.Button();
            this.buttonModifyDrivers = new System.Windows.Forms.Button();
            this.buttonModifyCabs = new System.Windows.Forms.Button();
            this.buttonModifyArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewDriversInArea
            // 
            this.buttonViewDriversInArea.Location = new System.Drawing.Point(12, 305);
            this.buttonViewDriversInArea.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewDriversInArea.Name = "buttonViewDriversInArea";
            this.buttonViewDriversInArea.Size = new System.Drawing.Size(210, 26);
            this.buttonViewDriversInArea.TabIndex = 4;
            this.buttonViewDriversInArea.Text = "Wyświetl kierowców ze swojego rejonu";
            this.buttonViewDriversInArea.UseVisualStyleBackColor = true;
            this.buttonViewDriversInArea.Click += new System.EventHandler(this.buttonViewDriversInArea_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(778, 290);
            this.dataGridViewData.TabIndex = 5;
            // 
            // buttonViewAreaData
            // 
            this.buttonViewAreaData.Location = new System.Drawing.Point(296, 305);
            this.buttonViewAreaData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAreaData.Name = "buttonViewAreaData";
            this.buttonViewAreaData.Size = new System.Drawing.Size(210, 26);
            this.buttonViewAreaData.TabIndex = 6;
            this.buttonViewAreaData.Text = "Wyświetl dane swojego rejonu";
            this.buttonViewAreaData.UseVisualStyleBackColor = true;
            this.buttonViewAreaData.Click += new System.EventHandler(this.buttonViewAreaData_Click);
            // 
            // buttonViewCabsInArea
            // 
            this.buttonViewCabsInArea.Location = new System.Drawing.Point(578, 305);
            this.buttonViewCabsInArea.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewCabsInArea.Name = "buttonViewCabsInArea";
            this.buttonViewCabsInArea.Size = new System.Drawing.Size(210, 26);
            this.buttonViewCabsInArea.TabIndex = 7;
            this.buttonViewCabsInArea.Text = "Wyświetl dane taksówek z rejonu";
            this.buttonViewCabsInArea.UseVisualStyleBackColor = true;
            this.buttonViewCabsInArea.Click += new System.EventHandler(this.buttonViewCabsInArea_Click);
            // 
            // buttonViewRides
            // 
            this.buttonViewRides.Location = new System.Drawing.Point(296, 335);
            this.buttonViewRides.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewRides.Name = "buttonViewRides";
            this.buttonViewRides.Size = new System.Drawing.Size(210, 26);
            this.buttonViewRides.TabIndex = 8;
            this.buttonViewRides.Text = "Wyświetl dane kursów ze swojego rejonu";
            this.buttonViewRides.UseVisualStyleBackColor = true;
            this.buttonViewRides.Click += new System.EventHandler(this.buttonViewRides_Click);
            // 
            // buttonModifyDrivers
            // 
            this.buttonModifyDrivers.Location = new System.Drawing.Point(12, 382);
            this.buttonModifyDrivers.Name = "buttonModifyDrivers";
            this.buttonModifyDrivers.Size = new System.Drawing.Size(127, 56);
            this.buttonModifyDrivers.TabIndex = 9;
            this.buttonModifyDrivers.Text = "Modyfikuj Kierowców";
            this.buttonModifyDrivers.UseVisualStyleBackColor = true;
            this.buttonModifyDrivers.Click += new System.EventHandler(this.buttonModifyDrivers_Click);
            // 
            // buttonModifyCabs
            // 
            this.buttonModifyCabs.Location = new System.Drawing.Point(337, 382);
            this.buttonModifyCabs.Name = "buttonModifyCabs";
            this.buttonModifyCabs.Size = new System.Drawing.Size(127, 56);
            this.buttonModifyCabs.TabIndex = 10;
            this.buttonModifyCabs.Text = "Modyfikuj Taksówki";
            this.buttonModifyCabs.UseVisualStyleBackColor = true;
            this.buttonModifyCabs.Click += new System.EventHandler(this.buttonModifyCabs_Click);
            // 
            // buttonModifyArea
            // 
            this.buttonModifyArea.Location = new System.Drawing.Point(661, 382);
            this.buttonModifyArea.Name = "buttonModifyArea";
            this.buttonModifyArea.Size = new System.Drawing.Size(127, 56);
            this.buttonModifyArea.TabIndex = 11;
            this.buttonModifyArea.Text = "Modyfikuj Rejon";
            this.buttonModifyArea.UseVisualStyleBackColor = true;
            this.buttonModifyArea.Click += new System.EventHandler(this.buttonModifyArea_Click);
            // 
            // FormMenagerStartscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModifyArea);
            this.Controls.Add(this.buttonModifyCabs);
            this.Controls.Add(this.buttonModifyDrivers);
            this.Controls.Add(this.buttonViewRides);
            this.Controls.Add(this.buttonViewCabsInArea);
            this.Controls.Add(this.buttonViewAreaData);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonViewDriversInArea);
            this.Name = "FormMenagerStartscreen";
            this.Text = "FormMenagerStartscreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewDriversInArea;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonViewAreaData;
        private System.Windows.Forms.Button buttonViewCabsInArea;
        private System.Windows.Forms.Button buttonViewRides;
        private System.Windows.Forms.Button buttonModifyDrivers;
        private System.Windows.Forms.Button buttonModifyCabs;
        private System.Windows.Forms.Button buttonModifyArea;
    }
}