using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarKeysInventory
{
    internal class Category
    {
        User user = new User();
        DbContext context = new DbContext();

        public bool CheckCategory(string categoryName)
        {
            DataTable dataTable = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Categories] WHERE CategoryName = '" + categoryName + "'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetCategoryList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Categories]", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool InsertCategory(string categoryName)
        {
            SqlCommand command = new("INSERT INTO [CarKeysManagement].[dbo].[Categories] (CategoryName) VALUES(@cn)", context.GetConnection());

            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = categoryName;

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

        public bool DeleteCategory(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [CarKeysManagement].[dbo].[Categories] WHERE ID = @id", context.GetConnection());
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
    }
}
