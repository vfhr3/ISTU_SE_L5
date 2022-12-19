using Buisness.Models;
using Buisness.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buisness.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            User user = Database.GetUser(username, password);
            if (user != null)
            MessageBox.Show($"{user.Id}\n{user.Name}\n{user.Username}\n{user.Password}\n{user.Role}");
        }
    }
}
