using Buisness.Forms;
using System;
using System.Windows.Forms;

namespace Buisness
{
    public static class Program
    {
        public static Main mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Main();
            Application.Run(mainForm);
        }
    }
}
