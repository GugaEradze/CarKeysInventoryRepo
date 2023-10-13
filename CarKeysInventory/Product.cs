using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarKeysInventory
{
    internal class Product
    {
        User user = new User();
        DbContext context = new DbContext();

        public bool CheckProduct(string productName)
        {
            DataTable dataTable = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Products] WHERE CategoryName = '" + productName + "'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertProduct(string productName, decimal productPrice, int quantity, string category, string description)
        {
            SqlCommand command = new("INSERT INTO [CarKeysManagement].[dbo].[Products] (ProductName, ProductPrice, Quantity, CategoryName, Description) VALUES(@pn, @pp, @qn, @ct, @desc)", context.GetConnection());

            command.Parameters.Add("@pn", System.Data.SqlDbType.VarChar).Value = productName;
            command.Parameters.Add("@pp", System.Data.SqlDbType.Decimal).Value = productPrice;
            command.Parameters.Add("@qn", System.Data.SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@ct", System.Data.SqlDbType.VarChar).Value = category;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = description;

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

        public bool UpdateProduct(int id, string productName, decimal productPrice, int quantity, string category, string description)
        {
            SqlCommand command = new("UPDATE [CarKeysManagement].[dbo].[Products] SET ProductName = @pn, ProductPrice = @pp, Quantity = @qt, CategoryName = @cn, Description = @desc WHERE ID = @id", context.GetConnection());

            command.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@pn", System.Data.SqlDbType.VarChar).Value = productName;
            command.Parameters.Add("@pp", System.Data.SqlDbType.Decimal).Value = productPrice;
            command.Parameters.Add("@qt", System.Data.SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = category;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = description;

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

        public bool DeleteProduct(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [CarKeysManagement].[dbo].[Products] WHERE ID = @id", context.GetConnection());
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

        public DataTable SearchProduct(string searchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[CarKeysManagement].[dbo].[Products] WHERE CONCAT (ProductName, ProductPrice, CategoryName) LIKE '%" + searchData + "%'", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
