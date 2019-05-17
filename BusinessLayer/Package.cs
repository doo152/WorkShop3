using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; private set; }

        public Package(int PackageId, string PkgName, DateTime PkgStartDate, DateTime PkgEndDate,
            string PkgDesc, decimal PkgBasePrice, decimal PkgAgencyCommission)
        {
            this.PackageId = PackageId;
            this.PkgName = PkgName;
            this.PkgStartDate = PkgStartDate;
            this.PkgEndDate = PkgEndDate;
            this.PkgDesc = PkgDesc;
            this.PkgBasePrice = PkgBasePrice;
            this.PkgAgencyCommission = PkgAgencyCommission;

        }

        public static List<Package> GetList()
        {
            List<Package> result = new List<Package>();

            DataSet data = PackageDB.GetDataSet();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                result.Add(new Package(Convert.ToInt32(row["PackageId"]), Convert.ToString(row["PkgName"]), Convert.ToDateTime(row["PkgStartDate"]),
                    Convert.ToDateTime(row["PkgEndDate"]), Convert.ToString(row["PkgDesc"]), Convert.ToDecimal(row["PkgBasePrice"]), Convert.ToDecimal(row["PkgAgencyCommission"])));
            }
            
            return result;

        }

        public int Insert()
        {
            return PackageDB.InsertPackage(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission);
        }

        public int Update()
        {
            return PackageDB.UpdatePackage(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission);
        }
        
        public int Delete()
        {
            return PackageDB.DeletePackage(PackageId);
        }
    }
}
