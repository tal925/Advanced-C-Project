namespace UI
{
    partial class ProductForm
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
            BarcodeLabel1 = new Label();
            txtBarcode = new TextBox();
            NameProductLabel1 = new Label();
            txtName = new TextBox();
            PriceProductLabel1 = new Label();
            InventoryLabel2 = new Label();
            CategoryLabel3 = new Label();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            cmbCategory = new ComboBox();
            SaveButton = new Button();
            DeleteProductButton1 = new Button();
            SuspendLayout();
            // 
            // BarcodeLabel1
            // 
            BarcodeLabel1.AutoSize = true;
            BarcodeLabel1.Location = new Point(62, 40);
            BarcodeLabel1.Name = "BarcodeLabel1";
            BarcodeLabel1.Size = new Size(67, 20);
            BarcodeLabel1.TabIndex = 0;
            BarcodeLabel1.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(168, 37);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(125, 27);
            txtBarcode.TabIndex = 1;
            // 
            // NameProductLabel1
            // 
            NameProductLabel1.AutoSize = true;
            NameProductLabel1.Location = new Point(62, 97);
            NameProductLabel1.Name = "NameProductLabel1";
            NameProductLabel1.Size = new Size(52, 20);
            NameProductLabel1.TabIndex = 2;
            NameProductLabel1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // PriceProductLabel1
            // 
            PriceProductLabel1.AutoSize = true;
            PriceProductLabel1.Location = new Point(62, 153);
            PriceProductLabel1.Name = "PriceProductLabel1";
            PriceProductLabel1.Size = new Size(44, 20);
            PriceProductLabel1.TabIndex = 4;
            PriceProductLabel1.Text = "Price:";
            // 
            // InventoryLabel2
            // 
            InventoryLabel2.AutoSize = true;
            InventoryLabel2.Location = new Point(64, 211);
            InventoryLabel2.Name = "InventoryLabel2";
            InventoryLabel2.Size = new Size(65, 20);
            InventoryLabel2.TabIndex = 5;
            InventoryLabel2.Text = "Amount:";
            // 
            // CategoryLabel3
            // 
            CategoryLabel3.AutoSize = true;
            CategoryLabel3.Location = new Point(62, 270);
            CategoryLabel3.Name = "CategoryLabel3";
            CategoryLabel3.Size = new Size(72, 20);
            CategoryLabel3.TabIndex = 6;
            CategoryLabel3.Text = "Category:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(168, 146);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(168, 208);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 267);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 9;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(94, 350);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(123, 42);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save product";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductButton1
            // 
            DeleteProductButton1.Location = new Point(314, 350);
            DeleteProductButton1.Name = "DeleteProductButton1";
            DeleteProductButton1.Size = new Size(155, 42);
            DeleteProductButton1.TabIndex = 11;
            DeleteProductButton1.Text = "Delete this product";
            DeleteProductButton1.UseVisualStyleBackColor = true;
            DeleteProductButton1.Click += DeleteProductButton1_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteProductButton1);
            Controls.Add(SaveButton);
            Controls.Add(cmbCategory);
            Controls.Add(txtAmount);
            Controls.Add(txtPrice);
            Controls.Add(CategoryLabel3);
            Controls.Add(InventoryLabel2);
            Controls.Add(PriceProductLabel1);
            Controls.Add(txtName);
            Controls.Add(NameProductLabel1);
            Controls.Add(txtBarcode);
            Controls.Add(BarcodeLabel1);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BarcodeLabel1;
        private TextBox txtBarcode;
        private Label NameProductLabel1;
        private TextBox txtName;
        private Label PriceProductLabel1;
        private Label InventoryLabel2;
        private Label CategoryLabel3;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private ComboBox cmbCategory;
        private Button SaveButton;
        private Button DeleteProductButton1;
    }
}