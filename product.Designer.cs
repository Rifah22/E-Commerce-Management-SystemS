
namespace E_Commerce_Management_System_Project
{
    partial class product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtPN = new MetroFramework.Controls.MetroTextBox();
            this.txtPT = new MetroFramework.Controls.MetroTextBox();
            this.txtPP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 122);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product List";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 414);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(56, 19);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Dashboard";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(17, 240);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(153, 19);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "View Product";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(541, 240);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(152, 19);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Delete Product";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(182, 67);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Product Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(180, 104);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Product Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(182, 141);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Product Type";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(299, 67);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 19);
            this.txtID.TabIndex = 12;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(299, 104);
            this.txtPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(155, 19);
            this.txtPN.TabIndex = 13;
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(299, 141);
            this.txtPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(155, 19);
            this.txtPT.TabIndex = 14;
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(299, 174);
            this.txtPP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(155, 19);
            this.txtPP.TabIndex = 16;
            this.txtPP.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(182, 176);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Product Price";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Commerce_Management_System_Project.Properties.Resources.desktop_wallpaper_backgrounds_for_login_page_login_page;
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "product";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtPN;
        private MetroFramework.Controls.MetroTextBox txtPT;
        private MetroFramework.Controls.MetroTextBox txtPP;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}