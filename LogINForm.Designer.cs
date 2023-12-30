namespace UserPanel
{
    partial class logIN
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
            this.LogIN_Txt = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ForgetPassBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.LogIN_PicLabel_2 = new System.Windows.Forms.Label();
            this.LogIN_PicLabel = new System.Windows.Forms.Label();
            this.GoToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIN_Txt
            // 
            this.LogIN_Txt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIN_Txt.ForeColor = System.Drawing.Color.Red;
            this.LogIN_Txt.Location = new System.Drawing.Point(950, 280);
            this.LogIN_Txt.Name = "LogIN_Txt";
            this.LogIN_Txt.Size = new System.Drawing.Size(124, 42);
            this.LogIN_Txt.TabIndex = 2;
            this.LogIN_Txt.Text = "LogIN";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(825, 359);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(124, 42);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(825, 460);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(124, 42);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(830, 393);
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(373, 41);
            this.UserNameTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(830, 492);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(373, 43);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // ForgetPassBtn
            // 
            this.ForgetPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPassBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ForgetPassBtn.FlatAppearance.BorderSize = 0;
            this.ForgetPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForgetPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForgetPassBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassBtn.ForeColor = System.Drawing.Color.Red;
            this.ForgetPassBtn.Location = new System.Drawing.Point(830, 535);
            this.ForgetPassBtn.Name = "ForgetPassBtn";
            this.ForgetPassBtn.Size = new System.Drawing.Size(373, 26);
            this.ForgetPassBtn.TabIndex = 8;
            this.ForgetPassBtn.Text = "Forgotten Password ?";
            this.ForgetPassBtn.UseVisualStyleBackColor = true;
            this.ForgetPassBtn.Click += new System.EventHandler(this.ForgetPassBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = global::UserPanel.Properties.Resources.in_Exit;
            this.ExitBtn.Location = new System.Drawing.Point(1009, 683);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 110);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Image = global::UserPanel.Properties.Resources.in_signup;
            this.SignUpBtn.Location = new System.Drawing.Point(1136, 566);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(100, 100);
            this.SignUpBtn.TabIndex = 10;
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInBtn.Image = global::UserPanel.Properties.Resources.in_log_in2;
            this.LogInBtn.Location = new System.Drawing.Point(802, 566);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(100, 100);
            this.LogInBtn.TabIndex = 9;
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LogIN_PicLabel_2
            // 
            this.LogIN_PicLabel_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LogIN_PicLabel_2.Image = global::UserPanel.Properties.Resources.LogIN_pic2;
            this.LogIN_PicLabel_2.Location = new System.Drawing.Point(827, 35);
            this.LogIN_PicLabel_2.Name = "LogIN_PicLabel_2";
            this.LogIN_PicLabel_2.Size = new System.Drawing.Size(357, 231);
            this.LogIN_PicLabel_2.TabIndex = 1;
            // 
            // LogIN_PicLabel
            // 
            this.LogIN_PicLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LogIN_PicLabel.Image = global::UserPanel.Properties.Resources.LogIN_pic1;
            this.LogIN_PicLabel.Location = new System.Drawing.Point(-1, -1);
            this.LogIN_PicLabel.Name = "LogIN_PicLabel";
            this.LogIN_PicLabel.Size = new System.Drawing.Size(745, 850);
            this.LogIN_PicLabel.TabIndex = 0;
            // 
            // GoToMenuBtn
            // 
            this.GoToMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToMenuBtn.Image = global::UserPanel.Properties.Resources.in_previous;
            this.GoToMenuBtn.Location = new System.Drawing.Point(750, 789);
            this.GoToMenuBtn.Name = "GoToMenuBtn";
            this.GoToMenuBtn.Size = new System.Drawing.Size(67, 60);
            this.GoToMenuBtn.TabIndex = 14;
            this.GoToMenuBtn.UseVisualStyleBackColor = true;
            this.GoToMenuBtn.Click += new System.EventHandler(this.GoToMenuBtn_Click);
            // 
            // logIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 1055);
            this.Controls.Add(this.GoToMenuBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.ForgetPassBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogIN_Txt);
            this.Controls.Add(this.LogIN_PicLabel_2);
            this.Controls.Add(this.LogIN_PicLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "logIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogIN_PicLabel;
        private System.Windows.Forms.Label LogIN_PicLabel_2;
        private System.Windows.Forms.Label LogIN_Txt;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ForgetPassBtn;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button GoToMenuBtn;
    }
}

