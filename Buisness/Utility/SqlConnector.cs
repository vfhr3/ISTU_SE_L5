using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Buisness.Utility
{
    public static class Database
    {
        static MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=lab_db");
        static MySqlCommand commandDatabase;

        public static void Open()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
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

        public static void HealthCheck()
        {
            MessageBox.Show(connection.State.ToString());
        }
    }
}
