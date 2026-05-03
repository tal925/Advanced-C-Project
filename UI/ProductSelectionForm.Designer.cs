namespace UI
{
    partial class ProductSelectionForm
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
            dgvAllProducts = new DataGridView();
            productBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnSelect = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAllProducts
            // 
            dgvAllProducts.AutoGenerateColumns = false;
            dgvAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllProducts.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dgvAllProducts.DataSource = productBindingSource;
            dgvAllProducts.Location = new Point(40, 183);
            dgvAllProducts.Name = "dgvAllProducts";
            dgvAllProducts.RowHeadersWidth = 51;
            dgvAllProducts.RowTemplate.Height = 29;
            dgvAllProducts.Size = new Size(748, 192);
            dgvAllProducts.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BO.Product);
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
            // btnSelect
            // 
            btnSelect.Location = new Point(319, 398);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(173, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select a product";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 2;
            label1.Text = "Search by name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(193, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 70);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 4;
            label2.Text = "To view all products";
            // 
            // ProductSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSelect);
            Controls.Add(dgvAllProducts);
            Name = "ProductSelectionForm";
            Text = "ProductSelectionForm";
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllProducts;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button btnSelect;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtSearch;
        private Label label2;
    }
}