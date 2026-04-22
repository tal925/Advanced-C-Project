namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierForm cashierPage = new CashierForm();
            cashierPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm nextForm = new AdminForm();
            nextForm.Show();
            this.Hide();
        }
    }
}
