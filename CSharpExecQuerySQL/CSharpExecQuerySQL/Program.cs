using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExecQuerySQL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult loginResult;
            using (var loginForm = new LoginForm())
                loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
                Application.Run(new Dashboard());
        }
    }
}