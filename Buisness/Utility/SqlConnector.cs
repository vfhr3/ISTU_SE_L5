using Buisness.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        public static void ApproveCertificate(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateSql = "UPDATE certificate SET isApproved = 1 WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
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
                using (var cmd = new MySqlCommand()
                {
                    Connection = connection,
                    CommandText = $"SELECT * FROM user WHERE username = '{username}' AND password = '{password}'"
                })
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
        public static Certificate GetCertificateById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string selectSql = "SELECT * FROM certificate WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(selectSql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Certificate certificate = new Certificate()
                            {
                                id = reader.GetInt32(0),
                                owner_id = reader.GetInt32(1),
                                data = reader.GetString(2),
                                isApproved = reader.GetBoolean(3)
                            };
                            return certificate;
                        }

                    }
                }
            }
            return null;
        }
        public static void Register(string name, string username, string password, string secretCode = "")
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string insertSql = "INSERT INTO user (name, username, password, role) VALUES (@name, @username, @password, @role)";

                using (MySqlCommand cmd = new MySqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    string role;
                    if (secretCode == "123")
                    {
                        role = "Admin";
                    }
                    else
                    {
                        role = "User";
                    }
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static User GetUserByUsername(string username)
        {
            User user;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var cmd = new MySqlCommand()
                {
                    Connection = connection,
                    CommandText = $"SELECT * FROM user WHERE username = '{username}'"
                })
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
    }
}
