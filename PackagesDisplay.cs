﻿using System;
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
    public partial class PackagesDisplay : Form
    {
        public PackagesDisplay()
        {
            InitializeComponent();
        }

        private void PackagesDisplay_Load(object sender, EventArgs e)
        {
            Global.packages = Package.GetList();
            RefreshDataGrid();
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
            RefreshDataGrid();

        }

        private void RefreshDataGrid()
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
                RefreshDataGrid();
                datPackages.ClearSelection();
            }
        }
    }
}
