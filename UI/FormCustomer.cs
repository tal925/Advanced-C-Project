using BlApi;
using BO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCustomer : Form
    {
        IBl customer_bi; // הסרת static כדי למנוע התנגשויות

        public FormCustomer()
        {
            InitializeComponent();
            customer_bi = BlApi.Factory.Get(); // אתחול קריטי!
            HideAllControls();
        }

        private void ShowControl(Control control)
        {
            HideAllControls();
            if (control == null) return;
            control.Visible = true;
            control.BringToFront();
        }

        private void HideAllControls()
        {
            AddPanel.Visible = UpdatePanel.Visible = DeletePanel.Visible = dgvCustomers.Visible = false;
        }

        private void AddButton_Click_1(object sender, EventArgs e) => ShowControl(AddPanel);
        private void UpdateButton_Click(object sender, EventArgs e) => ShowControl(UpdatePanel);
        private void DeleteButton_Click(object sender, EventArgs e) => ShowControl(DeletePanel);

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowControl(dgvCustomers);
                dgvCustomers.DataSource = customer_bi.Customer.GetList().ToList();
            }
            catch (Exception ex) { MessageBox.Show("שגיאה בטעינה: " + ex.Message); }
        }

        private void Approval_Click(object sender, EventArgs e)
        {
            try
            {
                customer_bi.Customer.Add(new BO.Customer
                {
                    ID = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Address = textAdress.Text,
                    Phone = textPhon.Text
                });
                MessageBox.Show("הלקוח נוסף בהצלחה!");
                AddPanel.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("שגיאה: " + ex.Message); }
        }

        // הוסיפי את אלו בתוך המחלקה, מתחת ל-Approval_Click
        private void ApprovalUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // לוגיקה לעדכון לקוח
                MessageBox.Show("עדכון בוצע");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            ShowControl(ReadOnePanel); // וודאי שקראת לפאנל הזה כך
        }
    }

}
