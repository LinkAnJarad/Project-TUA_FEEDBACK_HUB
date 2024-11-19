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
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "tuafms";

        static string connectionString = $"server={server};port={port};username={username};password={password};database={database};";

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