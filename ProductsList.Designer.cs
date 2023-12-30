namespace UserPanel
{
    partial class ProductsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductyTblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProductyTblLayoutOptPanel = new MetroFramework.Controls.MetroPanel();
            this.ProListExitBtn = new MetroFramework.Controls.MetroButton();
            this.ViewCartBtn = new MetroFramework.Controls.MetroButton();
            this.ProductListGrid = new MetroFramework.Controls.MetroGrid();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductyTblLayoutPanel.SuspendLayout();
            this.ProductyTblLayoutOptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductyTblLayoutPanel
            // 
            this.ProductyTblLayoutPanel.ColumnCount = 1;
            this.ProductyTblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductyTblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ProductyTblLayoutPanel.Controls.Add(this.ProductyTblLayoutOptPanel, 0, 0);
            this.ProductyTblLayoutPanel.Controls.Add(this.ProductListGrid, 0, 1);
            this.ProductyTblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductyTblLayoutPanel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductyTblLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.ProductyTblLayoutPanel.Name = "ProductyTblLayoutPanel";
            this.ProductyTblLayoutPanel.RowCount = 2;
            this.ProductyTblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ProductyTblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProductyTblLayoutPanel.Size = new System.Drawing.Size(1050, 581);
            this.ProductyTblLayoutPanel.TabIndex = 0;
            // 
            // ProductyTblLayoutOptPanel
            // 
            this.ProductyTblLayoutOptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductyTblLayoutOptPanel.Controls.Add(this.ProListExitBtn);
            this.ProductyTblLayoutOptPanel.Controls.Add(this.ViewCartBtn);
            this.ProductyTblLayoutOptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductyTblLayoutOptPanel.HorizontalScrollbarBarColor = true;
            this.ProductyTblLayoutOptPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ProductyTblLayoutOptPanel.HorizontalScrollbarSize = 10;
            this.ProductyTblLayoutOptPanel.Location = new System.Drawing.Point(3, 3);
            this.ProductyTblLayoutOptPanel.Name = "ProductyTblLayoutOptPanel";
            this.ProductyTblLayoutOptPanel.Size = new System.Drawing.Size(1044, 44);
            this.ProductyTblLayoutOptPanel.TabIndex = 0;
            this.ProductyTblLayoutOptPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProductyTblLayoutOptPanel.VerticalScrollbarBarColor = true;
            this.ProductyTblLayoutOptPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ProductyTblLayoutOptPanel.VerticalScrollbarSize = 10;
            // 
            // ProListExitBtn
            // 
            this.ProListExitBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProListExitBtn.Location = new System.Drawing.Point(941, 3);
            this.ProListExitBtn.Name = "ProListExitBtn";
            this.ProListExitBtn.Size = new System.Drawing.Size(96, 34);
            this.ProListExitBtn.TabIndex = 3;
            this.ProListExitBtn.Text = "Exit";
            this.ProListExitBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProListExitBtn.UseSelectable = true;
            this.ProListExitBtn.Click += new System.EventHandler(this.ProListExitBtn_Click);
            // 
            // ViewCartBtn
            // 
            this.ViewCartBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ViewCartBtn.Location = new System.Drawing.Point(3, 3);
            this.ViewCartBtn.Name = "ViewCartBtn";
            this.ViewCartBtn.Size = new System.Drawing.Size(156, 34);
            this.ViewCartBtn.TabIndex = 2;
            this.ViewCartBtn.Text = "View Cart";
            this.ViewCartBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ViewCartBtn.UseSelectable = true;
            this.ViewCartBtn.Click += new System.EventHandler(this.ViewCartBtn_Click);
            // 
            // ProductListGrid
            // 
            this.ProductListGrid.AllowUserToAddRows = false;
            this.ProductListGrid.AllowUserToDeleteRows = false;
            this.ProductListGrid.AllowUserToResizeRows = false;
            this.ProductListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProductListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvName,
            this.dgvType,
            this.dgvPrice});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductListGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProductListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductListGrid.EnableHeadersVisualStyles = false;
            this.ProductListGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProductListGrid.Location = new System.Drawing.Point(3, 53);
            this.ProductListGrid.Name = "ProductListGrid";
            this.ProductListGrid.ReadOnly = true;
            this.ProductListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductListGrid.RowTemplate.Height = 24;
            this.ProductListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductListGrid.Size = new System.Drawing.Size(1044, 525);
            this.ProductListGrid.TabIndex = 1;
            this.ProductListGrid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProductListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListGrid_CellClick);
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "Product_Id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvId.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvId.HeaderText = "Product ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "Product_Name";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvName.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvType
            // 
            this.dgvType.DataPropertyName = "Product_Type";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvType.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvType.HeaderText = "Product Type";
            this.dgvType.Name = "dgvType";
            this.dgvType.ReadOnly = true;
            this.dgvType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Product_Price";
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 661);
            this.Controls.Add(this.ProductyTblLayoutPanel);
            this.Name = "ProductsList";
            this.Text = "Products List";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ProductsList_Load);
            this.ProductyTblLayoutPanel.ResumeLayout(false);
            this.ProductyTblLayoutOptPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ProductyTblLayoutPanel;
        private MetroFramework.Controls.MetroPanel ProductyTblLayoutOptPanel;
        private MetroFramework.Controls.MetroButton ViewCartBtn;
        private MetroFramework.Controls.MetroGrid ProductListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private MetroFramework.Controls.MetroButton ProListExitBtn;
    }
}