using Buisness.Models;
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
    public partial class Employee : UserControl
    {
        public User user;
        public FlowLayoutPanel Certs;

        public Employee(User user, FlowLayoutPanel certs)
        {
            InitializeComponent();
            this.user = user;
            button1.Text = this.user.Name;
            Certs = certs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Certs.Controls.Clear();
            List<Models.Certificate> certificates = Utility.Database.GetUserCertificates(user);
            foreach (Models.Certificate certificate in certificates)
            {
                Certificate certificateElement = new Certificate();
                certificateElement.LabelName.Text = $"Сертификат #{certificate.id}";
                Certs.Controls.Add(certificateElement);
            }
            Application.OpenForms.OfType<AdminController>().First().CertsPanel = Certs;
        }
    }
}
