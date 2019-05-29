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
    public partial class Main : Form
    {

        // variables: product, supplier, product-supplier-Id, Product-Id, Supplier-Id
        public string prod, supp;
        public int PSId, Pid, Sid;


        public Main()
        {
            InitializeComponent();
        }

        private void PackagesDisplay_Load(object sender, EventArgs e)
        {
            Global.packages = Package.GetList();
            Global.Products = Product.GetList();
            Global.suppliers = Supplier.GetList();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datPackages.SelectedRows.Count > 0)
            {
                Global.indexToEdit = datPackages.SelectedRows[0].Index;
                PackageDetails newForm = new PackageDetails();
                newForm.Show();
            }
        }

        private void datPackages_DoubleClick(object sender, EventArgs e)
        {
            Global.indexToEdit = datPackages.SelectedRows[0].Index;
            PackageDetails newForm = new PackageDetails();
            newForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Global.indexToEdit = -1;
            PackageDetails newForm = new PackageDetails();
            newForm.Show();
        }

        private void PackagesDisplay_Activated(object sender, EventArgs e)
        {
            RefreshPkgDG();

        }

        private void RefreshPkgDG()
        {
            datPackages.Rows.Clear();
            foreach (Package p in Global.packages)
            {
                datPackages.Rows.Add(p.PkgName, p.PkgStartDate.ToString("dd/MM/yyyy"), p.PkgEndDate.ToString("dd/MM/yyyy"),
                    p.PkgDesc, p.PkgBasePrice.ToString("C"), p.PkgAgencyCommission.ToString("C"));
            }
            datPackages.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datPackages.SelectedRows.Count > 0)
            {
                int index = datPackages.SelectedRows[0].Index;
                MessageBox.Show(Global.packages[index].Delete().ToString() + " rows affected.");
                Global.packages.RemoveAt(index);
                RefreshPkgDG();
                datPackages.ClearSelection();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    RefreshPkgDG();
                    break;
                case 1:
                    refreshdatProduct();
                    break;
                case 2:
                    break;
                case 3:
                    Display();
                    break;
            }
        }

        private void refreshdatProduct()
        {
            datProduct.Rows.Clear();
            foreach (Product pn in Global.Products)
            {
                datProduct.Rows.Add(pn.ProdName);
            }
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            if (datProduct.SelectedRows.Count > 0)
            {
                int index = datProduct.SelectedRows[0].Index;
                Global.Products[index].ProdName = txtProdName.Text;
                MessageBox.Show(Global.Products[index].Update().ToString());
                refreshdatProduct();
            }
        }

        private void datProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (datProduct.SelectedRows.Count == 1)
            {
              txtProdName.Text = datProduct.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnProdNew_Click(object sender, EventArgs e)
        {
            Product.Insert(txtProdName.Text);
            Global.Products = Product.GetList();
            refreshdatProduct();
        }

        private void Display()
        {
            Global.productsSuppliers = PkgProductsSuppliers.GetPSList();

            PSdataGridView.DataSource = Global.productsSuppliers.Select(x => new { x.ProductSupplierId, x.ProductName, x.SupplierName }).ToList();
            //KeyValuePair<string, string> PSpairs = (Global.productsSuppliers.Select(x => new { x.ProductName, x.SupplierName })).ToDictionary);
            PSdataGridView.Columns["SupplierName"].Width = 200;
            //combo box showing product with product names (and values)
            ProdCombo.DisplayMember = "ProdName";
            ProdCombo.ValueMember = "ProductId";
            ProdCombo.DataSource = Global.Products;
            //combo box showing Supplier with Supplier names (and values)
            SuppCombo.DisplayMember = "SupName";
            SuppCombo.ValueMember = "SupplierId";
            SuppCombo.DataSource = Global.suppliers;
        }

        // Pick up exist product-Supplier pairs with a click from gridview controls,
        // and show values in combo boxes and text box.
        private void PSdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDBox.Text = PSdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ProdCombo.Text = PSdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            SuppCombo.Text = PSdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        // Insert a new pair of product-supplier into DataBase by click Insert button
        private void btnPSAdd_Click(object sender, EventArgs e)
        {
            getValue();
            bool flag = false;
            // Check if the pair exsit in the DB, if exist then tell the user but do nothing.
            var sid1 = (from c in Global.productsSuppliers where c.ProductID == Pid select c.SupplierID);
            // if a new product or new supplier, then it is not in current pairs list
            // thus we need to set flag to true to add new pairs
            if (sid1 == null) flag = false;       

            foreach(int s in sid1){
                if (s == Sid) flag = true;     //pairs exists, set flag to false
                
            }
            
            if (!flag)      // if insert a new pair
            {
                try
                {
                    int result = PkgProductsSuppliers.insertPS(Pid, Sid);
                    if (result > 0)
                    {
                        MessageBox.Show("Record Inserted");
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Record Add failed!");
                        IDBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Product-Supplier exists, please make a change for insert new pair.");
                ProdCombo.Focus();
            }
        }

        // to delete a record by its product-supplier-Id
        private void btnPSDelete_Click(object sender, EventArgs e)
        {
            getValue();
            if (PSId != 0)
            {
                try
                {
                    int result = PkgProductsSuppliers.DeletePS(PSId);
                    if (result > 0)
                    {
                        MessageBox.Show("Record deleted");
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Record deleted failed!");
                        IDBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // update an existing product-supplier pair from DB
        private void btnPSUpdate_Click(object sender, EventArgs e)
        {
            getValue();

            if (PSId != 0)
            {
                try
                {
                    int result = PkgProductsSuppliers.updatePS(PSId, Pid, Sid);
                    if (result > 0)
                    {
                        MessageBox.Show("Record updated");
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Record update failed!");
                        IDBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        // get values from combo boxes and text box for insert/update/delete
        private void getValue()
        {
            prod = ProdCombo.Text;
            supp = SuppCombo.Text;

            try
            {
                PSId = (IDBox.Text == "") ? 0 : Convert.ToInt32(IDBox.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("Product Supplier pair exists or conflit with other data tables, please check your selection!");
                IDBox.Focus();
            }
            if (System.Int32.TryParse(ProdCombo.SelectedIndex.ToString(), out int id))
                Pid = id + 1;
            Sid = Convert.ToInt32(SuppCombo.SelectedValue.ToString());
        }


        

    }
}
