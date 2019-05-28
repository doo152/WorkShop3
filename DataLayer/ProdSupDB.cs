using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class ProdSupDB
    {
        public static DataSet GetDataSet()
        {
            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "Select * From Products_Suppliers";
            SqlCommand command = new SqlCommand(sql, conn.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }

        public static int InsertProductSupplier(int ProductID, int SupplierID)
        {
            int result;
            string sql =
                "INSERT INTO Products_Suppliers (ProductID, SupplierID)" +
                "VALUES (@ProductID, @SupplierID);";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);           
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static int UpdateProductSupplier(int ProductID, int SupplierID, int ProductSupplierId)
        {
            int result;
            string sql =
                "UPDATE Products_Suppliers " +
                "SET ProductID = @ProductID, SupplierID = @SupplierID " +
                "WHERE ProductSupplierId = @ProductSupplierId;";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static int DeleteProductSupplier(int ProductSupplierId)
        {
            int result;
            string sql =
                "DELETE FROM Products_Suppliers " +
                "WHERE ProductSupplierId = @ProductSupplierId";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}

