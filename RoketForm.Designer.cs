namespace UserPanel
{
    partial class RoketForm
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
            this.RoketCancelBtn = new System.Windows.Forms.Button();
            this.RoketProceedBtn = new System.Windows.Forms.Button();
            this.RoketPinTxtBox = new System.Windows.Forms.TextBox();
            this.RoketPinLabel = new System.Windows.Forms.Label();
            this.RoketAccNumTxtBox = new System.Windows.Forms.TextBox();
            this.RoketAccNumLabel = new System.Windows.Forms.Label();
            this.RoketColourLabel1 = new System.Windows.Forms.Label();
            this.RoketLogoLabel1 = new System.Windows.Forms.Label();
            this.RoketLogoLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoketCancelBtn
            // 
            this.RoketCancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoketCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoketCancelBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.RoketCancelBtn.Location = new System.Drawing.Point(731, 496);
            this.RoketCancelBtn.Name = "RoketCancelBtn";
            this.RoketCancelBtn.Size = new System.Drawing.Size(159, 42);
            this.RoketCancelBtn.TabIndex = 18;
            this.RoketCancelBtn.Text = "Cancel";
            this.RoketCancelBtn.UseVisualStyleBackColor = false;
            this.RoketCancelBtn.Click += new System.EventHandler(this.RoketCancelBtn_Click);
            // 
            // RoketProceedBtn
            // 
            this.RoketProceedBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoketProceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoketProceedBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.RoketProceedBtn.Location = new System.Drawing.Point(486, 496);
            this.RoketProceedBtn.Name = "RoketProceedBtn";
            this.RoketProceedBtn.Size = new System.Drawing.Size(159, 42);
            this.RoketProceedBtn.TabIndex = 17;
            this.RoketProceedBtn.Text = "Proceed";
            this.RoketProceedBtn.UseVisualStyleBackColor = false;
            this.RoketProceedBtn.Click += new System.EventHandler(this.RoketProceedBtn_Click);
            // 
            // RoketPinTxtBox
            // 
            this.RoketPinTxtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.RoketPinTxtBox.Location = new System.Drawing.Point(651, 391);
            this.RoketPinTxtBox.Multiline = true;
            this.RoketPinTxtBox.Name = "RoketPinTxtBox";
            this.RoketPinTxtBox.Size = new System.Drawing.Size(239, 40);
            this.RoketPinTxtBox.TabIndex = 16;
            // 
            // RoketPinLabel
            // 
            this.RoketPinLabel.BackColor = System.Drawing.Color.DarkViolet;
            this.RoketPinLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoketPinLabel.Location = new System.Drawing.Point(569, 391);
            this.RoketPinLabel.Name = "RoketPinLabel";
            this.RoketPinLabel.Size = new System.Drawing.Size(76, 40);
            this.RoketPinLabel.TabIndex = 15;
            this.RoketPinLabel.Text = "Pin:";
            // 
            // RoketAccNumTxtBox
            // 
            this.RoketAccNumTxtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.RoketAccNumTxtBox.Location = new System.Drawing.Point(651, 312);
            this.RoketAccNumTxtBox.Multiline = true;
            this.RoketAccNumTxtBox.Name = "RoketAccNumTxtBox";
            this.RoketAccNumTxtBox.Size = new System.Drawing.Size(239, 40);
            this.RoketAccNumTxtBox.TabIndex = 14;
            // 
            // RoketAccNumLabel
            // 
            this.RoketAccNumLabel.BackColor = System.Drawing.Color.DarkViolet;
            this.RoketAccNumLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoketAccNumLabel.Location = new System.Drawing.Point(421, 312);
            this.RoketAccNumLabel.Name = "RoketAccNumLabel";
            this.RoketAccNumLabel.Size = new System.Drawing.Size(224, 40);
            this.RoketAccNumLabel.TabIndex = 13;
            this.RoketAccNumLabel.Text = "Account Number:";
            // 
            // RoketColourLabel1
            // 
            this.RoketColourLabel1.BackColor = System.Drawing.Color.DarkViolet;
            this.RoketColourLabel1.Location = new System.Drawing.Point(1, 175);
            this.RoketColourLabel1.Name = "RoketColourLabel1";
            this.RoketColourLabel1.Size = new System.Drawing.Size(1298, 550);
            this.RoketColourLabel1.TabIndex = 12;
            // 
            // RoketLogoLabel1
            // 
            this.RoketLogoLabel1.BackColor = System.Drawing.Color.DarkViolet;
            this.RoketLogoLabel1.Location = new System.Drawing.Point(-2, -5);
            this.RoketLogoLabel1.Name = "RoketLogoLabel1";
            this.RoketLogoLabel1.Size = new System.Drawing.Size(1301, 180);
            this.RoketLogoLabel1.TabIndex = 10;
            // 
            // RoketLogoLabel2
            // 
            this.RoketLogoLabel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.RoketLogoLabel2.Image = global::UserPanel.Properties.Resources.Rocket;
            this.RoketLogoLabel2.Location = new System.Drawing.Point(581, -5);
            this.RoketLogoLabel2.Name = "RoketLogoLabel2";
            this.RoketLogoLabel2.Size = new System.Drawing.Size(210, 180);
            this.RoketLogoLabel2.TabIndex = 11;
            // 
            // RoketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 721);
            this.Controls.Add(this.RoketCancelBtn);
            this.Controls.Add(this.RoketProceedBtn);
            this.Controls.Add(this.RoketPinTxtBox);
            this.Controls.Add(this.RoketPinLabel);
            this.Controls.Add(this.RoketAccNumTxtBox);
            this.Controls.Add(this.RoketAccNumLabel);
            this.Controls.Add(this.RoketColourLabel1);
            this.Controls.Add(this.RoketLogoLabel2);
            this.Controls.Add(this.RoketLogoLabel1);
            this.Name = "RoketForm";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RoketCancelBtn;
        private System.Windows.Forms.Button RoketProceedBtn;
        private System.Windows.Forms.TextBox RoketPinTxtBox;
        private System.Windows.Forms.Label RoketPinLabel;
        private System.Windows.Forms.TextBox RoketAccNumTxtBox;
        private System.Windows.Forms.Label RoketAccNumLabel;
        private System.Windows.Forms.Label RoketColourLabel1;
        private System.Windows.Forms.Label RoketLogoLabel2;
        private System.Windows.Forms.Label RoketLogoLabel1;
    }
}