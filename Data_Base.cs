using System;
using MySql.Data.MySqlClient;

namespace Gym_Management_System
{
    internal class Data_Base 
    {
        private static MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=gym_db"); 

        public static MySqlConnection GetConnection() // Make this method static
        {
            return conn;
        }

        public static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
