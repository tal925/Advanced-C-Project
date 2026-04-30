using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminForm : Form
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        List<BO.ProductInOrder> currentProductInOrder = new List<BO.ProductInOrder>();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAddById_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtProductId.Text, out int id))
                {
                    MessageBox.Show("קוד מוצר חייב להיות מספר");
                    return;
                }

                var product = bl.Product.GetProduct(id);
                var existingItem = currentProductInOrder.FirstOrDefault(i => i.ProductID == product.ID);

                if (existingItem != null)
                {
                    existingItem.Amount++;
                }
                else
                {
                    currentProductInOrder.Add(new BO.ProductInOrder
                    {
                        ProductID = product.ID,
                        Name = product.Name,
                        BasePrice = product.Price,
                        Amount = 1
                    });
                }

                refreshGrid();
                txtProductId.Clear();
                txtProductId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה: " + ex.Message);
            }
        }

        private void refreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = currentProductInOrder.ToList();
            double total = currentProductInOrder.Sum(item => item.BasePrice * item.Amount);
            lblTotalPrice.Text = $"סה\"כ לתשלום: {total:C}";
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProductInOrder.Count == 0) throw new Exception("הסל ריק!");

                BO.Order newOrder = new BO.Order
                {
                    Items = currentProductInOrder,
                    OrderDate = DateTime.Now,
                    TotalPrice = currentProductInOrder.Sum(item => item.BasePrice * item.Amount) // עדכון המחיר הסופי
                };

                bl.Order.DoOrder(newOrder); // שמירה ב-DAL
                MessageBox.Show("ההזמנה בוצעה בהצלחה!");
                currentProductInOrder.Clear();
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("תקלה בביצוע ההזמנה: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinalize_Click_1(object sender, EventArgs e)
        {

        }
    }
}