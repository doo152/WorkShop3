/// Data layer functions for connection Database and insert/update/delete functions
/// By Ken Zhang

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PkgProductsSuppliersDB
    {
        /// function to get package-product-supplier table and join to other tables for details display
        public static DataSet GetPPSDataSet()
        {
            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "SELECT pps.packageid, PkgName, ps.ProductSupplierId, pr.ProductId, ProdName, ps.SupplierId, SupName " +
                        "FROM Products_Suppliers ps join  Packages_Products_Suppliers pps " +
                        "ON ps.ProductSupplierId = pps.ProductSupplierid " +
                        "join packages p ON pps.PackageId = p.PackageId " +
                        "join Products pr ON pr.ProductId = ps.ProductId " +
                        "join Suppliers s ON s.SupplierId = ps.SupplierId ";

            SqlCommand command = new SqlCommand(sql, conn.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }

        public static DataSet GetPSDataSet()
        {
            /// Function for getting data from 3 joined tables to show details of product-supplier relations

            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "SELECT Products_Suppliers.ProductSupplierId, Products_Suppliers.ProductId, ProdName, Products_Suppliers.SupplierId, SupName " +
                        "FROM Products_Suppliers  " +
                        "join Products  ON Products.ProductId = Products_Suppliers.ProductId " +
                        "join Suppliers ON Suppliers.SupplierId = Products_Suppliers.SupplierId ";
            SqlCommand command = new SqlCommand(sql, conn.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }

        // function for insert new package into package-product-supplier table for future use
        public static int Insert_Package_ProductSupplier(int PackageID, int ProductSupplierId)
        {
            int result;
            string sql =
                "INSERT INTO Packages_Products_Suppliers (PackageID, ProductSupplierId)" +
                "VALUES (@PackageID, @ProductSupplierId);";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@PackageID", PackageID);
            command.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return result;
        }

        // Work on product-supplier table to insert new record
        public static int Insert_Product_Supplier(int ProductID, int SupplierId)
        {
            int result;
            string sql =
                "INSERT INTO Products_Suppliers (ProductID, SupplierId) " +
                "VALUES (" + ProductID + ", " + SupplierId + ")";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            //  command.Parameters.AddWithValue("@ProductID", ProductID);
            //   command.Parameters.AddWithValue("@SupplierId", SupplierId);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

            conn.Close();
            return result;
        }

        // Function for update productsupplier table records.
        public static int Update_Product_Supplier(int ProductSupplierId, int ProductID, int SupplierID)
        {
            int result;
            string sql =
                "UPDATE Products_Suppliers " +
                "SET ProductID = " + ProductID + ", " + "SupplierID = " + SupplierID +
                "WHERE ProductSupplierId = " + ProductSupplierId;
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            //command.Parameters.AddWithValue("@ProductID", ProductID);
            //command.Parameters.AddWithValue("@SupplierID", SupplierID);
            //command.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return result;
        }
        // Work on package-product-supplier table to delete a record for future use
        public static int Delete_Packages_Products_Suppliers(int ProductSupplierId, int PackageID)
        {
            int result;
            string sql =
                "DELETE FROM Packages_Products_Suppliers " +
                "WHERE ProductSupplierId = @ProductSupplierId and PackageID=@PackageID";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            command.Parameters.AddWithValue("@PackageID", PackageID);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return result;
        }
        // Work on product-supplier table to delete a record according its productsupplierID
        public static int Delete_Products_Suppliers(int ProductSupplierId)
        {
            int result;
            string sql =
                "DELETE FROM Products_Suppliers " +
                "WHERE ProductSupplierId = @ProductSupplierId";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProductSupplierId", ProductSupplierId);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return result;
        }

    }
}
