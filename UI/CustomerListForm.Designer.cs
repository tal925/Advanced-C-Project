namespace UI
{
    partial class CustomerListForm
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
            textBoxCus = new TextBox();
            dataGridView1 = new DataGridView();
            AddClientbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxCus
            // 
            textBoxCus.Location = new Point(36, 102);
            textBoxCus.Name = "textBoxCus";
            textBoxCus.Size = new Size(124, 23);
            textBoxCus.TabIndex = 0;
            textBoxCus.Text = "Enter customer's id";
            textBoxCus.TextChanged += textBoxCus_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddClientbutton
            // 
            AddClientbutton.Location = new Point(494, 116);
            AddClientbutton.Name = "AddClientbutton";
            AddClientbutton.Size = new Size(125, 59);
            AddClientbutton.TabIndex = 2;
            AddClientbutton.Text = "Add Customer";
            AddClientbutton.UseVisualStyleBackColor = true;
            AddClientbutton.Click += AddClientbutton_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddClientbutton);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxCus);
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCus;
        private DataGridView dataGridView1;
        private Button AddClientbutton;
    }
}