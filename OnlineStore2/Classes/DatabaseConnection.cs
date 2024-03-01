using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore2.Classes
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "OnlineStoreDataBase";
        string username = "";
        string password = "";

        string connectionString = "";

        public DatabaseConnection(string server, string database, string username, string password)
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
            Console.WriteLine("ConnectionString: " + connectionString);
        }

        public Dictionary<int, Item> GetItem()
        {

            Dictionary<int, Item> item = new Dictionary<int, Item>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM items";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["item_name"]);
                Item item = new Item((int)reader["item_id"], (string)reader["item_name"], (int)reader["item_price"]);
                item.Add(item.Id, item);
            }

            mySqlConnection.Close();
            Console.WriteLine("Retrieved " + item.Count + " items from database.");
            return item;
        }

    }
}
