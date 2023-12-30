namespace E_Commerce_Management_System
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.Add = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.bAdd = new MetroFramework.Controls.MetroButton();
            this.bRefresh = new MetroFramework.Controls.MetroButton();
            this.bDelete = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.bBack = new MetroFramework.Controls.MetroButton();
            this.t_P_Id = new MetroFramework.Controls.MetroTextBox();
            this.l_P_I = new MetroFramework.Controls.MetroLabel();
            this.t_P_Price = new MetroFramework.Controls.MetroTextBox();
            this.l_P_P = new MetroFramework.Controls.MetroLabel();
            this.t_P_Type = new MetroFramework.Controls.MetroTextBox();
            this.t_P_Name = new MetroFramework.Controls.MetroTextBox();
            this.l_P_Type = new MetroFramework.Controls.MetroLabel();
            this.l_P_N = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.productInformationToolStripMenuItem,
            this.priceToolStripMenuItem,
            this.discountToolStripMenuItem});
            this.Add.Name = "metroContextMenu1";
            this.Add.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Add.ShowCheckMargin = true;
            this.Add.Size = new System.Drawing.Size(205, 92);
            this.Add.Opening += new System.ComponentModel.CancelEventHandler(this.Add_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // productInformationToolStripMenuItem
            // 
            this.productInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productIdToolStripMenuItem,
            this.productNameToolStripMenuItem,
            this.productTypeToolStripMenuItem});
            this.productInformationToolStripMenuItem.Name = "productInformationToolStripMenuItem";
            this.productInformationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productInformationToolStripMenuItem.Text = "Product Information";
            // 
            // productIdToolStripMenuItem
            // 
            this.productIdToolStripMenuItem.Name = "productIdToolStripMenuItem";
            this.productIdToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.productIdToolStripMenuItem.Text = "Product id";
            // 
            // productNameToolStripMenuItem
            // 
            this.productNameToolStripMenuItem.Name = "productNameToolStripMenuItem";
            this.productNameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.productNameToolStripMenuItem.Text = "Product name";
            // 
            // productTypeToolStripMenuItem
            // 
            this.productTypeToolStripMenuItem.Name = "productTypeToolStripMenuItem";
            this.productTypeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.productTypeToolStripMenuItem.Text = "Product type";
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.priceToolStripMenuItem.Text = "Price";
            // 
            // discountToolStripMenuItem
            // 
            this.discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            this.discountToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.discountToolStripMenuItem.Text = "Discount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(480, 328);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.bAdd);
            this.metroPanel1.Controls.Add(this.bRefresh);
            this.metroPanel1.Controls.Add(this.bDelete);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(480, 54);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bAdd.Location = new System.Drawing.Point(21, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(98, 42);
            this.bAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Add";
            this.bAdd.UseSelectable = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click_1);
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(350, 6);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(101, 42);
            this.bRefresh.TabIndex = 4;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseSelectable = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click_1);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(191, 5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(96, 42);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.bDelete.UseSelectable = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Linen;
            this.metroPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel3.BackgroundImage")));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.Controls.Add(this.bBack);
            this.metroPanel3.Controls.Add(this.t_P_Id);
            this.metroPanel3.Controls.Add(this.l_P_I);
            this.metroPanel3.Controls.Add(this.t_P_Price);
            this.metroPanel3.Controls.Add(this.l_P_P);
            this.metroPanel3.Controls.Add(this.t_P_Type);
            this.metroPanel3.Controls.Add(this.t_P_Name);
            this.metroPanel3.Controls.Add(this.l_P_Type);
            this.metroPanel3.Controls.Add(this.l_P_N);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(489, 67);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(304, 328);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 12;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // bBack
            // 
            this.bBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBack.BackgroundImage")));
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBack.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBack.Location = new System.Drawing.Point(194, 282);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(84, 39);
            this.bBack.TabIndex = 2;
            this.bBack.UseSelectable = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // t_P_Id
            // 
            // 
            // 
            // 
            this.t_P_Id.CustomButton.Image = null;
            this.t_P_Id.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.t_P_Id.CustomButton.Name = "";
            this.t_P_Id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.t_P_Id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_P_Id.CustomButton.TabIndex = 1;
            this.t_P_Id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.t_P_Id.CustomButton.UseSelectable = true;
            this.t_P_Id.CustomButton.Visible = false;
            this.t_P_Id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_P_Id.Lines = new string[0];
            this.t_P_Id.Location = new System.Drawing.Point(110, 54);
            this.t_P_Id.MaxLength = 32767;
            this.t_P_Id.Name = "t_P_Id";
            this.t_P_Id.PasswordChar = '\0';
            this.t_P_Id.PromptText = "Enter the product id";
            this.t_P_Id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_P_Id.SelectedText = "";
            this.t_P_Id.SelectionLength = 0;
            this.t_P_Id.SelectionStart = 0;
            this.t_P_Id.ShortcutsEnabled = true;
            this.t_P_Id.Size = new System.Drawing.Size(168, 23);
            this.t_P_Id.TabIndex = 11;
            this.t_P_Id.UseSelectable = true;
            this.t_P_Id.WaterMark = "Enter the product id";
            this.t_P_Id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.t_P_Id.WaterMarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // l_P_I
            // 
            this.l_P_I.AutoSize = true;
            this.l_P_I.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_P_I.Location = new System.Drawing.Point(31, 58);
            this.l_P_I.Name = "l_P_I";
            this.l_P_I.Size = new System.Drawing.Size(73, 19);
            this.l_P_I.TabIndex = 10;
            this.l_P_I.Text = "Product Id:";
            // 
            // t_P_Price
            // 
            // 
            // 
            // 
            this.t_P_Price.CustomButton.Image = null;
            this.t_P_Price.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.t_P_Price.CustomButton.Name = "";
            this.t_P_Price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.t_P_Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_P_Price.CustomButton.TabIndex = 1;
            this.t_P_Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.t_P_Price.CustomButton.UseSelectable = true;
            this.t_P_Price.CustomButton.Visible = false;
            this.t_P_Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_P_Price.Lines = new string[0];
            this.t_P_Price.Location = new System.Drawing.Point(110, 195);
            this.t_P_Price.MaxLength = 32767;
            this.t_P_Price.Name = "t_P_Price";
            this.t_P_Price.PasswordChar = '\0';
            this.t_P_Price.PromptText = "Enter the product price";
            this.t_P_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_P_Price.SelectedText = "";
            this.t_P_Price.SelectionLength = 0;
            this.t_P_Price.SelectionStart = 0;
            this.t_P_Price.ShortcutsEnabled = true;
            this.t_P_Price.Size = new System.Drawing.Size(168, 23);
            this.t_P_Price.TabIndex = 9;
            this.t_P_Price.UseSelectable = true;
            this.t_P_Price.WaterMark = "Enter the product price";
            this.t_P_Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.t_P_Price.WaterMarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // l_P_P
            // 
            this.l_P_P.AutoSize = true;
            this.l_P_P.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_P_P.Location = new System.Drawing.Point(14, 199);
            this.l_P_P.Name = "l_P_P";
            this.l_P_P.Size = new System.Drawing.Size(91, 19);
            this.l_P_P.TabIndex = 8;
            this.l_P_P.Text = "Product Price:";
            // 
            // t_P_Type
            // 
            // 
            // 
            // 
            this.t_P_Type.CustomButton.Image = null;
            this.t_P_Type.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.t_P_Type.CustomButton.Name = "";
            this.t_P_Type.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.t_P_Type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_P_Type.CustomButton.TabIndex = 1;
            this.t_P_Type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.t_P_Type.CustomButton.UseSelectable = true;
            this.t_P_Type.CustomButton.Visible = false;
            this.t_P_Type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_P_Type.Lines = new string[0];
            this.t_P_Type.Location = new System.Drawing.Point(110, 144);
            this.t_P_Type.MaxLength = 32767;
            this.t_P_Type.Name = "t_P_Type";
            this.t_P_Type.PasswordChar = '\0';
            this.t_P_Type.PromptText = "Enter the product type";
            this.t_P_Type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_P_Type.SelectedText = "";
            this.t_P_Type.SelectionLength = 0;
            this.t_P_Type.SelectionStart = 0;
            this.t_P_Type.ShortcutsEnabled = true;
            this.t_P_Type.Size = new System.Drawing.Size(168, 23);
            this.t_P_Type.TabIndex = 7;
            this.t_P_Type.UseSelectable = true;
            this.t_P_Type.WaterMark = "Enter the product type";
            this.t_P_Type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.t_P_Type.WaterMarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // t_P_Name
            // 
            // 
            // 
            // 
            this.t_P_Name.CustomButton.Image = null;
            this.t_P_Name.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.t_P_Name.CustomButton.Name = "";
            this.t_P_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.t_P_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_P_Name.CustomButton.TabIndex = 1;
            this.t_P_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.t_P_Name.CustomButton.UseSelectable = true;
            this.t_P_Name.CustomButton.Visible = false;
            this.t_P_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_P_Name.Lines = new string[0];
            this.t_P_Name.Location = new System.Drawing.Point(110, 93);
            this.t_P_Name.MaxLength = 32767;
            this.t_P_Name.Name = "t_P_Name";
            this.t_P_Name.PasswordChar = '\0';
            this.t_P_Name.PromptText = "Enter the product name";
            this.t_P_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_P_Name.SelectedText = "";
            this.t_P_Name.SelectionLength = 0;
            this.t_P_Name.SelectionStart = 0;
            this.t_P_Name.ShortcutsEnabled = true;
            this.t_P_Name.Size = new System.Drawing.Size(168, 23);
            this.t_P_Name.TabIndex = 6;
            this.t_P_Name.UseSelectable = true;
            this.t_P_Name.WaterMark = "Enter the product name";
            this.t_P_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.t_P_Name.WaterMarkFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // l_P_Type
            // 
            this.l_P_Type.AutoSize = true;
            this.l_P_Type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_P_Type.Location = new System.Drawing.Point(15, 148);
            this.l_P_Type.Name = "l_P_Type";
            this.l_P_Type.Size = new System.Drawing.Size(89, 19);
            this.l_P_Type.TabIndex = 4;
            this.l_P_Type.Text = "Product Type:";
            // 
            // l_P_N
            // 
            this.l_P_N.AutoSize = true;
            this.l_P_N.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_P_N.Location = new System.Drawing.Point(7, 97);
            this.l_P_N.Name = "l_P_N";
            this.l_P_N.Size = new System.Drawing.Size(98, 19);
            this.l_P_N.TabIndex = 3;
            this.l_P_N.Text = "Product Name:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Moccasin;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(489, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(304, 54);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(886, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "Product";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Product";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu Add;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discountToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton bAdd;
        private MetroFramework.Controls.MetroButton bRefresh;
        private MetroFramework.Controls.MetroButton bDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox t_P_Type;
        private MetroFramework.Controls.MetroTextBox t_P_Name;
        private MetroFramework.Controls.MetroLabel l_P_Type;
        private MetroFramework.Controls.MetroLabel l_P_N;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton bBack;
        private MetroFramework.Controls.MetroTextBox t_P_Price;
        private MetroFramework.Controls.MetroLabel l_P_P;
        private MetroFramework.Controls.MetroTextBox t_P_Id;
        private MetroFramework.Controls.MetroLabel l_P_I;
    }
}