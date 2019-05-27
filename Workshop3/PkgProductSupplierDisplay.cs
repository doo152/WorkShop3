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
    public partial class PkgProductSupplierDisplay : Form
    {
        public PkgProductSupplierDisplay()
        {
            InitializeComponent();
        }
        
        private void PkgProductSupplier_Load(object sender, EventArgs e)
        {
            List<PkgProductsSuppliers> pps = PkgProductsSuppliers.GetPPSList();

            PPSGridView.DataSource = pps;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
