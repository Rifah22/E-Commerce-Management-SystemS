namespace UserPanel
{
    partial class OrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderGridView = new MetroFramework.Controls.MetroGrid();
            this.dgvOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsPanelViewCart = new MetroFramework.Controls.MetroPanel();
            this.ProListExitBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.ButtonsPanelViewCart.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderId,
            this.dgvUserId,
            this.dgvProductId,
            this.dgvTotalCost});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.EnableHeadersVisualStyles = false;
            this.OrderGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.OrderGridView.Location = new System.Drawing.Point(3, 53);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonsPanelViewCart
            // 
            this.ButtonsPanelViewCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderHistory";
            this.Text = "Order History";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ButtonsPanelViewCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid OrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalCost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel ButtonsPanelViewCart;
        private MetroFramework.Controls.MetroButton ProListExitBtn;
    }
}