using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Formats.Asn1.AsnWriter;

namespace CarKeysInventory
{
    internal class User
    {
        DbContext context = new DbContext();

        public DataTable GetUsersList(SqlCommand command)
        {
            command.Connection = context.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool CheckUser(string userName, string phone)
        {
            DataTable dataTable = GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Users] WHERE UserName = '" + userName + "' OR Phone = '" + phone + "'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUser(string userName, string fullName, string password, string phone)
        {
            SqlCommand command = new("INSERT INTO [CarKeysManagement].[dbo].[Users] (Username, FullName, Password, Phone) VALUES(@un, @fn, @pas, @ph)", context.GetConnection());

            command.Parameters.Add("@un", System.Data.SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fullName;
            command.Parameters.Add("@pas", System.Data.SqlDbType.VarChar).Value = password;
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

        public bool DeleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [CarKeysManagement].[dbo].[Users] WHERE ID = @id", context.GetConnection());
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
