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
using DataLayer;

namespace Workshop3
{
    public partial class ProdSuppDisplay : Form
    {
        int i = 0;
        public ProdSuppDisplay()
        {
            InitializeComponent();
        }

        private void ProdSuppDisplay_Load(object sender, EventArgs e)
        {
            List<PkgProductsSuppliers> ps = PkgProductsSuppliers.GetPSList();
            PSdataGridView.DataSource = ps.Select(x => new {x.ProductSupplierId, x.ProductID, x.ProductName, x.SupplierID, x.SupplierName }).ToList();
            PSdataGridView.Columns["SupplierName"].Width = 200;
            PSdataGridView.Columns["ProductID"].Visible = false;
            PSdataGridView.Columns["SupplierID"].Visible = false;
            var ii = ps.OrderByDescending(p => p.ProductSupplierId).FirstOrDefault();
            List<Product> lp = Product.GetList();

            prodBox.DisplayMember = "ProdName";
            prodBox.ValueMember = "ProductId";
            prodBox.DataSource = lp;

            List<PkgProductsSuppliers> lps = PkgProductsSuppliers.GetPSList();
            PSCombo.DisplayMember = "ProductSupplierId";
            PSCombo.ValueMember = "ProductSupplierId";
            PSCombo.DataSource = lps;



        }
      
        private void PSCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(PSCombo.SelectedValue);
            if (index == 0) index = 1;
            List<PkgProductsSuppliers> lps = PkgProductsSuppliers.GetPSList();
            List<PkgProductsSuppliers> ps = lps.Where(l => l.ProductSupplierId == index).ToList<PkgProductsSuppliers>();
            this.prodBox.SelectedValue = ps[0].ProductName;
            this.SuppBox.SelectedValue = ps[0].SupplierName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             if ((prodBox.DisplayMember != "") && (SuppBox.DisplayMember != ""))
                {
                    PkgProductsSuppliersDB.Insert_Product_Supplier(Convert.ToInt32(prodBox.ValueMember), Convert.ToInt32(SuppBox.ValueMember));
                }
        }

        private void PSdataGridView_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            //  prodBox.DisplayMember = PSdataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
          //  prodBox.ValueMember = PSdataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
          //  SuppBox.DisplayMember = PSdataGridView.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
        }
        
    }

}
