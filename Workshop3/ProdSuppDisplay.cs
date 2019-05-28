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
    public partial class ProdSuppDisplay : Form
    {
        public ProdSuppDisplay()
        {
            InitializeComponent();
        }

        private void ProdSuppDisplay_Load(object sender, EventArgs e)
        {
            List<PkgProductsSuppliers> ps = PkgProductsSuppliers.GetPSList();            
            //PSdataGridView.DataSource = ps.Select(x => new { x.ProductName, x.SupplierName }).ToList();
            PSdataGridView.Columns["SupplierName"].Width = 200;

            List<Product> lp = Product.GetList();
            prodBox.DataSource = lp;
            prodBox.DisplayMember = "ProdName";
           // prodBox.ValueMember = "ProductId";

           // List<Supplier> ls = Supplier.GetList();
           //  suppBox.DataSource = ls;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void PSdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = PSdataGridView.Rows[e.RowIndex].Cells[0].ToString();
        }
    }
}
