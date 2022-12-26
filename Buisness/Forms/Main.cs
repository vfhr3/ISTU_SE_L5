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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void openSignInForm(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SignIn>().Count() == 1)
                Application.OpenForms.OfType<SignIn>().First().Close();

            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void openSignUpForm(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Registration>().Count() == 1)
                Application.OpenForms.OfType<Registration>().First().Close();

            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
