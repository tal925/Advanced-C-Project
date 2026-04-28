namespace UI
{
    partial class FormProduct
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
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ReadAllButton = new Button();
            ReadOneCustomer = new Button();
            AddPanel = new Panel();
            UpdatePanel = new Panel();
            DeletePanel = new Panel();
            ReadOnePanel = new Panel();
            txtSearchId = new TextBox();
            label8 = new Label();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            txtDelete = new TextBox();
            btnConfirmDelete = new Button();
            label3 = new Label();
            label5 = new Label();
            ApprovalUpdate = new Button();
            txtUpdateName = new TextBox();
            label6 = new Label();
            txtUpdatePrice = new TextBox();
            txtUpdateId = new TextBox();
            label7 = new Label();
            Approval = new Button();
            textPrice = new TextBox();
            txtId = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddPanel.SuspendLayout();
            UpdatePanel.SuspendLayout();
            DeletePanel.SuspendLayout();
            ReadOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(676, 39);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(676, 97);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(676, 157);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(676, 214);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(94, 29);
            ReadAllButton.TabIndex = 3;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // ReadOneCustomer
            // 
            ReadOneCustomer.Location = new Point(676, 278);
            ReadOneCustomer.Name = "ReadOneCustomer";
            ReadOneCustomer.Size = new Size(94, 29);
            ReadOneCustomer.TabIndex = 4;
            ReadOneCustomer.Text = "הצג בודד";
            ReadOneCustomer.UseVisualStyleBackColor = true;
            ReadOneCustomer.Click += ReadOneCustomer_Click;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(UpdatePanel);
            AddPanel.Controls.Add(Approval);
            AddPanel.Controls.Add(textPrice);
            AddPanel.Controls.Add(txtId);
            AddPanel.Controls.Add(txtName);
            AddPanel.Controls.Add(label4);
            AddPanel.Controls.Add(label2);
            AddPanel.Controls.Add(label1);
            AddPanel.Location = new Point(1, 1);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(670, 450);
            AddPanel.TabIndex = 5;
            AddPanel.Visible = false;
            // 
            // UpdatePanel
            // 
            UpdatePanel.Controls.Add(DeletePanel);
            UpdatePanel.Controls.Add(label5);
            UpdatePanel.Controls.Add(ApprovalUpdate);
            UpdatePanel.Controls.Add(txtUpdateName);
            UpdatePanel.Controls.Add(label6);
            UpdatePanel.Controls.Add(txtUpdatePrice);
            UpdatePanel.Controls.Add(txtUpdateId);
            UpdatePanel.Controls.Add(label7);
            UpdatePanel.Location = new Point(1, 1);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(669, 450);
            UpdatePanel.TabIndex = 10;
            UpdatePanel.Visible = false;
            // 
            // DeletePanel
            // 
            DeletePanel.Controls.Add(ReadOnePanel);
            DeletePanel.Controls.Add(dgvProducts);
            DeletePanel.Controls.Add(txtDelete);
            DeletePanel.Controls.Add(btnConfirmDelete);
            DeletePanel.Controls.Add(label3);
            DeletePanel.Location = new Point(1, 1);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(669, 450);
            DeletePanel.TabIndex = 7;
            DeletePanel.Visible = false;
            // 
            // ReadOnePanel
            // 
            ReadOnePanel.Controls.Add(txtSearchId);
            ReadOnePanel.Controls.Add(label8);
            ReadOnePanel.Controls.Add(btnSearch);
            ReadOnePanel.Location = new Point(1, 1);
            ReadOnePanel.Name = "ReadOnePanel";
            ReadOnePanel.Size = new Size(668, 406);
            ReadOnePanel.TabIndex = 4;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(345, 56);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(125, 27);
            txtSearchId.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 59);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 1;
            label8.Text = ":ברקוד לחיפוש";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(441, 175);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "חפש";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dgvProducts.DataSource = productBindingSource;
            dgvProducts.Location = new Point(1, 1);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(668, 403);
            dgvProducts.TabIndex = 3;
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
            // txtDelete
            // 
            txtDelete.Location = new Point(310, 59);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(125, 27);
            txtDelete.TabIndex = 2;
            // 
            // btnConfirmDelete
            // 
            btnConfirmDelete.Location = new Point(310, 324);
            btnConfirmDelete.Name = "btnConfirmDelete";
            btnConfirmDelete.Size = new Size(94, 29);
            btnConfirmDelete.TabIndex = 1;
            btnConfirmDelete.Text = "מחיקה";
            btnConfirmDelete.UseVisualStyleBackColor = true;
            btnConfirmDelete.Click += btnConfirmDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 63);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 0;
            label3.Text = ":הקש ברקוד למחיקה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 29);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = ":שם המוצר";
            // 
            // ApprovalUpdate
            // 
            ApprovalUpdate.Location = new Point(512, 247);
            ApprovalUpdate.Name = "ApprovalUpdate";
            ApprovalUpdate.Size = new Size(94, 29);
            ApprovalUpdate.TabIndex = 6;
            ApprovalUpdate.Text = "עדכן";
            ApprovalUpdate.UseVisualStyleBackColor = true;
            ApprovalUpdate.Click += ApprovalUpdate_Click;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(428, 26);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(125, 27);
            txtUpdateName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 86);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 1;
            label6.Text = ":ברקוד";
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(428, 142);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(125, 27);
            txtUpdatePrice.TabIndex = 5;
            // 
            // txtUpdateId
            // 
            txtUpdateId.Location = new Point(428, 86);
            txtUpdateId.Name = "txtUpdateId";
            txtUpdateId.Size = new Size(125, 27);
            txtUpdateId.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(584, 145);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 2;
            label7.Text = ":מחיר";
            // 
            // Approval
            // 
            Approval.Location = new Point(472, 324);
            Approval.Name = "Approval";
            Approval.Size = new Size(94, 29);
            Approval.TabIndex = 9;
            Approval.Text = "הוספה";
            Approval.UseVisualStyleBackColor = true;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(441, 162);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(125, 27);
            textPrice.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(441, 101);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(441, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 165);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = ":מחיר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 106);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = ":ברקוד";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = ":שם המוצר";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPanel);
            Controls.Add(ReadOneCustomer);
            Controls.Add(ReadAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Name = "FormProduct";
            Text = "FormProduct";
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            DeletePanel.ResumeLayout(false);
            DeletePanel.PerformLayout();
            ReadOnePanel.ResumeLayout(false);
            ReadOnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReadAllButton;
        private Button ReadOneCustomer;
        private Panel AddPanel;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox textPrice;
        private TextBox textAdress;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtUpdateName;
        private TextBox txtUpdateId;
        private TextBox txtUpdatePrice;
        private Button ApprovalUpdate;
        private Panel UpdatePanel;
        private Button Approval;
        private Panel DeletePanel;
        private Label label3;
        private TextBox txtDelete;
        private Button btnConfirmDelete;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Panel ReadOnePanel;
        private Button btnSearch;
        private TextBox txtSearchId;
        private Label label8;
    }
}