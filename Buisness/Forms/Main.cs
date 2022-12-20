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
            if (Application.OpenForms.OfType<SignUp>().Count() == 1)
                Application.OpenForms.OfType<SignUp>().First().Close();

            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
