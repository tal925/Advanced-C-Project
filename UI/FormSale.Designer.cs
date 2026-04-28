namespace UI
{
    partial class FormSale
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
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ReadAllButton = new Button();
            AddPanel = new Panel();
            txtNameSale = new TextBox();
            label1 = new Label();
            AddPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(670, 72);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(670, 125);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(670, 174);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(670, 223);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(94, 29);
            ReadAllButton.TabIndex = 3;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(txtNameSale);
            AddPanel.Controls.Add(label1);
            AddPanel.Location = new Point(1, 1);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(663, 451);
            AddPanel.TabIndex = 4;
            AddPanel.Visible = false;
            AddPanel.Paint += AddPanel_Paint;
            // 
            // txtNameSale
            // 
            txtNameSale.Location = new Point(382, 40);
            txtNameSale.Name = "txtNameSale";
            txtNameSale.Size = new Size(125, 27);
            txtNameSale.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(533, 40);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = ":שם המוצר";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPanel);
            Controls.Add(ReadAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Name = "FormSale";
            Text = "FormSale";
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReadAllButton;
        private Panel AddPanel;
        private Label label1;
        private TextBox txtNameSale;
    }
}