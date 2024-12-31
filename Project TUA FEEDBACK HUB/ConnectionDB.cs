using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TUA_FEEDBACK_HUB
{
    public static class ConnectionDB
    {
        public static string IP = "192.168.254.118";
        public static string server = "localhost";
        public static string port = "3306";
        public static string username = "jandrik";
        public static string password = "jandriklana123*";
        public static string database = "tuafms";

        public static string connectionString = $"server={server};port={port};username={username};database={database}";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                return mySqlConnection;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return null;
            }
        }
    }
}
