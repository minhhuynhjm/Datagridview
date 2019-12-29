using CRManagmentSystem.Common;
using CRManagmentSystem.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRManagmentSystem.View.UserManagement
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];

            //focus texbox Id
            this.ActiveControl = txtId;
            // Get all MST_POST from UserManagementBLO
            var resultListPost = instance.GetAllMstPost();
            List<MstPostModel> listPost = CommonUtility.DynamicToObject<List<MstPostModel>>(resultListPost);
            BindingDataCombobox(listPost);

            // Get all role from UserManagementBLO
            var result = instance.GetAllRole();
            List<MstRoleModel> listRole = CommonUtility.DynamicToObject<List<MstRoleModel>>(result);
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Width = 30;
            dgvDetailUser.RowHeadersVisible = false;

            dgvDetailUser.Columns.Add(checkColumn);
            dgvDetailUser.DataSource = listRole;
            dgvDetailUser.Columns[CommonConstant.RoleId].Visible = false;

        }

        /// <summary>
        /// Click button 閉じる
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button add user
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txtId;
                dynamic instance = CommonUtility.CreateInstanceDll(FunctionDllConstant.UserManagementBLO, FunctionDllConstant.UserManagementBLO, this);
                string userId = txtId.Text.Replace(" ", String.Empty);
                string password = txtPassword.Text;
                string passwordConfirm = txtPasswordConfirm.Text;
                string username = txtFullName.Text;
                string deparment = null;
                if (cboDepartment.SelectedValue != null)
                {
                    deparment = cboDepartment.SelectedValue.ToString();
                }

                /// Check userId && check password && check username && check role selected 
                if (CheckUserId(userId) && CheckPassword(password, passwordConfirm) && CheckUsername(username) && CheckRoleSelected())
                {
                    //Dictionary parameter
                    Dictionary<string, object> paramAddUser = new Dictionary<string, object>
                {
                    {"userId", userId},
                    {"password", password},
                    {"username", username},
                    {"postId", deparment},
                    {"upuser", CommonConstant.UserInfo.UserId}
                };
                    var addUser = instance.AddUser(paramAddUser);
                    if (addUser)
                    {
                        foreach (DataGridViewRow row in dgvDetailUser.Rows)
                        {
                            bool checkRoleSelectedAdd = Convert.ToBoolean(row.Cells[0].Value);
                            if (checkRoleSelectedAdd)
                            {
                                SysRoleModel sysRoleModel = new SysRoleModel();
                                sysRoleModel.USERID = userId;
                                sysRoleModel.ROLEID = row.Cells[CommonConstant.RoleId].Value.ToString();
                                sysRoleModel.UPDUSER = CommonConstant.UserInfo.UserId;
                                instance.AddSysRole(sysRoleModel);
                            }
                        }
                        Dialog.Info(MessageConstant.SuccessMessage);
                        txtId.Text = null;
                        txtPassword.Text = null;
                        txtPasswordConfirm.Text = null;
                        txtFullName.Text = null;
                        cboDepartment.SelectedItem = null;
                        cboDepartment.SelectedText = null;
                        foreach (DataGridViewRow row in dgvDetailUser.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxRole = (DataGridViewCheckBoxCell)row.Cells[0];
                            checkBoxRole.Value = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.ErrorFormat(MessageConstant.RollbackUpdateUser, ex.Message);
                Dialog.Error(MessageConstant.ErrorLogUpdateUser);
            }
        }


        /// <summary>
        /// Check userId 
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>bool</returns>
        public bool CheckUserId(string userId)
        {
            if (String.IsNullOrEmpty(userId))
            {
                Dialog.Warning(MessageConstant.IdNotEntered);
                this.ActiveControl = txtId;
                return false;
            }

            if (userId.Length > 10)
            {
                Dialog.Warning(MessageConstant.IdTooLong);
                this.ActiveControl = txtId;
                return false;
            }

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(userId)) {
                Dialog.Warning(MessageConstant.IdInvalid);
                this.ActiveControl = txtId;
                return false;
            }

            /// check exist user
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            var checkExistUser = instance.GetUserByUserId(userId);
            if (checkExistUser != null)
            {
                Dialog.Warning(MessageConstant.UserExist);
                this.ActiveControl = txtId;
                return false;
            }
            return true;
        }


        /// <summary>
        /// Check passwork
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="passwordConfirm">passwordConfirm</param>
        /// <returns>true or false</returns>
        public bool CheckPassword(string password, string passwordConfirm)
        {
            if (String.IsNullOrEmpty(password))
            {
                Dialog.Warning(MessageConstant.NoPasswordSelected);
                this.ActiveControl = txtPassword;
                return false;
            }

            if (password.Length < 8)
            {
                Dialog.Warning(MessageConstant.PasswordTooShort);
                this.ActiveControl = txtPassword;
                return false;
            }

            if (password.Length > 16)
            {
                Dialog.Warning(MessageConstant.PasswordTooLong);
                this.ActiveControl = txtPassword;
                return false;
            }
            foreach (char c in password)
            {
                bool checkCharater = CommonUtility.IsWideEastAsianWidth_SJIS(c);
                if (checkCharater)
                {
                    Dialog.Warning(MessageConstant.PasswordInvalid);
                    this.ActiveControl = txtPassword;
                    return false;
                }
            }
            if (password != passwordConfirm)
            {
                Dialog.Warning(MessageConstant.PasswordNotMatchCofirm);
                this.ActiveControl = txtPassword;
                return false;
            }

            return true;
        }


        /// <summary>
        /// Check username
        /// </summary>
        /// <param name="username">username</param>
        /// <returns>bool</returns>
        public bool CheckUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                Dialog.Warning(MessageConstant.UserNameNotEntered);
                this.ActiveControl = txtFullName;
                return false;
            }
            if (username.Length > 25)
            {
                MessageBox.Show(MessageConstant.UserNameTooLong, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = txtFullName;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check role seleted
        /// </summary>
        /// <returns>bool</returns>
        public bool CheckRoleSelected()
        {
            bool checkRoleSelected = false;
            foreach (DataGridViewRow row in dgvDetailUser.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkRoleSelected = true;
                    break;
                }
            }
            if (!checkRoleSelected)
            {
                Dialog.Warning(MessageConstant.NoRoleSelected);
                this.ActiveControl = dgvDetailUser;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Binding data combobox
        /// </summary>
        /// <param name="listPost"></param>
        private void BindingDataCombobox(List<MstPostModel> listPost)
        {
            Dictionary<string, string> postDictionary = new Dictionary<string, string>();
            postDictionary.Add("", "");
            foreach (var post in listPost)
            {
                postDictionary.Add(post.POSTID, post.POSTNAME);
            }

            CommonUtility.BindingCombobox(cboDepartment, postDictionary);
        }
    }
}
