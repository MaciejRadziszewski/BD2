
namespace BD2.KierowcaGUI
{
    partial class FormFinishRide
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
            this.labelCost = new System.Windows.Forms.Label();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.buttonEndRide = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(68, 168);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(101, 17);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Do zapłaty [zł]:";
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Location = new System.Drawing.Point(68, 211);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(96, 17);
            this.labelPaymentType.TabIndex = 2;
            this.labelPaymentType.Text = "Typ płatności:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wypełnij dane:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(231, 168);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 22);
            this.textBoxCost.TabIndex = 5;
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Gotówka",
            "Karta"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(231, 208);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaymentType.TabIndex = 6;
            // 
            // buttonEndRide
            // 
            this.buttonEndRide.Location = new System.Drawing.Point(71, 275);
            this.buttonEndRide.Name = "buttonEndRide";
            this.buttonEndRide.Size = new System.Drawing.Size(127, 30);
            this.buttonEndRide.TabIndex = 7;
            this.buttonEndRide.Text = "Zakończ kurs";
            this.buttonEndRide.UseVisualStyleBackColor = true;
            this.buttonEndRide.Click += new System.EventHandler(this.buttonEndRide_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(71, 311);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(127, 30);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(231, 125);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(121, 22);
            this.textBoxDistance.TabIndex = 4;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(68, 125);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(153, 17);
            this.labelDistance.TabIndex = 0;
            this.labelDistance.Text = "Całkowity dystans [km]:";
            // 
            // FormFinishRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonEndRide);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPaymentType);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDistance);
            this.Name = "FormFinishRide";
            this.Text = "FormFinishRide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Button buttonEndRide;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelDistance;
    }
}