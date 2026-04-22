namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCashier = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(238, 240);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(94, 29);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "מנהל";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(586, 240);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 29);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "קופאי";
            btnAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnCashier);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCashier;
        private Button btnAdmin;
    }
}
