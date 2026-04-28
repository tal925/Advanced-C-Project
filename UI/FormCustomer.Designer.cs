namespace UI
{
    partial class FormCustomer
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
            btnSearch = new Button();
            txtSearchId = new TextBox();
            label10 = new Label();
            dgvCustomers = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isClubMemberDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            customerBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label6 = new Label();
            btnConfirmDelete = new Button();
            ApprovalUpdate = new Button();
            textUpdatePhon = new TextBox();
            textUpdateAdress = new TextBox();
            txtUpdateId = new TextBox();
            txtUpdateName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Approval = new Button();
            txtId = new TextBox();
            textPhon = new TextBox();
            textAdress = new TextBox();
            txtName = new TextBox();
            phon = new Label();
            adress = new Label();
            label1 = new Label();
            שם = new Label();
            AddPanel.SuspendLayout();
            UpdatePanel.SuspendLayout();
            DeletePanel.SuspendLayout();
            ReadOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(675, 37);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(675, 91);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(675, 153);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(675, 207);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(94, 29);
            ReadAllButton.TabIndex = 3;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // ReadOneCustomer
            // 
            ReadOneCustomer.Location = new Point(675, 272);
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
            AddPanel.Controls.Add(txtId);
            AddPanel.Controls.Add(textPhon);
            AddPanel.Controls.Add(textAdress);
            AddPanel.Controls.Add(txtName);
            AddPanel.Controls.Add(phon);
            AddPanel.Controls.Add(adress);
            AddPanel.Controls.Add(label1);
            AddPanel.Controls.Add(שם);
            AddPanel.Location = new Point(1, 1);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(643, 415);
            AddPanel.TabIndex = 5;
            AddPanel.Visible = false;
            // 
            // UpdatePanel
            // 
            UpdatePanel.Controls.Add(DeletePanel);
            UpdatePanel.Controls.Add(ApprovalUpdate);
            UpdatePanel.Controls.Add(textUpdatePhon);
            UpdatePanel.Controls.Add(textUpdateAdress);
            UpdatePanel.Controls.Add(txtUpdateId);
            UpdatePanel.Controls.Add(txtUpdateName);
            UpdatePanel.Controls.Add(label5);
            UpdatePanel.Controls.Add(label4);
            UpdatePanel.Controls.Add(label3);
            UpdatePanel.Controls.Add(label2);
            UpdatePanel.Location = new Point(1, 1);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(643, 412);
            UpdatePanel.TabIndex = 9;
            UpdatePanel.Visible = false;
            // 
            // DeletePanel
            // 
            DeletePanel.Controls.Add(ReadOnePanel);
            DeletePanel.Controls.Add(dgvCustomers);
            DeletePanel.Controls.Add(textBox1);
            DeletePanel.Controls.Add(label6);
            DeletePanel.Controls.Add(btnConfirmDelete);
            DeletePanel.Location = new Point(1, 1);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(666, 415);
            DeletePanel.TabIndex = 12;
            DeletePanel.Visible = false;
            // 
            // ReadOnePanel
            // 
            ReadOnePanel.Controls.Add(btnSearch);
            ReadOnePanel.Controls.Add(txtSearchId);
            ReadOnePanel.Controls.Add(label10);
            ReadOnePanel.Location = new Point(1, 1);
            ReadOnePanel.Name = "ReadOnePanel";
            ReadOnePanel.Size = new Size(640, 454);
            ReadOnePanel.TabIndex = 16;
            ReadOnePanel.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(273, 188);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "חפש";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(180, 82);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(125, 27);
            txtSearchId.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(371, 86);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 0;
            label10.Text = ":הכנס ת\"ז לחיפוש";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, isClubMemberDataGridViewCheckBoxColumn });
            dgvCustomers.DataSource = customerBindingSource;
            dgvCustomers.Location = new Point(1, 1);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.Size = new Size(652, 415);
            dgvCustomers.TabIndex = 15;
            dgvCustomers.Visible = false;
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
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // isClubMemberDataGridViewCheckBoxColumn
            // 
            isClubMemberDataGridViewCheckBoxColumn.DataPropertyName = "IsClubMember";
            isClubMemberDataGridViewCheckBoxColumn.HeaderText = "IsClubMember";
            isClubMemberDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isClubMemberDataGridViewCheckBoxColumn.Name = "isClubMemberDataGridViewCheckBoxColumn";
            isClubMemberDataGridViewCheckBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(BO.Customer);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 91);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 13;
            label6.Text = ":הקש ת\"ז למחיקה";
            // 
            // btnConfirmDelete
            // 
            btnConfirmDelete.Location = new Point(224, 324);
            btnConfirmDelete.Name = "btnConfirmDelete";
            btnConfirmDelete.Size = new Size(160, 29);
            btnConfirmDelete.TabIndex = 12;
            btnConfirmDelete.Text = "מחק לקוח";
            btnConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // ApprovalUpdate
            // 
            ApprovalUpdate.Location = new Point(247, 324);
            ApprovalUpdate.Name = "ApprovalUpdate";
            ApprovalUpdate.Size = new Size(160, 29);
            ApprovalUpdate.TabIndex = 11;
            ApprovalUpdate.Text = "בצע עדכון";
            ApprovalUpdate.UseVisualStyleBackColor = true;
            ApprovalUpdate.Click += ApprovalUpdate_Click;
            // 
            // textUpdatePhon
            // 
            textUpdatePhon.Location = new Point(393, 180);
            textUpdatePhon.Name = "textUpdatePhon";
            textUpdatePhon.Size = new Size(125, 27);
            textUpdatePhon.TabIndex = 10;
            // 
            // textUpdateAdress
            // 
            textUpdateAdress.Location = new Point(393, 133);
            textUpdateAdress.Name = "textUpdateAdress";
            textUpdateAdress.Size = new Size(125, 27);
            textUpdateAdress.TabIndex = 9;
            // 
            // txtUpdateId
            // 
            txtUpdateId.Location = new Point(393, 80);
            txtUpdateId.Name = "txtUpdateId";
            txtUpdateId.Size = new Size(125, 27);
            txtUpdateId.TabIndex = 8;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(393, 27);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(125, 27);
            txtUpdateName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 184);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = ":טלפון";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 137);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = ":כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 84);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = ":ת\"ז";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 31);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = ":שם";
            // 
            // Approval
            // 
            Approval.Location = new Point(236, 324);
            Approval.Name = "Approval";
            Approval.Size = new Size(160, 29);
            Approval.TabIndex = 8;
            Approval.Text = "אישור הוספה";
            Approval.UseVisualStyleBackColor = true;
            Approval.Click += Approval_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(412, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            // 
            // textPhon
            // 
            textPhon.Location = new Point(415, 164);
            textPhon.Name = "textPhon";
            textPhon.Size = new Size(125, 27);
            textPhon.TabIndex = 6;
            // 
            // textAdress
            // 
            textAdress.Location = new Point(412, 125);
            textAdress.Name = "textAdress";
            textAdress.Size = new Size(125, 27);
            textAdress.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(412, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // phon
            // 
            phon.AutoSize = true;
            phon.Location = new Point(546, 171);
            phon.Name = "phon";
            phon.Size = new Size(47, 20);
            phon.TabIndex = 3;
            phon.Text = ":טלפון";
            // 
            // adress
            // 
            adress.AutoSize = true;
            adress.Location = new Point(546, 128);
            adress.Name = "adress";
            adress.Size = new Size(55, 20);
            adress.TabIndex = 2;
            adress.Text = ":כתובת";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 79);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = ":ת\"ז";
            // 
            // שם
            // 
            שם.AutoSize = true;
            שם.Location = new Point(543, 34);
            שם.Name = "שם";
            שם.Size = new Size(34, 20);
            שם.TabIndex = 0;
            שם.Text = ":שם";
            // 
            // FormCustomer
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
            Name = "FormCustomer";
            Text = "FormCustomer";
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            DeletePanel.ResumeLayout(false);
            DeletePanel.PerformLayout();
            ReadOnePanel.ResumeLayout(false);
            ReadOnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReadAllButton;
        private Button ReadOneCustomer;
        private Panel AddPanel;
        private Label label1;
        private Label שם;
        private Button Approval;
        private TextBox txtId;
        private TextBox textPhon;
        private TextBox textAdress;
        private TextBox txtName;
        private Label phon;
        private Label adress;
        private Panel UpdatePanel;
        private Button ApprovalUpdate;
        private TextBox textUpdatePhon;
        private TextBox textUpdateAdress;
        private TextBox txtUpdateId;
        private TextBox txtUpdateName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel DeletePanel;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private Button btnConfirmDelete;
        private DataGridView dgvCustomers;
        private Panel ReadOnePanel;
        private Button btnSearch;
        private TextBox txtSearchId;
        private Label label10;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isClubMemberDataGridViewCheckBoxColumn;
        private BindingSource customerBindingSource;
    }
}