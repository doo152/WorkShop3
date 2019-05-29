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
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string  SupName { get; set; }



        public Supplier(int SupplierId, string SupName)
        {
            this.SupplierId = SupplierId;
            this.SupName = SupName;
        }

        public static List<Supplier> GetList()
        {
            

            
                List<Supplier> result = new List<Supplier>();

                DataSet data = SupplierDB.GetDataSet();

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    result.Add(new Supplier(Convert.ToInt32(row["SupplierId"]), Convert.ToString(row["SupName"])));

                   
                }
                return result;
            
        }

        public int Insert()
        {
            return SupplierDB.InsertSupplier(SupplierId, SupName);
        }

        public int Update()
        {
            return SupplierDB.UpdateSupplier(SupplierId, SupName);
        }

        public int Delete()
        {
            return SupplierDB.DeleteSupplier(SupplierId);
        }
    }
}




