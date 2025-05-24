using System.Data;
using System.Web;
using Microsoft.Data.SqlClient;
using DotNetTraining.Quaries;

namespace DotNetTraining
{
    public partial class Login : Form
    {
        private readonly Data data;
        Product product;
        public Login()
        {
            InitializeComponent();
            data = new Data();
            product = new Product();
            txtUsername.Text = "Nay Zaw Oo";
            txtPassword.Text = "12009";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text.Trim();
            DataTable dt = data.Read(Query.UserLogin, new SqlParameter("@Username", username), new SqlParameter("@Password", password));
            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Your Username Or Password Incorrect!");
            }
            MessageBox.Show("successfully Login");
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            this.Hide();
            product.ShowDialog();
            this.Show();



        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
