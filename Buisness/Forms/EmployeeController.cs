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
    public partial class EmployeeController : Form
    {
        User user;
        public EmployeeController(User user)
        {
            InitializeComponent();
            this.user = user;
            List<Models.Certificate> certificates= new List<Models.Certificate>();
            certificates = Database.GetUserCertificates(user);
            for (int i = 0; i < certificates.Count; i++)
            {
                Certificate certificate = new Certificate();
                certificate.LabelName.Text = $"Сертификат #{certificates[i].id}";
                certificate.OptionRole.Text = "Редактировать";
                CertificatesList.Controls.Add(certificate);
            }
        }

        private void EmployeeController_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.Show();
        }
    }
}
