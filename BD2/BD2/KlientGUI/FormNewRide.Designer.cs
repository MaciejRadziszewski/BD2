
namespace BD2.KlientGUI
{
    partial class FormNewRide
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.buttonCreateRequest = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstruction.Location = new System.Drawing.Point(12, 18);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(162, 24);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Podaj dane kursu:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(13, 67);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(70, 17);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Początek:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(13, 99);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(55, 17);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "Koniec:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(89, 67);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(195, 22);
            this.textBoxStart.TabIndex = 3;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(89, 99);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(195, 22);
            this.textBoxEnd.TabIndex = 4;
            // 
            // buttonCreateRequest
            // 
            this.buttonCreateRequest.Location = new System.Drawing.Point(16, 162);
            this.buttonCreateRequest.Name = "buttonCreateRequest";
            this.buttonCreateRequest.Size = new System.Drawing.Size(183, 36);
            this.buttonCreateRequest.TabIndex = 5;
            this.buttonCreateRequest.Text = "Złóż prośbę o kurs";
            this.buttonCreateRequest.UseVisualStyleBackColor = true;
            this.buttonCreateRequest.Click += new System.EventHandler(this.buttonCreateRequest_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(205, 162);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(183, 36);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormNewRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCreateRequest);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelInstruction);
            this.Name = "FormNewRide";
            this.Text = "FormNewRide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Button buttonCreateRequest;
        private System.Windows.Forms.Button buttonReturn;
    }
}