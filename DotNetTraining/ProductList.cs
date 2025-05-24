using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetTraining.Quaries;



namespace DotNetTraining
{
    public partial class ProductList : Form
    {
        Data data;
        public ProductList()
        {
            InitializeComponent();
            data = new Data();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
          DataTable dt =  data.Read(Query.ProductList);
            dgvData.DataSource = dt;
        }
    }
}
