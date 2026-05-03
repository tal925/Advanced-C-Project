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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ProductManagementButton_Click(object sender, EventArgs e)
        {
            // הקוד לפתיחת החלון
            new ProductListForm().ShowDialog();
        }

        private void ClientManagementButton_Click(object sender, EventArgs e)
        {
            new CustomerListForm().ShowDialog();
        }

        private void SaleManagementButton_Click(object sender, EventArgs e)
        {
            new SaleListFrom().ShowDialog();
        }
    }
}
