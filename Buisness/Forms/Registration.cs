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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string username = usernameField.Text;
            string password = passwordField.Text;
            string secretKey = secretKeyField.Text;

            if (Database.GetUserByUsername(username) != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
            }
            else
            {
                Database.Register(name, username, password, secretKey);
                if (Database.GetUserByUsername(username) != null)
                {
                    MessageBox.Show("Пользователь успешно зарегистрирован!");
                    this.Close();
                    Program.mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка! Возможно неверно введен секретный ключ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.Show();
        }
    }
}
