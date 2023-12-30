namespace UserPanel
{
    partial class biKashForm
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
            this.bKashLogoLabel1 = new System.Windows.Forms.Label();
            this.bKashLogoLabel2 = new System.Windows.Forms.Label();
            this.bKashColourLabel2 = new System.Windows.Forms.Label();
            this.bKashAccNumLabel = new System.Windows.Forms.Label();
            this.BkashAccTxtBox = new System.Windows.Forms.TextBox();
            this.bKashAccPinLabel = new System.Windows.Forms.Label();
            this.BikashPinTxtBox = new System.Windows.Forms.TextBox();
            this.bKashProceedBtn = new System.Windows.Forms.Button();
            this.bKashCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bKashLogoLabel1
            // 
            this.bKashLogoLabel1.BackColor = System.Drawing.Color.White;
            this.bKashLogoLabel1.Location = new System.Drawing.Point(-4, 0);
            this.bKashLogoLabel1.Name = "bKashLogoLabel1";
            this.bKashLogoLabel1.Size = new System.Drawing.Size(1301, 163);
            this.bKashLogoLabel1.TabIndex = 0;
            // 
            // bKashLogoLabel2
            // 
            this.bKashLogoLabel2.BackColor = System.Drawing.Color.White;
            this.bKashLogoLabel2.Image = global::UserPanel.Properties.Resources.bkash;
            this.bKashLogoLabel2.Location = new System.Drawing.Point(334, 0);
            this.bKashLogoLabel2.Name = "bKashLogoLabel2";
            this.bKashLogoLabel2.Size = new System.Drawing.Size(632, 151);
            this.bKashLogoLabel2.TabIndex = 2;
            // 
            // bKashColourLabel2
            // 
            this.bKashColourLabel2.BackColor = System.Drawing.Color.DeepPink;
            this.bKashColourLabel2.Location = new System.Drawing.Point(-1, 163);
            this.bKashColourLabel2.Name = "bKashColourLabel2";
            this.bKashColourLabel2.Size = new System.Drawing.Size(1298, 567);
            this.bKashColourLabel2.TabIndex = 3;
            // 
            // bKashAccNumLabel
            // 
            this.bKashAccNumLabel.BackColor = System.Drawing.Color.DeepPink;
            this.bKashAccNumLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKashAccNumLabel.Location = new System.Drawing.Point(419, 317);
            this.bKashAccNumLabel.Name = "bKashAccNumLabel";
            this.bKashAccNumLabel.Size = new System.Drawing.Size(224, 40);
            this.bKashAccNumLabel.TabIndex = 4;
            this.bKashAccNumLabel.Text = "Account Number:";
            // 
            // BkashAccTxtBox
            // 
            this.BkashAccTxtBox.Location = new System.Drawing.Point(649, 317);
            this.BkashAccTxtBox.Multiline = true;
            this.BkashAccTxtBox.Name = "BkashAccTxtBox";
            this.BkashAccTxtBox.Size = new System.Drawing.Size(239, 40);
            this.BkashAccTxtBox.TabIndex = 5;
            // 
            // bKashAccPinLabel
            // 
            this.bKashAccPinLabel.BackColor = System.Drawing.Color.DeepPink;
            this.bKashAccPinLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKashAccPinLabel.Location = new System.Drawing.Point(567, 396);
            this.bKashAccPinLabel.Name = "bKashAccPinLabel";
            this.bKashAccPinLabel.Size = new System.Drawing.Size(76, 40);
            this.bKashAccPinLabel.TabIndex = 6;
            this.bKashAccPinLabel.Text = "Pin:";
            // 
            // BikashPinTxtBox
            // 
            this.BikashPinTxtBox.Location = new System.Drawing.Point(649, 396);
            this.BikashPinTxtBox.Multiline = true;
            this.BikashPinTxtBox.Name = "BikashPinTxtBox";
            this.BikashPinTxtBox.Size = new System.Drawing.Size(239, 40);
            this.BikashPinTxtBox.TabIndex = 7;
            // 
            // bKashProceedBtn
            // 
            this.bKashProceedBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bKashProceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bKashProceedBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.bKashProceedBtn.Location = new System.Drawing.Point(484, 501);
            this.bKashProceedBtn.Name = "bKashProceedBtn";
            this.bKashProceedBtn.Size = new System.Drawing.Size(159, 42);
            this.bKashProceedBtn.TabIndex = 8;
            this.bKashProceedBtn.Text = "Proceed";
            this.bKashProceedBtn.UseVisualStyleBackColor = false;
            this.bKashProceedBtn.Click += new System.EventHandler(this.bKashProceedBtn_Click);
            // 
            // bKashCancelBtn
            // 
            this.bKashCancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bKashCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bKashCancelBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.bKashCancelBtn.Location = new System.Drawing.Point(729, 501);
            this.bKashCancelBtn.Name = "bKashCancelBtn";
            this.bKashCancelBtn.Size = new System.Drawing.Size(159, 42);
            this.bKashCancelBtn.TabIndex = 9;
            this.bKashCancelBtn.Text = "Cancel";
            this.bKashCancelBtn.UseVisualStyleBackColor = false;
            this.bKashCancelBtn.Click += new System.EventHandler(this.bKashCancelBtn_Click);
            // 
            // biKashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 721);
            this.Controls.Add(this.bKashCancelBtn);
            this.Controls.Add(this.bKashProceedBtn);
            this.Controls.Add(this.BikashPinTxtBox);
            this.Controls.Add(this.bKashAccPinLabel);
            this.Controls.Add(this.BkashAccTxtBox);
            this.Controls.Add(this.bKashAccNumLabel);
            this.Controls.Add(this.bKashColourLabel2);
            this.Controls.Add(this.bKashLogoLabel2);
            this.Controls.Add(this.bKashLogoLabel1);
            this.Name = "biKashForm";
            this.Text = "Amazon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bKashLogoLabel1;
        private System.Windows.Forms.Label bKashLogoLabel2;
        private System.Windows.Forms.Label bKashColourLabel2;
        private System.Windows.Forms.Label bKashAccNumLabel;
        private System.Windows.Forms.TextBox BkashAccTxtBox;
        private System.Windows.Forms.Label bKashAccPinLabel;
        private System.Windows.Forms.TextBox BikashPinTxtBox;
        private System.Windows.Forms.Button bKashProceedBtn;
        private System.Windows.Forms.Button bKashCancelBtn;
    }
}