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
    public static class PackageDB
    {
        
        public static DataSet GetDataSet()
        {
            TravelExpertsConnection conn = new TravelExpertsConnection();
            string sql = "SELECT * FROM Packages";
            SqlCommand command = new SqlCommand(sql, conn.connection);
           
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            return data;
        }

        public static int InsertPackage(string PkgName, DateTime PkgStartDate, DateTime PkgEndDate, 
            string PkgDesc, decimal PkgBasePrice, decimal PkgAgencyCommission)
        {
            int result;
            string sql =
                "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                "VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission) " +
                "SELECT SCOPE_IDENTITY()";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@PkgName", PkgName);
            command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
            command.Parameters.AddWithValue("@PkgDesc", PkgDesc);
            command.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice.ToString());
            command.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission.ToString());
            result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        public static int UpdatePackage(int PackageId, string PkgName, DateTime PkgStartDate, DateTime PkgEndDate,
            string PkgDesc, decimal PkgBasePrice, decimal PkgAgencyCommission)
        {
            int result;
            string sql =
                "UPDATE Packages " +
                "SET PkgName = @PkgName, PkgStartDate = @PkgStartDate, PkgEndDate = @PkgEndDate, PkgDesc = @PkgDesc, " +
                    "PkgBasePrice = @PkgBasePrice, PkgAgencyCommission = @PkgAgencyCommission " +
                "WHERE PackageId = @PackageId;";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@PkgName", PkgName);
            command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
            command.Parameters.AddWithValue("@PkgDesc", PkgDesc);
            command.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice.ToString());
            command.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission.ToString());
            command.Parameters.AddWithValue("@PackageId", PackageId.ToString());
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static int DeletePackage(int PackageId)
        {
            int result;
            string sql =
                "DELETE FROM Packages " +
                "WHERE PackageId = @PackageId";
            TravelExpertsConnection conn = new TravelExpertsConnection();
            SqlCommand command = new SqlCommand(sql, conn.connection);
            command.Parameters.AddWithValue("@PackageId", PackageId);
            result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}
