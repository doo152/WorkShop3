using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class TravelExpertsConnection
    {
        private string connectionString = "Data Source=localhost\\SQLExpress; Initial Catalog=TravelExperts; Integrated Security=true";
        public SqlConnection connection { get; set; }

        public TravelExpertsConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }


        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
    }
}
