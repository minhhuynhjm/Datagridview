using CRManagmentSystem.BusinessLogic;
using CRManagmentSystem.Common;
using CRManagmentSystem.Menu;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace CRManagmentSystem.View.Login
{
    public partial class LoginForm : Form
    {
        private MenuForm menuForm;
        private LoginBLO loginBLO;

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Button ログイン
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.loginBLO = new LoginBLO();

            // Get domain name "ldap.cmcglobal.com.vn";
            string domain = ConfigurationManager.AppSettings["Domain"];

            string userId = txtUserId.Text;
            string password = txtPassword.Text;
            List<string> listRoles = null;

            // Login with Guest
            if (string.IsNullOrEmpty(userId) && string.IsNullOrEmpty(password))
            {
                CommonConstant.LoginForm.Hide();
                this.menuForm = new MenuForm(listRoles);
                this.menuForm.Show();   
            }
            else
            {
                if (string.IsNullOrEmpty(userId))
                {
                    Dialog.Error(MessageConstant.UserIdNotEnter);
                }
                else if (string.IsNullOrEmpty(password))
                {
                    Dialog.Error(MessageConstant.PasswordNotEnter);
                }
                else
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                    {
                        // Validate the credentials
                        bool isValid = pc.ValidateCredentials(userId, password);

                        if (isValid)
                        {
                            // Stored userId in static
                            CommonConstant.UserInfo.UserId = userId;
                            try
                            {
                                listRoles = this.loginBLO.GetRolesUser(userId);

                                CommonConstant.LoginForm.Hide();
                                this.menuForm = new MenuForm(listRoles);
                                this.menuForm.Show();
                            }
                            catch (Exception)
                            {
                                txtPassword.Clear();
                                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                            }
                        }
                        else
                        {
                            txtPassword.Clear();
                            Dialog.Error(MessageConstant.LoginFailed);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Press enter to login
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">KeyEventArgs</param>
        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        /// <summary>
        /// Press enter to login
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">KeyEventArgs</param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
