using CRManagmentSystem.Common;
using CRManagmentSystem.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRManagmentSystem.View.UserManagement
{
    public partial class DetailUserForm : Form
    {
        public DetailUserForm(string userId)
        {
            InitializeComponent();
            txtId.Text = userId;
        }

        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void DetailUserForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtId;
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.UserManagementBLO];
            string userId = txtId.Text;
            // Get all MST_POST from UserManagementBLO
            var resultListPost = instance.GetAllMstPost();
            List<MstPostModel> listPost = CommonUtility.DynamicToObject<List<MstPostModel>>(resultListPost);
            // Get user by userId from UserManagementBLO
            var resultUserById = instance.GetUserByUserId(userId);
            MstUserModel userById = CommonUtility.DynamicToObject<MstUserModel>(resultUserById);

            // Create combobox department
            Dictionary<string, string> postDictionary = new Dictionary<string, string>();
            foreach (var post in listPost)
            {
                postDictionary.Add(post.POSTID, post.POSTNAME);
            }

            CommonUtility.BindingCombobox(cboDepartment, postDictionary);

            cboDepartment.SelectedItem = null;
            cboDepartment.SelectedText = null;
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

            this.dgvDetailUser.Columns[CommonConstant.Description].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetailUser.Columns[CommonConstant.RoleId].Visible = false;
            // Get role of user from UserManagementBLO
            var listRoleUser = instance.GetRoleByUserId(userId);
            foreach (DataGridViewRow row in dgvDetailUser.Rows)
            {
                //disable checkbox
                DataGridViewCheckBoxCell disableCheckBox = (DataGridViewCheckBoxCell)row.Cells[0];
                disableCheckBox.ReadOnly = true;
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

        //Button close 閉じる
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
