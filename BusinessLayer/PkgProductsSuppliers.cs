using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PkgProductsSuppliers
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int ProductSupplierId { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public PkgProductsSuppliers(int PId, string PkgName, int PSId, int pdId,  string pName, int SID,  string sName)
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

        public static List<PkgProductsSuppliers> GetPSList()
        {
            List<PkgProductsSuppliers> result = new List<PkgProductsSuppliers>();

            DataSet data = PkgProductsSuppliersDB.GetPSDataSet();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                result.Add(new PkgProductsSuppliers( Convert.ToInt32(row["ProductSupplierId"]), Convert.ToInt32(row["ProductId"]), Convert.ToString(row["ProdName"]), Convert.ToInt32(row["SupplierId"]), Convert.ToString(row["SupName"])));
            }
            return result;            
        }
    }
}
