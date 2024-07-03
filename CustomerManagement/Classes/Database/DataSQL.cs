using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;


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
                            `phone_number`       TEXT,
                            `note`               TEXT,
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
                            return new Customer(
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                reader["phone_number"].ToString(),
                                reader["note"].ToString()
                            );
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
                            return new Customer(
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                reader["phone_number"].ToString(),
                                reader["note"].ToString()
                            );
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
                            return new Customer(
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                reader["phone_number"].ToString(),
                                reader["note"].ToString()
                            );
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
                yield return new Customer(
                    Convert.ToInt32(reader["id"]),
                    reader["name"].ToString(),
                    reader["phone_number"].ToString(),
                    reader["note"].ToString()
                );
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

        public bool AddCustomer(string name, string phone_number, string note)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("INSERT INTO customers (name, phone_number, note) VALUES (@name, @phone_number, @note)", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", name);
                    sql_command.Parameters.AddWithValue("@phone_number", phone_number);
                    sql_command.Parameters.AddWithValue("@note", note);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCustomer(Customer from_customer, string new_name, string new_phone_number, string new_note)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("UPDATE customers SET name = @name, phone_number = @phone_number, note = @note WHERE id = @id", connection))
                {
                    sql_command.Parameters.AddWithValue("@name", new_name);
                    sql_command.Parameters.AddWithValue("@phone_number", new_phone_number);
                    sql_command.Parameters.AddWithValue("@note", new_note);
                    sql_command.Parameters.AddWithValue("@id", from_customer.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteCustomer(Customer customer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("DELETE FROM customers WHERE id = @id", connection))
                {
                    sql_command.Parameters.AddWithValue("@id", customer.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddGarment(
            Customer customer,
            DateTime? reception_date,
            DateTime? processing_date,
            bool is_completed,
            string contents,
            int price,
            string note
        ) {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand(
                    @"INSERT INTO garments (
                        reception_date, processing_date,
                        is_completed, contents,
                        price, note,
                        customer_id
                    ) VALUES (
                        @reception_date, @processing_date,
                        @is_completed, @contents,
                        @price, @note,
                        @customer_id
                    )", connection)
                ) {
                    sql_command.Parameters.AddWithValue("@reception_date", (object)reception_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@processing_date", (object)processing_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@is_completed", is_completed == true ? 1 : 0);
                    sql_command.Parameters.AddWithValue("@contents", string.IsNullOrEmpty(contents) ? DBNull.Value : (object)contents);
                    sql_command.Parameters.AddWithValue("@price", price);
                    sql_command.Parameters.AddWithValue("@note", string.IsNullOrEmpty(note) ? DBNull.Value : (object)note);
                    sql_command.Parameters.AddWithValue("@customer_id", customer.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateGarment(
            Garment garment,
            DateTime? reception_date,
            DateTime? processing_date,
            bool is_completed,
            string contents,
            int price,
            string note
        ) {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand(
                    @"UPDATE garments SET
                        reception_date = @reception_date,
                        processing_date = @processing_date,
                        is_completed = @is_completed,
                        contents = @contents,
                        price = @price,
                        note = @note
                    WHERE id = @id", connection)
                ) {
                    sql_command.Parameters.AddWithValue("@reception_date", (object)reception_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@processing_date", (object)processing_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@is_completed", is_completed == true ? 1 : 0);
                    sql_command.Parameters.AddWithValue("@contents", string.IsNullOrEmpty(contents) ? DBNull.Value : (object)contents);
                    sql_command.Parameters.AddWithValue("@price", price);
                    sql_command.Parameters.AddWithValue("@note", string.IsNullOrEmpty(note) ? DBNull.Value : (object)note);
                    sql_command.Parameters.AddWithValue("@id", garment.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteGarment(Garment garment)
        {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand("DELETE FROM garments WHERE id = @id", connection))
                {
                    sql_command.Parameters.AddWithValue("@id", garment.ID);
                    return sql_command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Garment GetGarment(
            Customer customer,
            DateTime? reception_date,
            DateTime? processing_date,
            bool is_completed,
            string contents,
            int price,
            string note
        ) {
            using (SQLiteConnection connection = new SQLiteConnection(database_path))
            {
                var reception_date_query = (object)reception_date?.ToString("yyyy-MM-dd") ?? DBNull.Value;
                var processing_date_query = (object)processing_date?.ToString("yyyy-MM-dd") ?? DBNull.Value;
                var is_completed_query = is_completed == true ? 1 : 0;
                var contents_query = string.IsNullOrEmpty(contents) ? DBNull.Value : (object)contents;
                var price_query = price;
                var note_query = string.IsNullOrEmpty(note) ? DBNull.Value : (object)note;
                var customer_id_query = customer.ID;

                StringBuilder query = new StringBuilder("SELECT * FROM garments WHERE");
                query.Append(reception_date_query == DBNull.Value ? " reception_date IS NULL AND" : " reception_date = @reception_date AND");
                query.Append(processing_date_query == DBNull.Value ? " processing_date IS NULL AND" : " processing_date = @processing_date AND");
                query.Append(" is_completed = @is_completed AND");
                query.Append(contents_query == DBNull.Value ? " contents IS NULL AND" : " contents = @contents AND");
                query.Append(" price = @price AND");
                query.Append(note_query == DBNull.Value ? " note IS NULL AND" : " note = @note AND");
                query.Append(" customer_id = @customer_id");

                connection.Open();
                using (SQLiteCommand sql_command = new SQLiteCommand(query.ToString(), connection))
                {
                    sql_command.Parameters.AddWithValue("@reception_date", (object)reception_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@processing_date", (object)processing_date?.ToString("yyyy-MM-dd") ?? DBNull.Value);
                    sql_command.Parameters.AddWithValue("@is_completed", is_completed == true ? 1 : 0);
                    sql_command.Parameters.AddWithValue("@contents", string.IsNullOrEmpty(contents) ? DBNull.Value : (object)contents);
                    sql_command.Parameters.AddWithValue("@price", price);
                    sql_command.Parameters.AddWithValue("@note", string.IsNullOrEmpty(note) ? DBNull.Value : (object)note);
                    sql_command.Parameters.AddWithValue("@customer_id", customer.ID);
                    using (SQLiteDataReader reader = sql_command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Garment(
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
                        else
                        {
                            throw new Exception("Garment not found.");
                        }
                    }
                }
            }
        }
    }
}
