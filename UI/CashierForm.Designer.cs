namespace UI
{
    partial class CashierForm
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
            buttonSales = new Button();
            buttonCustomer = new Button();
            buttonProduct = new Button();
            SuspendLayout();
            // 
            // buttonSales
            // 
            buttonSales.Location = new Point(154, 296);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(94, 29);
            buttonSales.TabIndex = 0;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(410, 313);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(94, 29);
            buttonCustomer.TabIndex = 1;
            buttonCustomer.Text = "לקוחות";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonProduct
            // 
            buttonProduct.Location = new Point(609, 330);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(94, 29);
            buttonProduct.TabIndex = 2;
            buttonProduct.Text = "מוצרים";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProduct);
            Controls.Add(buttonCustomer);
            Controls.Add(buttonSales);
            Name = "CashierForm";
            Text = "CashierForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSales;
        private Button buttonCustomer;
        private Button buttonProduct;
    }
}