using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer
{
    public class SupplierDB
    {
        public static object SupName { get; private set; }

        public static DataSet GetDataSet()
        {
            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "SELECT * FROM Suppliers";
            SqlCommand command = new SqlCommand(sql, conn.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }
        public static int InsertSupplier(int SupplierId, string SupName)
        {
            int result;
            string sql =
                "INSERT INTO Supplier (SupName) VALUES (@SupName);";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@SupName", SupName);

            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static int UpdateSupplier(int SupplierId, string SupName)
        {
            int result;
            string sql =
                "UPDATE Supplier " +
                "SET SupName = @SupName WHERE SupplierId = @SupplierId;";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@SupName", SupName);

            command.Parameters.AddWithValue("@SupplierId", SupplierId.ToString());
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static int DeleteSupplier(int SupplierId)
        {
            int result;
            string sql =
                "DELETE FROM Suppliers " +
                "WHERE SuoolierId = @SupplierId";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@SupplierId", SupplierId);
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}
