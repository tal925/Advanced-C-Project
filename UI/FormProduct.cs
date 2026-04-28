using BL.BO;
using BlApi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormProduct : Form
    {
        static IBl product_bi;
        public FormProduct()
        {
            InitializeComponent();
        }

        // פונקציה מרכזית להצגת רכיב והסתרת השאר
        private void ShowControl(Control controlToShow)
        {
            // מסתיר את כל הפאנלים והטבלה
            AddPanel.Visible = UpdatePanel.Visible = DeletePanel.Visible = false;
            if (ReadOnePanel != null) ReadOnePanel.Visible = false;

            if (controlToShow != null)
            {
                if (!this.Controls.Contains(controlToShow)) this.Controls.Add(controlToShow);
                controlToShow.Visible = true;
                controlToShow.BringToFront();
            }
        }

        private void AddButton_Click(object sender, EventArgs e) => ShowControl(AddPanel);

        private void UpdateButton_Click(object sender, EventArgs e) => ShowControl(UpdatePanel);

        private void DeleteButton_Click(object sender, EventArgs e) => ShowControl(DeletePanel);

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            if (ReadOnePanel == null) MessageBox.Show("פאנל חיפוש לא קיים");
            else ShowControl(ReadOnePanel);
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            ShowControl(dgvProducts);
            try
            {
                dgvProducts.DataSource = product_bi.Product.GetList().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינה: " + ex.Message);
            }
        }

        private void ApprovalUpdate_Click(object sender, EventArgs e) 
        {
            try
            {
                product_bi.Product.Update(new BO.Product
                {
                    Name = txtUpdateName.Text,
                    ID = int.Parse(txtUpdateId.Text),  
                    Price = double.Parse(txtUpdatePrice.Text),
                    //Amount = int.Parse(txtUpdateAmount.Text)
                });
                MessageBox.Show("עודכן!");
                ReadAllButton_Click(null, null); 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e) 
        {
            try
            {
                product_bi.Product.Delete(int.Parse(txtDelete.Text));
                MessageBox.Show("נמחק!");
                ReadAllButton_Click(null, null); 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e) 
        {
            try
            {
                var p = product_bi.Product.GetProduct(int.Parse(txtSearchId.Text));
                txtSearchId.Text = p != null ? p.ToString() : "לא נמצא";
            }
            catch { MessageBox.Show("שגיאה בקלט"); }
        }
    }
}