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
    public class Product
    {
        public int ProductId;
        public string ProdName { get; set; }

        public Product(int ProductId, string ProdName)
        {
            this.ProductId = ProductId;
            this.ProdName = ProdName;
        }
        public static List<Product> GetList()
        {
            List<Product> result = new List<Product>();

            DataSet data = ProductDB.GetDataSet();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                result.Add(new Product(Convert.ToInt32(row["ProductId"]), Convert.ToString(row["ProdName"])));
            }
            return result;
        }
    }
}

