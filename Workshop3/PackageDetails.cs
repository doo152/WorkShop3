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
using System.Globalization;

namespace Workshop3
{
    public partial class PackageDetails : Form
    {
        public PackageDetails()
        {
            InitializeComponent();
        }

        private void PackageDetails_Load(object sender, EventArgs e)
        {
            if (Global.indexToEdit != -1)
            {
                Package sel = Global.packages[Global.indexToEdit];
                txtName.Text = sel.PkgName;
                dtpStartDate.Text = sel.PkgStartDate.ToString("MM/dd/yyyy");
                dtpEndDate.Text = sel.PkgEndDate.ToString("MM/dd/yyyy");
                txtDesc.Text = sel.PkgDesc;
                txtPrice.Text = sel.PkgBasePrice.ToString("C");
                txtCommission.Text = sel.PkgAgencyCommission.ToString("C");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool formValidated = true;

            if (txtName.Text == "" || txtDesc.Text == "")
            {
                formValidated = false;
                MessageBox.Show("Name and Description must be filled out.");
            }

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                formValidated = false;
                MessageBox.Show("End Date must be later than Start Date.");
            }

            if (Convert.ToDecimal(txtCommission.Text) > Convert.ToDecimal(txtPrice.Text))
            {
                formValidated = false;
                MessageBox.Show("Price must be higher than Commission");
            }

            if (formValidated)
            {
                if (Global.indexToEdit == -1)
                {
                    Global.packages.Add(Package.InsertNew(txtName.Text, dtpStartDate.Value, dtpEndDate.Value, txtDesc.Text,
                        decimal.Parse(txtPrice.Text, NumberStyles.Any), decimal.Parse(txtCommission.Text, NumberStyles.Any)));
                }
                else
                {
                    int tempID = Global.packages[Global.indexToEdit].PackageId;
                    Global.packages[Global.indexToEdit] = new Package(tempID, txtName.Text, dtpStartDate.Value, dtpEndDate.Value, txtDesc.Text,
                        decimal.Parse(txtPrice.Text, NumberStyles.Any), decimal.Parse(txtCommission.Text, NumberStyles.Any));
                    MessageBox.Show(Global.packages[Global.indexToEdit].Update().ToString() + " rows affected");
                }
                this.Close();
            }
        }
    }
}
