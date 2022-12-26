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
            {
                if (user.Role == "User")
                {
                    EmployeeController employeeform = new EmployeeController(user);
                    employeeform.EmployeeName.Text = user.Name;
                    employeeform.Show();
                    this.Close();
                }
                else if (user.Role == "Admin")
                {
                    AdminController adminForm = new AdminController(user);
                    adminForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.Show();
        }
    }
}
