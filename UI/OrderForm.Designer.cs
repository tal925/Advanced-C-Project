namespace UI
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtProductId = new TextBox();
            btnAddProduct = new Button();
            lblQuantityTitle = new Label();
            btnOpenList = new Button();
            btnDoOrder = new Button();
            lblTotalPrice = new Label();
            numQuantity = new NumericUpDown();
            dgvCurrentOrder = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter product code";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(58, 93);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(209, 93);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(96, 29);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add to cart";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblQuantityTitle
            // 
            lblQuantityTitle.AutoSize = true;
            lblQuantityTitle.Location = new Point(490, 53);
            lblQuantityTitle.Name = "lblQuantityTitle";
            lblQuantityTitle.Size = new Size(65, 20);
            lblQuantityTitle.TabIndex = 3;
            lblQuantityTitle.Text = "Quantity";
            // 
            // btnOpenList
            // 
            btnOpenList.Location = new Point(490, 143);
            btnOpenList.Name = "btnOpenList";
            btnOpenList.Size = new Size(136, 29);
            btnOpenList.TabIndex = 4;
            btnOpenList.Text = "select from list";
            btnOpenList.UseVisualStyleBackColor = true;
            btnOpenList.Click += btnOpenList_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(381, 398);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(151, 29);
            btnDoOrder.TabIndex = 5;
            btnDoOrder.Text = "Place a final order";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(576, 398);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(118, 20);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "Total to be paid:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(490, 95);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 7;
            // 
            // dgvCurrentOrder
            // 
            dgvCurrentOrder.AutoGenerateColumns = false;
            dgvCurrentOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentOrder.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dgvCurrentOrder.DataSource = productBindingSource;
            dgvCurrentOrder.Location = new Point(12, 204);
            dgvCurrentOrder.Name = "dgvCurrentOrder";
            dgvCurrentOrder.RowHeadersWidth = 51;
            dgvCurrentOrder.RowTemplate.Height = 29;
            dgvCurrentOrder.Size = new Size(776, 188);
            dgvCurrentOrder.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            salesDataGridViewTextBoxColumn.MinimumWidth = 6;
            salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            salesDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BO.Product);
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCurrentOrder);
            Controls.Add(numQuantity);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnDoOrder);
            Controls.Add(btnOpenList);
            Controls.Add(lblQuantityTitle);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductId;
        private Button btnAddProduct;
        private Label lblQuantityTitle;
        private Button btnOpenList;
        private Button btnDoOrder;
        private Label lblTotalPrice;
        private NumericUpDown numQuantity;
        private DataGridView dgvCurrentOrder;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}