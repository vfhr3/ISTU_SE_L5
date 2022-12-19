using Buisness.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Buisness.Utility
{
    public static class Database
    {
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=lab_db";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void Open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Close()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static User GetUser(string username, string password)
        {
            User user;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var cmd = new MySqlCommand() { 
                    Connection = connection,
                    CommandText = $"SELECT * FROM user WHERE username = '{username}' AND password = '{password}'" })
                {
                    try
                    {
                        connection.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            user = new User();
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.Username = reader.GetString(2);
                            user.Password = reader.GetString(3);
                            user.Role = reader.GetString(4);
                            return user;
                        }
                        return null;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
            }
        }

        public static void HealthCheck()
        {
            MessageBox.Show(connection.State.ToString());
        }
    }
}
