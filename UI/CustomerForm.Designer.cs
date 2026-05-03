namespace UI
{
    partial class CustomerForm
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
            txtNameCus = new TextBox();
            txtAddressCus = new TextBox();
            txtPhoneCus = new TextBox();
            txtIdCus = new TextBox();
            IDCusLable = new Label();
            NameCusLable = new Label();
            AddressCusLable = new Label();
            PhoneCusLable = new Label();
            btnSaveCus = new Button();
            btnDeleteCus = new Button();
            SuspendLayout();
            // 
            // txtNameCus
            // 
            txtNameCus.Location = new Point(124, 122);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new Size(100, 23);
            txtNameCus.TabIndex = 0;
            // 
            // txtAddressCus
            // 
            txtAddressCus.Location = new Point(124, 176);
            txtAddressCus.Name = "txtAddressCus";
            txtAddressCus.Size = new Size(100, 23);
            txtAddressCus.TabIndex = 1;
            // 
            // txtPhoneCus
            // 
            txtPhoneCus.Location = new Point(124, 236);
            txtPhoneCus.Name = "txtPhoneCus";
            txtPhoneCus.Size = new Size(100, 23);
            txtPhoneCus.TabIndex = 2;
            // 
            // txtIdCus
            // 
            txtIdCus.Location = new Point(124, 78);
            txtIdCus.Name = "txtIdCus";
            txtIdCus.Size = new Size(100, 23);
            txtIdCus.TabIndex = 3;
            // 
            // IDCusLable
            // 
            IDCusLable.AutoSize = true;
            IDCusLable.Location = new Point(64, 81);
            IDCusLable.Name = "IDCusLable";
            IDCusLable.Size = new Size(18, 15);
            IDCusLable.TabIndex = 4;
            IDCusLable.Text = "ID";
            // 
            // NameCusLable
            // 
            NameCusLable.AutoSize = true;
            NameCusLable.Location = new Point(50, 125);
            NameCusLable.Name = "NameCusLable";
            NameCusLable.Size = new Size(42, 15);
            NameCusLable.TabIndex = 5;
            NameCusLable.Text = "Name:";
            // 
            // AddressCusLable
            // 
            AddressCusLable.AutoSize = true;
            AddressCusLable.Location = new Point(40, 184);
            AddressCusLable.Name = "AddressCusLable";
            AddressCusLable.Size = new Size(52, 15);
            AddressCusLable.TabIndex = 6;
            AddressCusLable.Text = "Address:";
            // 
            // PhoneCusLable
            // 
            PhoneCusLable.AutoSize = true;
            PhoneCusLable.Location = new Point(24, 239);
            PhoneCusLable.Name = "PhoneCusLable";
            PhoneCusLable.Size = new Size(86, 15);
            PhoneCusLable.TabIndex = 7;
            PhoneCusLable.Text = "Phone number";
            // 
            // btnSaveCus
            // 
            btnSaveCus.Location = new Point(412, 120);
            btnSaveCus.Name = "btnSaveCus";
            btnSaveCus.Size = new Size(173, 79);
            btnSaveCus.TabIndex = 8;
            btnSaveCus.Text = "Save";
            btnSaveCus.UseVisualStyleBackColor = true;
            btnSaveCus.Click += btnSaveCus_Click;
            // 
            // btnDeleteCus
            // 
            btnDeleteCus.Location = new Point(462, 306);
            btnDeleteCus.Name = "btnDeleteCus";
            btnDeleteCus.Size = new Size(195, 59);
            btnDeleteCus.TabIndex = 9;
            btnDeleteCus.Text = "Delete this customer";
            btnDeleteCus.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteCus);
            Controls.Add(btnSaveCus);
            Controls.Add(PhoneCusLable);
            Controls.Add(AddressCusLable);
            Controls.Add(NameCusLable);
            Controls.Add(IDCusLable);
            Controls.Add(txtIdCus);
            Controls.Add(txtPhoneCus);
            Controls.Add(txtAddressCus);
            Controls.Add(txtNameCus);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameCus;
        private TextBox txtAddressCus;
        private TextBox txtPhoneCus;
        private TextBox txtIdCus;
        private Label IDCusLable;
        private Label NameCusLable;
        private Label AddressCusLable;
        private Label PhoneCusLable;
        private Button btnSaveCus;
        private Button btnDeleteCus;
    }
}