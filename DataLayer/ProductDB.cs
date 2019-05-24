using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Data;

namespace DataLayer
{
    public static class ProductDB
    {
        public static DataSet GetDataSet()
        {
            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(sql, conn.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }
        public static int InsertProdName(string ProdName)
        {
            int result;
            string sql =
                "INSERT INTO Products (ProdName) " +
                "VALUES(@ProdName);";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProdName", ProdName);
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public static int UpdateProducts(int ProductId, string ProdName)
        {
            int result;
            string sql =
                "UPDATE Products " +
                "SET ProdName = @ProdName " +
                "WHERE ProductId = @ProductID;";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@ProdName", ProdName);
            command.Parameters.AddWithValue("@ProductID", ProductId);
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}

