using CRManagmentSystem.Common;
using CRManagmentSystem.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRManagmentSystem.View.UserManagement
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm(string appKind)
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            if (!CheckRoleByUserId(CommonConstant.UserInfo.UserId))
            {
                Close();
            }
            else
            {
                this.ActiveControl = txtUsername;
            }
        }

        /// <summary>
        /// Click button 検索
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
                string username = txtUsername.Text;
                //Dictionary parameter
                Dictionary<string, object> paramSearchUser = new Dictionary<string, object>
                {
                    {"username", username}
                };
                // Search user by username from UserManagementBLO
                dgvListUser.DataSource = null;
                int countUser = instance.CountUser(paramSearchUser);
                if (countUser > 1000)
                {
                    Dialog.Warning(MessageConstant.MoreThan1000);
                }
                else
                {
                    var result = instance.SearchUser(paramSearchUser);
                    if (result.Count == 0)
                    {
                        Dialog.Info(MessageConstant.NoSearchResults);
                    }
                    else
                    {
                        List<MstUserViewModel> listUser = CommonUtility.DynamicToObject<List<MstUserViewModel>>(result);
                        dgvListUser.DataSource = listUser;
                    }
                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
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
        ///  Click button 詳細
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListUser.SelectedRows.Count > 0)
                {
                    string userId = dgvListUser.SelectedCells[0].Value.ToString();
                   dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
                    var checkExistUser = instance.GetUserByUserId(userId);
                    if (checkExistUser == null)
                    {
                        Dialog.Warning(MessageConstant.UserNotExist);
                    }
                    else
                    {
                        DetailUserForm detailUserForm = new DetailUserForm(userId);
                        detailUserForm.ShowDialog();
                    }
                }
                else
                {
                    Dialog.Warning(MessageConstant.NoUserSelected);
                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        /// <summary>
        /// Click button 追加
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
                Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(CommonConstant.UserInfo.UserId);
                if (!checkRoleBtn["btnAdd"])
                {
                    Dialog.Warning(MessageConstant.CheckRoleScreen);
                }
                else
                {
                    AddUserForm addUserForm = new AddUserForm();
                    addUserForm.ShowDialog();
                    this.refreshDatagridView();
                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        /// <summary>
        /// Click button 更新
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
                Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(CommonConstant.UserInfo.UserId);
                if (!checkRoleBtn["btnUpdate"])
                {
                    Dialog.Warning(MessageConstant.CheckRoleScreen);
                }
                else
                {
                    if (dgvListUser.SelectedRows.Count > 0)
                    {
                        string userId = dgvListUser.SelectedCells[0].Value.ToString();
                        var checkExistUser = instance.GetUserByUserId(userId);
                        if (checkExistUser == null)
                        {
                            Dialog.Warning(MessageConstant.UserNotExist);
                        }
                        else
                        {
                            UpdateUserForm updateUserForm = new UpdateUserForm(userId);
                            updateUserForm.ShowDialog();
                            this.refreshDatagridView();
                        }
                    }
                    else
                    {
                        Dialog.Warning(MessageConstant.NoUserSelected);
                    }
                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        /// <summary>
        /// Click button 削除
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListUser.SelectedRows.Count > 0)
                {
                    bool confirm = Dialog.Confirm(MessageConstant.ConfirmDeleteUser);
                    if (confirm)
                    {
                        string userId = dgvListUser.SelectedCells[0].Value.ToString();
                        dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
                        var checkExistUser = instance.GetUserByUserId(userId);
                        if (checkExistUser == null)
                        {
                            Dialog.Warning(MessageConstant.UserNotExist);
                        }
                        else
                        {
                            var userDelete = instance.DeleteUser(userId);
                            if (userDelete)
                            {
                                Dialog.Info(MessageConstant.UserHasBeenDelete);
                                this.refreshDatagridView();
                            }
                        }
                    }
                }
                else
                {
                    Dialog.Warning(MessageConstant.NoUserSelected);

                }
            }
            catch (Exception ex)
            {
                // To do log
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        /// <summary>
        /// Refresh DataGridview List user
        /// </summary>
        public void refreshDatagridView()
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            string username = txtUsername.Text;
            dgvListUser.DataSource = null;
            //Dictionary parameter
            Dictionary<string, object> paramSearchUser = new Dictionary<string, object>
                {
                    {"username", username}
                };
            // Refesh search user by username from UserManagementBLO
            int countUser = instance.CountUser(paramSearchUser);
            if (countUser > 1000)
            {
                Dialog.Warning(MessageConstant.MoreThan1000);
            }
            else
            {
                var result = instance.SearchUser(paramSearchUser);
                if (result.Count == 0)
                {
                    Dialog.Info(MessageConstant.NoSearchResults);
                }
                else
                {
                    List<MstUserViewModel> listUser = CommonUtility.DynamicToObject<List<MstUserViewModel>>(result);
                    dgvListUser.DataSource = listUser;
                }
            }
        }

        /// <summary>
        /// Check role button by userId
        /// </summary>
        /// <param name="userId">userId</param>
        public bool CheckRoleByUserId(string userId)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            // Check role user into screen by userId from UserManagementBLO
            bool checkRoleScreen = instance.CheckRoleScreenListByUserId(userId);

            // Check role button screen by userId from UserManagementBLO
            Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(userId);
            if (!checkRoleScreen)
            {
                Dialog.Warning(MessageConstant.CheckRoleScreen);
                Close();
                return false;
            }
            if (!checkRoleBtn["btnAdd"])
            {
                btnDelete.Location = btnUpdate.Location;
                btnUpdate.Location = btnAdd.Location;
                btnAdd.Visible = false;
            }
            if (!checkRoleBtn["btnUpdate"])
            {
                if (!btnAdd.Visible)
                {
                    btnDelete.Location = btnAdd.Location;
                }
                else
                {
                    btnDelete.Location = btnUpdate.Location;
                }
                btnUpdate.Visible = false;
            }
            if (!checkRoleBtn["btnDelete"])
            {
                btnDelete.Visible = false;
            }
            return true;
        }
    }
}
