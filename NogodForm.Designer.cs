namespace UserPanel
{
    partial class NogodForm
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
            this.NagodCancelBtn = new System.Windows.Forms.Button();
            this.NagodProceedBtn = new System.Windows.Forms.Button();
            this.NagodPinTxtBox = new System.Windows.Forms.TextBox();
            this.NagodPinLabel = new System.Windows.Forms.Label();
            this.NagodAccNumTxtBox = new System.Windows.Forms.TextBox();
            this.NagodAccNumLabel = new System.Windows.Forms.Label();
            this.NagodColourLabel1 = new System.Windows.Forms.Label();
            this.NagodLogoLabel1 = new System.Windows.Forms.Label();
            this.NagodLogoLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NagodCancelBtn
            // 
            this.NagodCancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NagodCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NagodCancelBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.NagodCancelBtn.Location = new System.Drawing.Point(731, 496);
            this.NagodCancelBtn.Name = "NagodCancelBtn";
            this.NagodCancelBtn.Size = new System.Drawing.Size(159, 42);
            this.NagodCancelBtn.TabIndex = 18;
            this.NagodCancelBtn.Text = "Cancel";
            this.NagodCancelBtn.UseVisualStyleBackColor = false;
            this.NagodCancelBtn.Click += new System.EventHandler(this.NagodCancelBtn_Click);
            // 
            // NagodProceedBtn
            // 
            this.NagodProceedBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NagodProceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NagodProceedBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.NagodProceedBtn.Location = new System.Drawing.Point(486, 496);
            this.NagodProceedBtn.Name = "NagodProceedBtn";
            this.NagodProceedBtn.Size = new System.Drawing.Size(159, 42);
            this.NagodProceedBtn.TabIndex = 17;
            this.NagodProceedBtn.Text = "Proceed";
            this.NagodProceedBtn.UseVisualStyleBackColor = false;
            this.NagodProceedBtn.Click += new System.EventHandler(this.NagodProceedBtn_Click);
            // 
            // NagodPinTxtBox
            // 
            this.NagodPinTxtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.NagodPinTxtBox.Location = new System.Drawing.Point(651, 391);
            this.NagodPinTxtBox.Multiline = true;
            this.NagodPinTxtBox.Name = "NagodPinTxtBox";
            this.NagodPinTxtBox.Size = new System.Drawing.Size(239, 40);
            this.NagodPinTxtBox.TabIndex = 16;
            // 
            // NagodPinLabel
            // 
            this.NagodPinLabel.BackColor = System.Drawing.Color.Crimson;
            this.NagodPinLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NagodPinLabel.Location = new System.Drawing.Point(569, 391);
            this.NagodPinLabel.Name = "NagodPinLabel";
            this.NagodPinLabel.Size = new System.Drawing.Size(76, 40);
            this.NagodPinLabel.TabIndex = 15;
            this.NagodPinLabel.Text = "Pin:";
            // 
            // NagodAccNumTxtBox
            // 
            this.NagodAccNumTxtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.NagodAccNumTxtBox.Location = new System.Drawing.Point(651, 312);
            this.NagodAccNumTxtBox.Multiline = true;
            this.NagodAccNumTxtBox.Name = "NagodAccNumTxtBox";
            this.NagodAccNumTxtBox.Size = new System.Drawing.Size(239, 40);
            this.NagodAccNumTxtBox.TabIndex = 14;
            // 
            // NagodAccNumLabel
            // 
            this.NagodAccNumLabel.BackColor = System.Drawing.Color.Crimson;
            this.NagodAccNumLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NagodAccNumLabel.Location = new System.Drawing.Point(421, 312);
            this.NagodAccNumLabel.Name = "NagodAccNumLabel";
            this.NagodAccNumLabel.Size = new System.Drawing.Size(224, 40);
            this.NagodAccNumLabel.TabIndex = 13;
            this.NagodAccNumLabel.Text = "Account Number:";
            // 
            // NagodColourLabel1
            // 
            this.NagodColourLabel1.BackColor = System.Drawing.Color.Crimson;
            this.NagodColourLabel1.Location = new System.Drawing.Point(1, 158);
            this.NagodColourLabel1.Name = "NagodColourLabel1";
            this.NagodColourLabel1.Size = new System.Drawing.Size(1298, 567);
            this.NagodColourLabel1.TabIndex = 12;
            // 
            // NagodLogoLabel1
            // 
            this.NagodLogoLabel1.BackColor = System.Drawing.Color.White;
            this.NagodLogoLabel1.Location = new System.Drawing.Point(-2, -5);
            this.NagodLogoLabel1.Name = "NagodLogoLabel1";
            this.NagodLogoLabel1.Size = new System.Drawing.Size(1301, 163);
            this.NagodLogoLabel1.TabIndex = 10;
            // 
            // NagodLogoLabel2
            // 
            this.NagodLogoLabel2.BackColor = System.Drawing.Color.White;
            this.NagodLogoLabel2.Image = global::UserPanel.Properties.Resources.Nagad;
            this.NagodLogoLabel2.Location = new System.Drawing.Point(366, -5);
            this.NagodLogoLabel2.Name = "NagodLogoLabel2";
            this.NagodLogoLabel2.Size = new System.Drawing.Size(586, 151);
            this.NagodLogoLabel2.TabIndex = 11;
            // 
            // NogodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 721);
            this.Controls.Add(this.NagodCancelBtn);
            this.Controls.Add(this.NagodProceedBtn);
            this.Controls.Add(this.NagodPinTxtBox);
            this.Controls.Add(this.NagodPinLabel);
            this.Controls.Add(this.NagodAccNumTxtBox);
            this.Controls.Add(this.NagodAccNumLabel);
            this.Controls.Add(this.NagodColourLabel1);
            this.Controls.Add(this.NagodLogoLabel2);
            this.Controls.Add(this.NagodLogoLabel1);
            this.Name = "NogodForm";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NagodCancelBtn;
        private System.Windows.Forms.Button NagodProceedBtn;
        private System.Windows.Forms.TextBox NagodPinTxtBox;
        private System.Windows.Forms.Label NagodPinLabel;
        private System.Windows.Forms.TextBox NagodAccNumTxtBox;
        private System.Windows.Forms.Label NagodAccNumLabel;
        private System.Windows.Forms.Label NagodColourLabel1;
        private System.Windows.Forms.Label NagodLogoLabel2;
        private System.Windows.Forms.Label NagodLogoLabel1;
    }
}