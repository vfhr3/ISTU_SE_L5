using Buisness.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public static List<User> GetUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var cmd = new MySqlCommand()
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM user WHERE role = 'User'"
                })
                {
                    try
                    {
                        List<User> users = new List<User>();
                        connection.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.Username = reader.GetString(2);
                            user.Password = reader.GetString(3);
                            user.Role = reader.GetString(4);
                            users.Add(user);
                        }
                        return users;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
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

        public static List<Certificate> GetUserCertificates(User user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var cmd = new MySqlCommand()
                {
                    Connection = connection,
                    CommandText = $"SELECT * FROM certificate WHERE owner_id = '{user.Id}'"
                })
                {
                    try
                    {
                        connection.Open();
                        List<Certificate> certs = new List<Certificate>();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Certificate cert = new Certificate();
                            cert.owner_id = reader.GetInt32(0);
                            cert.id = reader.GetInt32(1);
                            cert.data = reader.GetString(2);
                            cert.isApproved = reader.GetBoolean(3);
                            certs.Add(cert);
                        }
                        return certs;
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
