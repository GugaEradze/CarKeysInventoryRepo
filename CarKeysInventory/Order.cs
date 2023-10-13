using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CarKeysInventory
{
    internal class Order
    {
        DbContext context = new DbContext();

        public bool InsertOrder(int productID, int customerID, string productName, string customerName, int quantity, decimal price, decimal total, DateTime orderDate)
        {
            SqlCommand command = new("INSERT INTO [CarKeysManagement].[dbo].[Orders] (ProductID, CustomerID, ProductName, CustomerName, Quantity, Price, Total, OrderDate) VALUES(@pid, @cid, @pn, @cn, @qn, @pr, @tt, @od)", context.GetConnection());

            command.Parameters.Add("@od", System.Data.SqlDbType.Date).Value = orderDate;
            command.Parameters.Add("@pid", System.Data.SqlDbType.Int).Value = productID;
            command.Parameters.Add("@cid", System.Data.SqlDbType.Int).Value = customerID;
            command.Parameters.Add("@qn", System.Data.SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@pr", System.Data.SqlDbType.Decimal).Value = price;
            command.Parameters.Add("@tt", System.Data.SqlDbType.Decimal).Value = total;
            command.Parameters.Add("@pn", System.Data.SqlDbType.VarChar).Value = productName;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = customerName;

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

        public bool DeleteOrder(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [CarKeysManagement].[dbo].[Orders] WHERE OrderID = @id", context.GetConnection());
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

        public bool CompleteOrder(int oid, int cid)
        {
            SqlCommand command = new SqlCommand("UPDATE [CarKeysManagement].[dbo].[Products] SET Quantity = (Quantity - (SELECT Quantity FROM [CarKeysManagement].[dbo].[Orders] WHERE OrderID = @oid)) WHERE ID = @cid", context.GetConnection());
            command.Parameters.Add("@oid", System.Data.SqlDbType.Int).Value = oid;
            command.Parameters.Add("@cid", System.Data.SqlDbType.Int).Value = cid;
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

        public DataTable SearchOrder(string searchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[CarKeysManagement].[dbo].[Orders] WHERE CONCAT (OrderDate, ProductID, CustomerID, Quantity, Price, Total) LIKE '%" + searchData + "%'", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
