using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormCustomer : Form
    {
        static IBl customer_bi;

        public FormCustomer()
        {
            InitializeComponent();

            // הסתרה של כל הפאנלים בטעינה הראשונה
            HideAllPanels();
        }

        // פונקציית עזר שתחסוך לך המון שורות קוד אדומות
        private void HideAllPanels()
        {
            AddPanel.Visible = false;
            UpdatePanel.Visible = false;
            DeletePanel.Visible = false;
            // אם הוספת פאנל לחיפוש בודד, ודאי שזה השם שלו ב-Properties
            if (ReadOnePanel != null) ReadOnePanel.Visible = false;
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();
            AddPanel.Visible = true;
            AddPanel.BringToFront();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(UpdatePanel))
            {
                this.Controls.Add(UpdatePanel);
            }

            HideAllPanels();

            UpdatePanel.Location = new Point(50, 50);
            UpdatePanel.Visible = true;
            UpdatePanel.BringToFront();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // מוודא שהפאנל מוצמד לטופס הראשי
            if (!this.Controls.Contains(DeletePanel))
            {
                this.Controls.Add(DeletePanel);
            }

            HideAllPanels();

            // מיקום ומרכוז
            DeletePanel.Location = new Point(50, 50);
            DeletePanel.Visible = true;
            DeletePanel.BringToFront();
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            // מוודא שהטבלה מוצמדת לטופס הראשי
            if (!this.Controls.Contains(dgvCustomers))
            {
                this.Controls.Add(dgvCustomers);
            }

            HideAllPanels();

            dgvCustomers.Location = new Point(50, 50);
            dgvCustomers.Size = new Size(500, 300);
            dgvCustomers.Visible = true;
            dgvCustomers.BringToFront();

            try
            {
                // משיכת הנתונים וחיבור לטבלה
                dgvCustomers.DataSource = customer_bi.Customer.GetList().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת הנתונים: " + ex.Message);
            }
        }

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            if (ReadOnePanel != null)
            {
                if (!this.Controls.Contains(ReadOnePanel))
                {
                    this.Controls.Add(ReadOnePanel);
                }

                HideAllPanels();

                ReadOnePanel.Location = new Point(50, 50);
                ReadOnePanel.Visible = true;
                ReadOnePanel.BringToFront();
            }
            else
            {
                MessageBox.Show("עדיין לא יצרת פאנל חיפוש ב-Designer");
            }
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
                var newCustomer = new BO.Customer
                {
                    ID = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Address = textAdress.Text,
                    Phone = textPhon.Text
                };
                customer_bi.Customer.Add(newCustomer);
                MessageBox.Show("הלקוח נוסף בהצלחה!");
                AddPanel.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("תעודת הזהות חייבת להיות מספר בלבד!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה: " + ex.Message);
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
