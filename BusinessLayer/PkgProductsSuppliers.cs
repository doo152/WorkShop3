/// Business layer functions for create dataset functions and class
/// By Ken Zhang

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    /// <summary>
    /// General class for package-product-Supplier table
    /// </summary>
    public class PkgProductsSuppliers
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int ProductSupplierId { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }

        // Build constructor
        public PkgProductsSuppliers(int PId, string PkgName, int PSId, int pdId, string pName, int SID, string sName)
        {

            this.PackageId = PId;
            this.PackageName = PkgName;
            this.ProductSupplierId = PSId;
            this.ProductID = pdId;
            this.SupplierID = SID;
            this.ProductName = pName;
            this.SupplierName = sName;
        }

        public PkgProductsSuppliers(int PSId, int pdId, string pName, int SID, string sName)
        {
            this.ProductSupplierId = PSId;
            this.ProductID = pdId;
            this.SupplierID = SID;
            this.ProductName = pName;
            this.SupplierName = sName;
        }

        // get Package-Product-Supplier List of dataset from database
        public static List<PkgProductsSuppliers> GetPPSList()
        {
            List<PkgProductsSuppliers> result = new List<PkgProductsSuppliers>();

            DataSet data = PkgProductsSuppliersDB.GetPPSDataSet();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                result.Add(new PkgProductsSuppliers(Convert.ToInt32(row["PackageId"]), Convert.ToString(row["PkgName"]), Convert.ToInt32(row["ProductSupplierId"]), Convert.ToInt32(row["ProductId"]), Convert.ToString(row["ProdName"]), Convert.ToInt32(row["SupplierId"]), Convert.ToString(row["SupName"])));
            }
            return result;
        }

        /// get Product Supplier List of dataset from database
        public static List<PkgProductsSuppliers> GetPSList()
        {
            List<PkgProductsSuppliers> result = new List<PkgProductsSuppliers>();

            DataSet data = PkgProductsSuppliersDB.GetPSDataSet();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                result.Add(new PkgProductsSuppliers(Convert.ToInt32(row["ProductSupplierId"]), Convert.ToInt32(row["ProductId"]), Convert.ToString(row["ProdName"]), Convert.ToInt32(row["SupplierId"]), Convert.ToString(row["SupName"])));
            }
            return result;
        }

        public static int insertPS(int Pid, int Sid)
        {
            return PkgProductsSuppliersDB.Insert_Product_Supplier(Pid, Sid);
        }

        public static int updatePS(int PSid, int Pid, int Sid)
        {
            return PkgProductsSuppliersDB.Update_Product_Supplier(PSid, Pid, Sid);
        }

        public static int DeletePS(int PSid)
        {
            
            return PkgProductsSuppliersDB.Delete_Products_Suppliers(PSid);
        }

    }
}
