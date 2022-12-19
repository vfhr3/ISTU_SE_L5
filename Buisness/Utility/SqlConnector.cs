using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Buisness.Utility
{
    public class SqlConnector
    {
        MySqlConnection connection;
        MySqlCommand commandDatabase;

        public SqlConnector(string connectionString)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void HealthCheck()
        {
            MessageBox.Show(connection.State.ToString());
        }
    }
}
