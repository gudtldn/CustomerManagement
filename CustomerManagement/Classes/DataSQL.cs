using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.Remoting.Messaging;


namespace CustomerManagement.Classes
{
    public class DataSQL
    {
        private string database_path;

        public DataSQL(string path = "./data/customer.db")
        {
            database_path = $"Data Source={path};";
        }

        public IEnumerable<SQLiteDataReader> GetData(string command, params object[] args)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand(command, connection))
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        sql_command.Parameters.AddWithValue($"@p{i}", args[i]);
                    }

                    using (SQLiteDataReader reader = sql_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader;
                        }
                    }
                }
            }
        }

        public IEnumerable<CustomerInfo> GetAllCustomers()
        {
            foreach (SQLiteDataReader reader in GetData("SELECT * FROM customers"))
            {
                yield return new CustomerInfo(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["phone_number"].ToString());
            }
        }

        public int GetTotalCustomersCount()
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("SELECT COUNT(*) FROM customers", connection))
                {
                    return Convert.ToInt32(sql_command.ExecuteScalar());
                }
            }
        }
    }
}
