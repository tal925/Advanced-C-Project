using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderForm : Form
    {
        readonly BlApi.IBl bl = BlApi.Factory.Get();

        BO.Order currentOrder = new BO.Order { Items = new List<BO.ProductInOrder>(), TotalPrice = 0 };

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtProductId.Text, out int pId))
                {
                    // קודם בדיקה שהמוצר קיים ב-BL — אם לא, להראות הודעה מתאימה
                    try
                    {
                        var prod = bl.Product.GetProduct(pId);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("המוצר לא נמצא. בדוק את מספר המוצר ותנסה שוב.", "מוצר לא נמצא", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // כל הלוגיקה שהייתה כאן עברה לתוך הפונקציה הזו
                    HandleAddingProduct(pId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void HandleAddingProduct(int pId)
        {
            try
            {
                // קבלת הכמות מהפקד בטופס
                int amount = (int)numQuantity.Value;

                // שליחה ל-BL - הוא מעדכן את הרשימה בתוך currentOrder ואת המחיר endPrice
                bl.Order.AddProductToOrder(currentOrder, pId, amount);

                // עדכון הטבלה - שימוש ב-ToList מבטיח שה-DataGridView יזהה שינויים
                dgvCurrentOrder.DataSource = null;
                if (currentOrder.Items != null)
                {
                    dgvCurrentOrder.DataSource = currentOrder.Items.ToList();
                }

                // עדכון המחיר הסופי שמוצג למשתמש
                lblTotalPrice.Text = $"Total: ${currentOrder.TotalPrice:F2}";

                // איפוס שדות הקלט לנוחות המשתמש
                txtProductId.Clear();
                numQuantity.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            // יצירת מופע של חלון בחירת המוצרים
            ProductSelectionForm listForm = new ProductSelectionForm();

            if (listForm.ShowDialog() == DialogResult.OK)
            {
                txtProductId.Text = listForm.SelectedProductId.ToString();

                // השורה שהוספנו להפעלה אוטומטית:
                HandleAddingProduct(listForm.SelectedProductId);
            }
        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            // בדיקה אם העגלה ריקה לפני ביצוע הזמנה סופית
            if (currentOrder.Items == null || !currentOrder.Items.Any())
            {
                MessageBox.Show("The cart is empty.");
                return;
            }
            try
            {
                // שליחת ההזמנה המוכנה לביצוע סופי ב-Logic
                Factory.Get().Order.DoOrder(currentOrder);

                MessageBox.Show("The order has been placed successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place order: " + ex.Message);
            }
        }
    }
}
