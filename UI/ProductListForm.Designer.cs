namespace UI
{
    partial class ProductListForm
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
            FilterCategoryLable = new Label();
            cmbCategoryFilter = new ComboBox();
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddingNewProductbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // FilterCategoryLable
            // 
            FilterCategoryLable.AutoSize = true;
            FilterCategoryLable.Location = new Point(52, 39);
            FilterCategoryLable.Name = "FilterCategoryLable";
            FilterCategoryLable.Size = new Size(129, 20);
            FilterCategoryLable.TabIndex = 0;
            FilterCategoryLable.Text = "Filter by Category:";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(39, 87);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(151, 28);
            cmbCategoryFilter.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(39, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(749, 207);
            dataGridView1.TabIndex = 2;
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
            // AddingNewProductbutton
            // 
            AddingNewProductbutton.Location = new Point(320, 390);
            AddingNewProductbutton.Name = "AddingNewProductbutton";
            AddingNewProductbutton.Size = new Size(200, 29);
            AddingNewProductbutton.TabIndex = 3;
            AddingNewProductbutton.Text = "Adding a new product";
            AddingNewProductbutton.UseVisualStyleBackColor = true;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddingNewProductbutton);
            Controls.Add(dataGridView1);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(FilterCategoryLable);
            Name = "ProductListForm";
            Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FilterCategoryLable;
        private ComboBox cmbCategoryFilter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button AddingNewProductbutton;
    }
}