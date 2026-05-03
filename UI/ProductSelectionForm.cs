using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BlApi;

namespace UI
{
    public partial class ProductSelectionForm : Form
    {
        public int SelectedProductId { get; set; }

        public ProductSelectionForm()
        {
            InitializeComponent();

            try
            {
                dgvAllProducts.DataSource = Factory.Get().Product.GetList().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // בדיקה שנבחרה שורה ושהיא לא השורה הריקה החדשה
            if (dgvAllProducts.CurrentRow != null && !dgvAllProducts.CurrentRow.IsNewRow)
            {
                try
                {
                    // שליפת האובייקט המקורי שקשור לשורה (Product)
                    var selectedProduct = dgvAllProducts.CurrentRow.DataBoundItem as BO.Product;

                    if (selectedProduct != null)
                    {
                        SelectedProductId = selectedProduct.ID;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // אם DataBoundItem לא עובד, נסי לשלוף לפי אינדקס העמודה (למשל עמודה מספר 1)
                        SelectedProductId = (int)dgvAllProducts.CurrentRow.Cells[1].Value;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("נא לוודא שבחרת מוצר תקין מהרשימה.");
                }
            }
        }
    }
}