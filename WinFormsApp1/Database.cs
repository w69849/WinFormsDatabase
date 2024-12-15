using Microsoft.Data.Sqlite;

namespace WinFormsApp1
{
    internal class Database
    {
        private readonly SqliteConnection connection;
        private readonly SqliteCommand command;

        public Database()
        {
            connection = new SqliteConnection("Data Source = database3.db");
            connection.Open();

            command = connection.CreateCommand();
        }

        ~Database()
        {
            connection.Close();
        }

        public void CreateTable(string tableName)
        {
            command.CommandText =
            @"
                CREATE TABLE users
                ( 
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL
                );
            ";
                      
            //command.Parameters.AddWithValue("$tableName", tableName);
            command.ExecuteNonQuery();

            //InitializeTable(tableName);
        }

        public void InitializeTable(string tableName)
        {
            command.CommandText =
                @"
                    INSERT INTO siema VALUES
                        (1, 'Monika'),
                        (2, 'Aleksander'),
                        (3, 'Tomasz');
                ";

            //command.Parameters.AddWithValue("$tableName", tableName);
            command.ExecuteNonQuery();
        }

        public void AddRow(string tableName, string name)
        {
            //MessageBox.Show("XD");
            #region snippet_Parameter

            string cm = "INSERT INTO " + tableName + "(name) VALUES('" + name + "')";
            command.CommandText = cm;
            //@"
            //    INSERT INTO tableName VALUES($name);
            //";

            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("tableName", tableName);
            #endregion

            command.ExecuteNonQuery();
            command.CommandText =
                @"
                    SELECT last_insert_rowid()
                ";

            var newId = (long)command.ExecuteScalar();

            //Console.WriteLine($"Your new user ID is {newId}.");
            MessageBox.Show($"{newId}");
        }

        public string FindById(int id)
        {
            command.CommandText = "SELECT name FROM users WHERE id = " + id;
            string name = command.ExecuteScalar().ToString();

            MessageBox.Show(name);
            return name;
        }

        public List<string> PrintAllUsers()
        {
            command.CommandText = "SELECT name FROM users";
            using var reader = command.ExecuteReader();

            List<string> names = new List<string>();

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    names.Append(reader.GetString(1));
                }
            }

            return names;
        }
    }
}   
