using CRManagmentSystem.Common;
using CRManagmentSystem.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRManagmentSystem.View.UserManagement
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm(string userId)
        {
            InitializeComponent();
            txtId.Text = userId;
        }


        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            this.ActiveControl = txtPassword;
            string userId = txtId.Text;
            // Get all MST_POST from UserManagementBLO
            var resultListPost = instance.GetAllMstPost();
            List<MstPostModel> listPost = CommonUtility.DynamicToObject<List<MstPostModel>>(resultListPost);
            // Get user by userId from UserManagementBLO
            var resultUserById = instance.GetUserByUserId(userId);
            MstUserModel userById = CommonUtility.DynamicToObject<MstUserModel>(resultUserById);
            // Create combobox department
            BindingDataCombobox(listPost);
            if (userById.POSTID != null)
            {
                cboDepartment.SelectedValue = userById.POSTID;
            }
            txtPassword.Text = userById.PASSWORD;
            txtPasswordConfirm.Text = userById.PASSWORD;
            txtFullName.Text = userById.USERNAME;

            // Get all role from UserManagementBLO
            var result = instance.GetAllRole();
            List<MstRoleModel> listRole = CommonUtility.DynamicToObject<List<MstRoleModel>>(result);
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Width = 30;
            dgvDetailUser.RowHeadersVisible = false;

            dgvDetailUser.Columns.Add(checkColumn);
            dgvDetailUser.DataSource = listRole;
            dgvDetailUser.Columns[CommonConstant.RoleId].Visible = false;

            // Get role of user from UserManagementBLO
            var listRoleUser = instance.GetRoleByUserId(userId);
            foreach (DataGridViewRow row in dgvDetailUser.Rows)
            {
                //checked checkbox role
                if (listRoleUser != null)
                {
                    foreach (var item in listRoleUser)
                    {
                        if (item.ROLEID == row.Cells[CommonConstant.RoleId].Value.ToString())
                        {
                            DataGridViewCheckBoxCell checkBoxRole = (DataGridViewCheckBoxCell)row.Cells[0];
                            checkBoxRole.Value = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Button update user
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txtId;
                dynamic instance = CommonUtility.CreateInstanceDll(FunctionDllConstant.UserManagementBLO, FunctionDllConstant.UserManagementBLO, this);
                string userId = txtId.Text;
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
                    Dictionary<string, object> paramUpdateUser = new Dictionary<string, object>
                {
                    {"userId", userId},
                    {"password", password},
                    {"username", username},
                    {"postId", deparment},
                    {"upuser", CommonConstant.UserInfo.UserId}
                };
                    var updateUser = instance.UpdateUser(paramUpdateUser);
                    if (updateUser)
                    {
                        var deleteSysRole = instance.DeleteSysRole(userId);
                        if (deleteSysRole)
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
                        }
                    }
                    else
                    {
                        Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
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
            if (!regexItem.IsMatch(userId))
            {
                Dialog.Warning(MessageConstant.IdInvalid);
                this.ActiveControl = txtId;
                return false;
            }

            // Check exist user
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            var checkExistUser = instance.GetUserByUserId(userId);
            if (checkExistUser == null)
            {
                Dialog.Warning(MessageConstant.UserNotExist);
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
                Dialog.Warning(MessageConstant.NoUserSelected);
                this.ActiveControl = txtFullName;
                return false;
            }
            if (username.Length > 25)
            {
                Dialog.Warning(MessageConstant.UserNameTooLong);
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
        /// Button close 閉じる
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
