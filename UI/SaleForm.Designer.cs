namespace UI
{
    partial class SaleForm
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
            txtPriceS = new TextBox();
            txtProductS = new TextBox();
            txtAmountS = new TextBox();
            txtIDs = new TextBox();
            idLableS = new Label();
            priceLableS = new Label();
            amountLableS = new Label();
            ProductIDLableS = new Label();
            startLableS = new Label();
            endLableS = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            btnSave = new Button();
            btnDelete = new Button();
            clubLableS = new Label();
            checkBoxClub = new CheckBox();
            SuspendLayout();
            // 
            // txtPriceS
            // 
            txtPriceS.Location = new Point(220, 140);
            txtPriceS.Name = "txtPriceS";
            txtPriceS.Size = new Size(100, 23);
            txtPriceS.TabIndex = 0;
            // 
            // txtProductS
            // 
            txtProductS.Location = new Point(220, 254);
            txtProductS.Name = "txtProductS";
            txtProductS.Size = new Size(100, 23);
            txtProductS.TabIndex = 1;
            // 
            // txtAmountS
            // 
            txtAmountS.Location = new Point(220, 190);
            txtAmountS.Name = "txtAmountS";
            txtAmountS.Size = new Size(100, 23);
            txtAmountS.TabIndex = 2;
            // 
            // txtIDs
            // 
            txtIDs.Location = new Point(222, 80);
            txtIDs.Name = "txtIDs";
            txtIDs.Size = new Size(100, 23);
            txtIDs.TabIndex = 3;
            // 
            // idLableS
            // 
            idLableS.AutoSize = true;
            idLableS.Location = new Point(114, 88);
            idLableS.Name = "idLableS";
            idLableS.Size = new Size(21, 15);
            idLableS.TabIndex = 4;
            idLableS.Text = "ID:";
            // 
            // priceLableS
            // 
            priceLableS.AutoSize = true;
            priceLableS.Location = new Point(114, 140);
            priceLableS.Name = "priceLableS";
            priceLableS.Size = new Size(36, 15);
            priceLableS.TabIndex = 5;
            priceLableS.Text = "Price:";
            // 
            // amountLableS
            // 
            amountLableS.AutoSize = true;
            amountLableS.Location = new Point(114, 190);
            amountLableS.Name = "amountLableS";
            amountLableS.Size = new Size(95, 15);
            amountLableS.TabIndex = 6;
            amountLableS.Text = "Amount for sale:";
            // 
            // ProductIDLableS
            // 
            ProductIDLableS.AutoSize = true;
            ProductIDLableS.Location = new Point(114, 268);
            ProductIDLableS.Name = "ProductIDLableS";
            ProductIDLableS.Size = new Size(62, 15);
            ProductIDLableS.TabIndex = 7;
            ProductIDLableS.Text = "Product id";
            ProductIDLableS.Click += ProductIDLableS_Click;
            // 
            // startLableS
            // 
            startLableS.AutoSize = true;
            startLableS.Location = new Point(125, 362);
            startLableS.Name = "startLableS";
            startLableS.Size = new Size(30, 15);
            startLableS.TabIndex = 8;
            startLableS.Text = "start";
            // 
            // endLableS
            // 
            endLableS.AutoSize = true;
            endLableS.Location = new Point(133, 416);
            endLableS.Name = "endLableS";
            endLableS.Size = new Size(27, 15);
            endLableS.TabIndex = 9;
            endLableS.Text = "end";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(211, 360);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(226, 23);
            dateTimePickerStart.TabIndex = 10;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(211, 416);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(556, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(574, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 71);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete this sale";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // clubLableS
            // 
            clubLableS.AutoSize = true;
            clubLableS.Location = new Point(120, 322);
            clubLableS.Name = "clubLableS";
            clubLableS.Size = new Size(35, 15);
            clubLableS.TabIndex = 14;
            clubLableS.Text = "Club:";
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.Location = new Point(198, 315);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.Size = new Size(15, 14);
            checkBoxClub.TabIndex = 15;
            checkBoxClub.UseVisualStyleBackColor = true;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxClub);
            Controls.Add(clubLableS);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(endLableS);
            Controls.Add(startLableS);
            Controls.Add(ProductIDLableS);
            Controls.Add(amountLableS);
            Controls.Add(priceLableS);
            Controls.Add(idLableS);
            Controls.Add(txtIDs);
            Controls.Add(txtAmountS);
            Controls.Add(txtProductS);
            Controls.Add(txtPriceS);
            Name = "SaleForm";
            Text = "SaleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPriceS;
        private TextBox txtProductS;
        private TextBox txtAmountS;
        private TextBox txtIDs;
        private Label idLableS;
        private Label priceLableS;
        private Label amountLableS;
        private Label ProductIDLableS;
        private Label startLableS;
        private Label endLableS;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button btnSave;
        private Button btnDelete;
        private Label clubLableS;
        private CheckBox checkBoxClub;
    }
}