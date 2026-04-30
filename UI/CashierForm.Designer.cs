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
            buttonSales.Location = new Point(145, 158);
            buttonSales.Margin = new Padding(3, 2, 3, 2);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(82, 22);
            buttonSales.TabIndex = 0;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(347, 158);
            buttonCustomer.Margin = new Padding(3, 2, 3, 2);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(82, 22);
            buttonCustomer.TabIndex = 1;
            buttonCustomer.Text = "לקוחות";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonProduct
            // 
            buttonProduct.Location = new Point(527, 158);
            buttonProduct.Margin = new Padding(3, 2, 3, 2);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(82, 22);
            buttonProduct.TabIndex = 2;
            buttonProduct.Text = "מוצרים";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonProduct);
            Controls.Add(buttonCustomer);
            Controls.Add(buttonSales);
            Margin = new Padding(3, 2, 3, 2);
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