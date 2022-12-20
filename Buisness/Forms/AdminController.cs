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
    public partial class AdminController : Form
    {
        User user;
        public AdminController(User user)
        {
            InitializeComponent();
            this.user = user;

            List<User> users = Database.GetUsers();
            foreach (var _user in users)
            {
                Employee employee = new Employee(_user, CertsPanel);
                EmployeePanel.Controls.Add(employee);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.Show();
        }
    }
}
