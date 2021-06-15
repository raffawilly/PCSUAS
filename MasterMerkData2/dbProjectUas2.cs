using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMerkData2
{
    public static class dbProjectUas2
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost\\SqlExpress;Initial Catalog=dbProjectUas;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
