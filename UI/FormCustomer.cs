using BlApi;
using BO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCustomer : Form
    {
        static IBl customer_bi;

        public FormCustomer()
        {
            InitializeComponent();
            HideAllControls();
        }

        // פונקציה מרכזית לניהול התצוגה 
        private void ShowControl(Control control)
        {
            HideAllControls();
            if (control == null) return;

            if (!this.Controls.Contains(control)) this.Controls.Add(control);            
            control.Visible = true;
            control.BringToFront();
        }

        private void HideAllControls()
        {
            AddPanel.Visible = UpdatePanel.Visible = DeletePanel.Visible = dgvCustomers.Visible = false;
            if (ReadOnePanel != null) ReadOnePanel.Visible = false;
        }

        private void AddButton_Click_1(object sender, EventArgs e) => ShowControl(AddPanel);
        private void UpdateButton_Click(object sender, EventArgs e) => ShowControl(UpdatePanel);
        private void DeleteButton_Click(object sender, EventArgs e) => ShowControl(DeletePanel);

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            if (ReadOnePanel == null) MessageBox.Show("עדיין לא יצרת פאנל חיפוש ב-Designer");
            else ShowControl(ReadOnePanel);
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            ShowControl(dgvCustomers);
            try { dgvCustomers.DataSource = customer_bi.Customer.GetList().ToList(); }
            catch (Exception ex) { MessageBox.Show("שגיאה בטעינה: " + ex.Message); }
        }

        private void Approval_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("נא להזין תעודת זהות במספרים בלבד");
                return;
            }

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

        private void ApprovalUpdate_Click(object sender, EventArgs e) { }
    }
}