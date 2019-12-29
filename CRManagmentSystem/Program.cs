using CRManagmentSystem.Common;
using CRManagmentSystem.Menu;
using CRManagmentSystem.View.FacilitySystem;
using CRManagmentSystem.View.Login;
using System;
using System.Windows.Forms;

namespace CRManagmentSystem
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommonConstant.LoginForm = new LoginForm();
            Application.Run(new FacilitySystemDetailForm(CommonConstant.FacilityDetailMode.SystemEdit, null, null));
        }
    }
}
