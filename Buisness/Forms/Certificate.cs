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
    public partial class Certificate : UserControl
    {
        Models.Certificate certificate;
        public Certificate(Models.Certificate certificate)
        {
            InitializeComponent();
            this.certificate = certificate;
            if (certificate.isApproved)
            {
                OptionRole.Enabled = false;
                OptionRole.Text = "Одобрено";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{LabelName.Text}\n\n(Информация о сертификате)");
        }

        private void OptionRole_Click(object sender, EventArgs e)
        {
            Database.ApproveCertificate(certificate.id);
            this.certificate = Database.GetCertificateById(certificate.id);
        }
    }
}
