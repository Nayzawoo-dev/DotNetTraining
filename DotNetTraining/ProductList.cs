using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DotNetTraining.Quaries;
using Microsoft.Data.SqlClient;



namespace DotNetTraining
{
    public partial class ProductList : Form
    {
        Data data;
        public ProductList()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            data = new Data();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtProductname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductprice.Focus();
            }
        }

        private void ShowData()
        {
            DataTable dt = data.Read(Query.WantedQuery);
            dgvData.DataSource = dt;
        }

        private void txtProductprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductquantity.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Name = txtProductname.Text;
            DataTable dt = data.Read(Query.invalidName, new SqlParameter("@ProductName", Name));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Invalid Product Name");
                txtProductname.Clear();
                txtProductprice.Clear();
                txtProductquantity.Clear();
                return;
            }
            string Price = txtProductprice.Text.Trim();
            string Quantity = txtProductquantity.Text.Trim();
            bool qua = int.TryParse(Quantity, out int quantity);
            bool price = decimal.TryParse(Price, out decimal pice);
            if (qua == false || price == false)
            {
                MessageBox.Show("Invalid Quantity Or Price");
                txtProductprice.Clear();
                txtProductquantity.Clear();
                return;
            }


            if (AppSetting.CurrentUser == null)
            {
                MessageBox.Show("You are not Login");
                Clear();
                return;
            }


            int res = data.Execute(Query.InsertProduct, new SqlParameter("@ProductName", Name),
                  new SqlParameter("@Price", Price),
                  new SqlParameter("@Quantity", Quantity),
                  new SqlParameter("@CreatedDateTime", DateTime.Now),
                  new SqlParameter("@CreatedByName", AppSetting.CurrentUser),
                  new SqlParameter("@CreatedById", AppSetting.CurrentUserId));
            string message = res > 0 ? "Insert Successful" : "Insert Failed";
            MessageBox.Show(message, "Inventory Management System!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            ShowData();

        }

        private void txtProductquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
        public void Clear()
        {
            txtProductname.Clear();
            txtProductprice.Clear();
            txtProductquantity.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            txtProductname.Focus();
        }

        private void txtProductprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductquantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            AppSetting.CurrentUser = null;
            AppSetting.CurrentUserId = null;
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
