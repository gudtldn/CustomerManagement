﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Runtime.Remoting.Messaging;


namespace CustomerManagement.Classes
{
    public class DataSQL
    {
        private string database_path;

        public DataSQL(string path = "./data/customer.db")
        {
            if (!Directory.Exists("./data"))
                Directory.CreateDirectory("./data");

            database_path = $"Data Source={path};";
            FileInfo info = new FileInfo(path);

            // DB 파일이 없으면 생성
            if (!info.Exists)
            {
                SQLiteConnection.CreateFile(path);
                using (SQLiteConnection connection = new SQLiteConnection(database_path))
                {
                    connection.Open();
                    string create_table_query = @"
                        CREATE TABLE `customers` (
                            `id`                 INTEGER,
                            `name`               TEXT NOT NULL UNIQUE,
                            `phone_number`       TEXT NOT NULL UNIQUE,
                            PRIMARY KEY(`id` AUTOINCREMENT)
                        );
                        CREATE TABLE `garments` (
                            `id`                 INTEGER,
                            `reception_date`     TEXT,
                            `processing_date`    TEXT,
                            `is_completed`       INTEGER NOT NULL,
                            `contents`           TEXT,
                            `price`              INTEGER NOT NULL,
                            `note`               TEXT,
                            `customer_id`        INTEGER NOT NULL,
                            FOREIGN KEY(`customer_id`) REFERENCES `customers`(`id`),
                            PRIMARY KEY(`id` AUTOINCREMENT)
                        )";
                    using (SQLiteCommand create_table_command = new SQLiteCommand(create_table_query, connection))
                    {
                        create_table_command.ExecuteNonQuery();
                    }
                }
            }
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

        public Customer? GetCustomer(string name, string phone_number)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("SELECT * FROM customers WHERE name = @name AND phone_number = @phone_number", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", name);
                    sql_command.Parameters.AddWithValue("@phone_number", phone_number);
                    using (SQLiteDataReader reader = sql_command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["phone_number"].ToString());
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public Customer? GetCustomerFromName(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("SELECT * FROM customers WHERE name = @name", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", name);
                    using (SQLiteDataReader reader = sql_command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["phone_number"].ToString());
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public Customer? GetCustomerFromPhoneNumber(string phone_number)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("SELECT * FROM customers WHERE phone_number = @phone_number", connection))
                {
                    sql_command.Parameters.AddWithValue("@phone_number", phone_number);
                    using (SQLiteDataReader reader = sql_command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["phone_number"].ToString());
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            foreach (SQLiteDataReader reader in GetData("SELECT * FROM customers"))
            {
                yield return new Customer(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["phone_number"].ToString());
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

        public IEnumerable<Garment> GetGarments(Customer customer)
        {
            foreach (SQLiteDataReader reader in GetData("SELECT * FROM garments WHERE customer_id = @p0", customer.ID))
            {
                yield return new Garment(
                    Convert.ToInt32(reader["id"]),
                    reader["reception_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["reception_date"]),
                    reader["processing_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["processing_date"]),
                    Convert.ToBoolean(reader["is_completed"]),
                    reader["contents"].ToString(),
                    Convert.ToInt32(reader["price"]),
                    reader["note"].ToString(),
                    customer.ID
                );
            }
        }

        public bool AddCustomer(string name, string phone_number)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("INSERT INTO customers (name, phone_number) VALUES (@name, @phone_number)", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", name);
                    sql_command.Parameters.AddWithValue("@phone_number", phone_number);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCustomer(Customer from_customer, string new_name, string new_phone_number)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("UPDATE customers SET name = @name, phone_number = @phone_number WHERE id = @id", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", new_name);
                    sql_command.Parameters.AddWithValue("@phone_number", new_phone_number);
                    sql_command.Parameters.AddWithValue("@id", from_customer.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
