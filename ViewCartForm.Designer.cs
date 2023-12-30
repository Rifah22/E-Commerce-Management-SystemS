namespace UserPanel
{
    partial class ViewCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsPanelViewCart = new MetroFramework.Controls.MetroPanel();
            this.BackToProductListBtn = new MetroFramework.Controls.MetroButton();
            this.RoketOptBtn = new MetroFramework.Controls.MetroButton();
            this.NogodOptBtn = new MetroFramework.Controls.MetroButton();
            this.BkashOptBtn = new MetroFramework.Controls.MetroButton();
            this.PamentOptLabel = new MetroFramework.Controls.MetroLabel();
            this.ProListExitBtn = new MetroFramework.Controls.MetroButton();
            this.OrderGridView = new MetroFramework.Controls.MetroGrid();
            this.dgvOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.ButtonsPanelViewCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonsPanelViewCart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonsPanelViewCart
            // 
            this.ButtonsPanelViewCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsPanelViewCart.Controls.Add(this.HistoryBtn);
            this.ButtonsPanelViewCart.Controls.Add(this.BackToProductListBtn);
            this.ButtonsPanelViewCart.Controls.Add(this.RoketOptBtn);
            this.ButtonsPanelViewCart.Controls.Add(this.NogodOptBtn);
            this.ButtonsPanelViewCart.Controls.Add(this.BkashOptBtn);
            this.ButtonsPanelViewCart.Controls.Add(this.PamentOptLabel);
            this.ButtonsPanelViewCart.Controls.Add(this.ProListExitBtn);
            this.ButtonsPanelViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanelViewCart.HorizontalScrollbarBarColor = true;
            this.ButtonsPanelViewCart.HorizontalScrollbarHighlightOnWheel = false;
            this.ButtonsPanelViewCart.HorizontalScrollbarSize = 10;
            this.ButtonsPanelViewCart.Location = new System.Drawing.Point(3, 3);
            this.ButtonsPanelViewCart.Name = "ButtonsPanelViewCart";
            this.ButtonsPanelViewCart.Size = new System.Drawing.Size(801, 44);
            this.ButtonsPanelViewCart.TabIndex = 0;
            this.ButtonsPanelViewCart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonsPanelViewCart.VerticalScrollbarBarColor = true;
            this.ButtonsPanelViewCart.VerticalScrollbarHighlightOnWheel = false;
            this.ButtonsPanelViewCart.VerticalScrollbarSize = 10;
            // 
            // BackToProductListBtn
            // 
            this.BackToProductListBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BackToProductListBtn.Location = new System.Drawing.Point(596, 3);
            this.BackToProductListBtn.Name = "BackToProductListBtn";
            this.BackToProductListBtn.Size = new System.Drawing.Size(96, 34);
            this.BackToProductListBtn.TabIndex = 9;
            this.BackToProductListBtn.Text = "Back";
            this.BackToProductListBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BackToProductListBtn.UseSelectable = true;
            this.BackToProductListBtn.Click += new System.EventHandler(this.BackToProductListBtn_Click);
            // 
            // RoketOptBtn
            // 
            this.RoketOptBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.RoketOptBtn.Location = new System.Drawing.Point(390, 3);
            this.RoketOptBtn.Name = "RoketOptBtn";
            this.RoketOptBtn.Size = new System.Drawing.Size(96, 34);
            this.RoketOptBtn.TabIndex = 8;
            this.RoketOptBtn.Text = "Roket";
            this.RoketOptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RoketOptBtn.UseSelectable = true;
            this.RoketOptBtn.Click += new System.EventHandler(this.RoketOptBtn_Click);
            // 
            // NogodOptBtn
            // 
            this.NogodOptBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NogodOptBtn.Location = new System.Drawing.Point(288, 3);
            this.NogodOptBtn.Name = "NogodOptBtn";
            this.NogodOptBtn.Size = new System.Drawing.Size(96, 34);
            this.NogodOptBtn.TabIndex = 7;
            this.NogodOptBtn.Text = "Nogod";
            this.NogodOptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NogodOptBtn.UseSelectable = true;
            this.NogodOptBtn.Click += new System.EventHandler(this.NogodOptBtn_Click);
            // 
            // BkashOptBtn
            // 
            this.BkashOptBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BkashOptBtn.Location = new System.Drawing.Point(186, 3);
            this.BkashOptBtn.Name = "BkashOptBtn";
            this.BkashOptBtn.Size = new System.Drawing.Size(96, 34);
            this.BkashOptBtn.TabIndex = 6;
            this.BkashOptBtn.Text = "bkash";
            this.BkashOptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BkashOptBtn.UseSelectable = true;
            this.BkashOptBtn.Click += new System.EventHandler(this.BkashOptBtn_Click);
            // 
            // PamentOptLabel
            // 
            this.PamentOptLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PamentOptLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PamentOptLabel.Location = new System.Drawing.Point(3, 3);
            this.PamentOptLabel.Name = "PamentOptLabel";
            this.PamentOptLabel.Size = new System.Drawing.Size(176, 34);
            this.PamentOptLabel.TabIndex = 5;
            this.PamentOptLabel.Text = "Payment Option:";
            this.PamentOptLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProListExitBtn
            // 
            this.ProListExitBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProListExitBtn.Location = new System.Drawing.Point(698, 3);
            this.ProListExitBtn.Name = "ProListExitBtn";
            this.ProListExitBtn.Size = new System.Drawing.Size(96, 34);
            this.ProListExitBtn.TabIndex = 4;
            this.ProListExitBtn.Text = "Exit";
            this.ProListExitBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProListExitBtn.UseSelectable = true;
            this.ProListExitBtn.Click += new System.EventHandler(this.ProListExitBtn_Click);
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.AllowUserToResizeRows = false;
            this.OrderGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.OrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderId,
            this.dgvUserId,
            this.dgvProductId,
            this.dgvTotalCost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.EnableHeadersVisualStyles = false;
            this.OrderGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.OrderGridView.Location = new System.Drawing.Point(3, 53);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderGridView.RowTemplate.Height = 24;
            this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridView.Size = new System.Drawing.Size(801, 428);
            this.OrderGridView.TabIndex = 1;
            this.OrderGridView.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvOrderId
            // 
            this.dgvOrderId.DataPropertyName = "Order_Id";
            this.dgvOrderId.HeaderText = "Order Id";
            this.dgvOrderId.Name = "dgvOrderId";
            this.dgvOrderId.ReadOnly = true;
            this.dgvOrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvUserId
            // 
            this.dgvUserId.DataPropertyName = "UserId";
            this.dgvUserId.HeaderText = "User Id";
            this.dgvUserId.Name = "dgvUserId";
            this.dgvUserId.ReadOnly = true;
            this.dgvUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvProductId
            // 
            this.dgvProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductId.DataPropertyName = "Product_Id";
            this.dgvProductId.HeaderText = "Product Id";
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.ReadOnly = true;
            this.dgvProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTotalCost
            // 
            this.dgvTotalCost.DataPropertyName = "Total_Cost";
            this.dgvTotalCost.HeaderText = "Total Cost";
            this.dgvTotalCost.Name = "dgvTotalCost";
            this.dgvTotalCost.ReadOnly = true;
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.HistoryBtn.Location = new System.Drawing.Point(492, 3);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(96, 34);
            this.HistoryBtn.TabIndex = 10;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HistoryBtn.UseSelectable = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // ViewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewCartForm";
            this.Text = "View Cart";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ViewCartForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ButtonsPanelViewCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel ButtonsPanelViewCart;
        private MetroFramework.Controls.MetroGrid OrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalCost;
        private MetroFramework.Controls.MetroButton RoketOptBtn;
        private MetroFramework.Controls.MetroButton NogodOptBtn;
        private MetroFramework.Controls.MetroButton BkashOptBtn;
        private MetroFramework.Controls.MetroLabel PamentOptLabel;
        private MetroFramework.Controls.MetroButton ProListExitBtn;
        private MetroFramework.Controls.MetroButton BackToProductListBtn;
        private MetroFramework.Controls.MetroButton HistoryBtn;
    }
}