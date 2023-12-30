namespace UserPanel
{
    partial class AddCart
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
            this.ProductDesLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.AddCartBtn = new MetroFramework.Controls.MetroButton();
            this.QuantityLabel = new MetroFramework.Controls.MetroLabel();
            this.QuantityTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PlusButton = new MetroFramework.Controls.MetroButton();
            this.MinusButton = new MetroFramework.Controls.MetroButton();
            this.PriceLabel = new MetroFramework.Controls.MetroLabel();
            this.TotalPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductPriceTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.TotalPriceTxtBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDesLabel
            // 
            this.ProductDesLabel.Location = new System.Drawing.Point(426, 76);
            this.ProductDesLabel.Name = "ProductDesLabel";
            this.ProductDesLabel.Size = new System.Drawing.Size(351, 117);
            this.ProductDesLabel.TabIndex = 1;
            this.ProductDesLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProductDesLabel.WrapToLine = true;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(23, 76);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(397, 351);
            this.ProductPictureBox.TabIndex = 0;
            this.ProductPictureBox.TabStop = false;
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCartBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddCartBtn.Location = new System.Drawing.Point(534, 392);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(219, 35);
            this.AddCartBtn.TabIndex = 2;
            this.AddCartBtn.Text = "Add To Cart";
            this.AddCartBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddCartBtn.UseSelectable = true;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.QuantityLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.QuantityLabel.Location = new System.Drawing.Point(441, 324);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(122, 34);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "Quantity:";
            this.QuantityLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // QuantityTxtBox
            // 
            // 
            // 
            // 
            this.QuantityTxtBox.CustomButton.Image = null;
            this.QuantityTxtBox.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.QuantityTxtBox.CustomButton.Name = "";
            this.QuantityTxtBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.QuantityTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTxtBox.CustomButton.TabIndex = 1;
            this.QuantityTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTxtBox.CustomButton.UseSelectable = true;
            this.QuantityTxtBox.CustomButton.Visible = false;
            this.QuantityTxtBox.Lines = new string[0];
            this.QuantityTxtBox.Location = new System.Drawing.Point(645, 325);
            this.QuantityTxtBox.MaxLength = 32767;
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.PasswordChar = '\0';
            this.QuantityTxtBox.ReadOnly = true;
            this.QuantityTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTxtBox.SelectedText = "";
            this.QuantityTxtBox.SelectionLength = 0;
            this.QuantityTxtBox.SelectionStart = 0;
            this.QuantityTxtBox.ShortcutsEnabled = true;
            this.QuantityTxtBox.Size = new System.Drawing.Size(62, 33);
            this.QuantityTxtBox.TabIndex = 4;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.QuantityTxtBox.UseSelectable = true;
            this.QuantityTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PlusButton
            // 
            this.PlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.PlusButton.Location = new System.Drawing.Point(599, 324);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(40, 35);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.Text = "+";
            this.PlusButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlusButton.UseSelectable = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MinusButton.Location = new System.Drawing.Point(713, 324);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(40, 35);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MinusButton.UseSelectable = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PriceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PriceLabel.Location = new System.Drawing.Point(441, 224);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(122, 34);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalPriceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TotalPriceLabel.Location = new System.Drawing.Point(441, 272);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(154, 34);
            this.TotalPriceLabel.TabIndex = 8;
            this.TotalPriceLabel.Text = "Total Price:";
            this.TotalPriceLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProductPriceTxtBox
            // 
            // 
            // 
            // 
            this.ProductPriceTxtBox.CustomButton.Image = null;
            this.ProductPriceTxtBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.ProductPriceTxtBox.CustomButton.Name = "";
            this.ProductPriceTxtBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductPriceTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductPriceTxtBox.CustomButton.TabIndex = 1;
            this.ProductPriceTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductPriceTxtBox.CustomButton.UseSelectable = true;
            this.ProductPriceTxtBox.CustomButton.Visible = false;
            this.ProductPriceTxtBox.Lines = new string[0];
            this.ProductPriceTxtBox.Location = new System.Drawing.Point(601, 225);
            this.ProductPriceTxtBox.MaxLength = 32767;
            this.ProductPriceTxtBox.Name = "ProductPriceTxtBox";
            this.ProductPriceTxtBox.PasswordChar = '\0';
            this.ProductPriceTxtBox.ReadOnly = true;
            this.ProductPriceTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductPriceTxtBox.SelectedText = "";
            this.ProductPriceTxtBox.SelectionLength = 0;
            this.ProductPriceTxtBox.SelectionStart = 0;
            this.ProductPriceTxtBox.ShortcutsEnabled = true;
            this.ProductPriceTxtBox.Size = new System.Drawing.Size(152, 33);
            this.ProductPriceTxtBox.TabIndex = 9;
            this.ProductPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductPriceTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProductPriceTxtBox.UseSelectable = true;
            this.ProductPriceTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductPriceTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TotalPriceTxtBox
            // 
            // 
            // 
            // 
            this.TotalPriceTxtBox.CustomButton.Image = null;
            this.TotalPriceTxtBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.TotalPriceTxtBox.CustomButton.Name = "";
            this.TotalPriceTxtBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TotalPriceTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalPriceTxtBox.CustomButton.TabIndex = 1;
            this.TotalPriceTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalPriceTxtBox.CustomButton.UseSelectable = true;
            this.TotalPriceTxtBox.CustomButton.Visible = false;
            this.TotalPriceTxtBox.Lines = new string[0];
            this.TotalPriceTxtBox.Location = new System.Drawing.Point(601, 273);
            this.TotalPriceTxtBox.MaxLength = 32767;
            this.TotalPriceTxtBox.Name = "TotalPriceTxtBox";
            this.TotalPriceTxtBox.PasswordChar = '\0';
            this.TotalPriceTxtBox.ReadOnly = true;
            this.TotalPriceTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalPriceTxtBox.SelectedText = "";
            this.TotalPriceTxtBox.SelectionLength = 0;
            this.TotalPriceTxtBox.SelectionStart = 0;
            this.TotalPriceTxtBox.ShortcutsEnabled = true;
            this.TotalPriceTxtBox.Size = new System.Drawing.Size(152, 33);
            this.TotalPriceTxtBox.TabIndex = 10;
            this.TotalPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPriceTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TotalPriceTxtBox.UseSelectable = true;
            this.TotalPriceTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalPriceTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPriceTxtBox);
            this.Controls.Add(this.ProductPriceTxtBox);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.AddCartBtn);
            this.Controls.Add(this.ProductDesLabel);
            this.Controls.Add(this.ProductPictureBox);
            this.Name = "AddCart";
            this.Text = "Add To Cart";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPictureBox;
        private MetroFramework.Controls.MetroLabel ProductDesLabel;
        private MetroFramework.Controls.MetroButton AddCartBtn;
        private MetroFramework.Controls.MetroLabel QuantityLabel;
        private MetroFramework.Controls.MetroTextBox QuantityTxtBox;
        private MetroFramework.Controls.MetroButton PlusButton;
        private MetroFramework.Controls.MetroButton MinusButton;
        private MetroFramework.Controls.MetroLabel PriceLabel;
        private MetroFramework.Controls.MetroLabel TotalPriceLabel;
        private MetroFramework.Controls.MetroTextBox ProductPriceTxtBox;
        private MetroFramework.Controls.MetroTextBox TotalPriceTxtBox;
    }
}