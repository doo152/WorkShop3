using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Workshop3
{
    public partial class ProductsDisplay : Form
    {
        public ProductsDisplay()
        {
            InitializeComponent();
        }
        private void ProductsDisplay_Load(object sender, EventArgs e)
        {
        }

        private void ProductsDisplay_Load_1(object sender, EventArgs e)
        {
            List<Product> products = Product.GetList();
            //datProducts.Rows.Clear();
            foreach (Product pn in products)
            {
                datProduct.Rows.Add(pn.ProdName);
            }

        }
    }
}


