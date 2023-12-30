
namespace E_Commerce_Management_System
{
    partial class Dashboard_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_));
            this.BPL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPL
            // 
            this.BPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BPL.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPL.ForeColor = System.Drawing.Color.Green;
            this.BPL.Location = new System.Drawing.Point(266, 111);
            this.BPL.Name = "BPL";
            this.BPL.Size = new System.Drawing.Size(357, 112);
            this.BPL.TabIndex = 0;
            this.BPL.Text = "Product List";
            this.BPL.UseVisualStyleBackColor = false;
            this.BPL.Click += new System.EventHandler(this.BPL_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(266, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(357, 122);
            this.button2.TabIndex = 1;
            this.button2.Text = "Order and Customer List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Log_Out
            // 
            this.Log_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Log_Out.BackgroundImage")));
            this.Log_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_Out.Location = new System.Drawing.Point(661, 416);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(100, 41);
            this.Log_Out.TabIndex = 2;
            this.Log_Out.UseVisualStyleBackColor = true;
            this.Log_Out.Click += new System.EventHandler(this.Log_Out_Click);
            // 
            // Dashboard_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 510);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BPL);
            this.Name = "Dashboard_";
            this.Text = "Dashboard_";
            this.Load += new System.EventHandler(this.Dashboard__Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Log_Out;
    }
}