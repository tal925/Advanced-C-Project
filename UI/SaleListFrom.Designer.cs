namespace UI
{
    partial class SaleListFrom
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
            button1 = new Button();
            textBoxSale = new TextBox();
            dataGridViewSales = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceSaleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isClubMemberDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSource = new BindingSource(components);
            readAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(532, 33);
            button1.Name = "button1";
            button1.Size = new Size(127, 51);
            button1.TabIndex = 0;
            button1.Text = "Add Sale";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSale
            // 
            textBoxSale.Location = new Point(120, 118);
            textBoxSale.Name = "textBoxSale";
            textBoxSale.Size = new Size(190, 23);
            textBoxSale.TabIndex = 1;
            textBoxSale.Text = "Enter sale's id";
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, priceSaleDataGridViewTextBoxColumn, isClubMemberDataGridViewCheckBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dataGridViewSales.DataSource = saleBindingSource;
            dataGridViewSales.Location = new Point(12, 239);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowTemplate.Height = 25;
            dataGridViewSales.Size = new Size(742, 150);
            dataGridViewSales.TabIndex = 2;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // priceSaleDataGridViewTextBoxColumn
            // 
            priceSaleDataGridViewTextBoxColumn.DataPropertyName = "PriceSale";
            priceSaleDataGridViewTextBoxColumn.HeaderText = "PriceSale";
            priceSaleDataGridViewTextBoxColumn.Name = "priceSaleDataGridViewTextBoxColumn";
            // 
            // isClubMemberDataGridViewCheckBoxColumn
            // 
            isClubMemberDataGridViewCheckBoxColumn.DataPropertyName = "IsClubMember";
            isClubMemberDataGridViewCheckBoxColumn.HeaderText = "IsClubMember";
            isClubMemberDataGridViewCheckBoxColumn.Name = "isClubMemberDataGridViewCheckBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // salesDataGridViewTextBoxColumn
            // 
            salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(BO.Sale);
            // 
            // readAll
            // 
            readAll.Location = new Point(528, 119);
            readAll.Name = "readAll";
            readAll.Size = new Size(127, 44);
            readAll.TabIndex = 3;
            readAll.Text = "readAll";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // SaleListFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(readAll);
            Controls.Add(dataGridViewSales);
            Controls.Add(textBoxSale);
            Controls.Add(button1);
            Name = "SaleListFrom";
            Text = "SaleListFrom";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxSale;
        private DataGridView dataGridViewSales;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceSaleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isClubMemberDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource saleBindingSource;
        private Button readAll;
    }
}