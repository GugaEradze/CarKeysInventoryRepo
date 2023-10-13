using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarKeysInventory
{
    internal class Customer
    {
        DbContext context = new DbContext();
        User user = new User();

        public bool CheckUser(string customerName, string phone)
        {
            DataTable dataTable = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Customers] WHERE CustomerName = '" + customerName + "' OR Phone = '" + phone + "'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertCustomer(string customerName, string phone)
        {
            SqlCommand command = new("INSERT INTO [CarKeysManagement].[dbo].[Customers] (CustomerName, Phone) VALUES(@cn, @ph)", context.GetConnection());

            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = customerName;
            command.Parameters.Add("@ph", System.Data.SqlDbType.VarChar).Value = phone;

            context.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                context.CloseConnection();
                return true;
            }
            else
            {
                context.CloseConnection();
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [CarKeysManagement].[dbo].[Customers] WHERE ID = @id", context.GetConnection());
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            context.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                context.CloseConnection();
                return true;
            }
            else
            {
                context.CloseConnection();
                return false;
            }
        }

        public DataTable SearchCustomer(string searchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[CarKeysManagement].[dbo].[Customers] WHERE CONCAT (ID, CustomerName) LIKE '%" + searchData + "%'", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
