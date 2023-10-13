using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarKeysInventory
{
    internal class DbContext
    {
        SqlConnection connection = new SqlConnection(@"server = WIN-ATCIAJ6VQES; database = CarKeysManagement; integrated security = true; TrustServerCertificate = true");

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }
    }
}
