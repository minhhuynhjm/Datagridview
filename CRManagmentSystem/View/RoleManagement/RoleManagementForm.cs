using CRManagmentSystem.Common;
using CRManagmentSystem.Models.RoleManagement;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRManagmentSystem.View.RoleManagement
{
    public partial class RoleManagementForm : Form
    {
        public RoleManagementForm(string appKind)
        {
            AppKind = appKind;
            InitializeComponent();
        }

        /// <summary>
        /// AppKind
        /// </summary>
        private string AppKind { get; set; }

        // Global variable
        private string LoginId { get; set; }
        private string RoleIds { get; set; }
        private string UserIds { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RoleManagement_Load(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.RoleManagementBLO];

                // List role user access to this form
                List<SysRoleModel> checkAccessRole = CommonUtility.DynamicToObject<List<SysRoleModel>>(instance.GetAccessRole(CommonConstant.UserInfo.UserId));
                if (checkAccessRole.Count == 0)
                {
                    Dialog.Error(MessageConstant.CheckRoleScreen);
                    Close();
                }
                else
                {
                    // List role user enable button
                    List<SysRoleModel> checkUserRole = CommonUtility.DynamicToObject<List<SysRoleModel>>(instance.CheckButtonRole(CommonConstant.UserInfo.UserId));
                    if (checkUserRole.Count == 0)
                    {
                        // Hide the button if user not in role
                        btnUpdate.Hide();
                    }

                    //Binding Combobox FuncList
                    BindingComboboxFuncList(instance);

                    // Binding Combobox Department
                    BindingComboboxDepartment(instance);
                }
            }
            catch (Exception ex)
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.Error(ex.Message);
            }

        }


        /// <summary>
        /// Binding Combobox FuncList
        /// </summary>
        /// <param name="instance">instance</param>
        private void BindingComboboxFuncList(dynamic instance)
        {
            var funcname = instance.ListFunctionName();
            List<MstRoleModel> listMstRoleModel = CommonUtility.DynamicToObject<List<MstRoleModel>>(funcname);
            foreach (var item in listMstRoleModel)
            {
                if (!string.IsNullOrEmpty(item.FUNCNAME))
                {
                    cboFunctionList.Items.Add(item.FUNCNAME);
                }
            }
        }

        /// <summary>
        /// Binding Combobox Department
        /// </summary>
        /// <param name="instance">instance</param>
        private void BindingComboboxDepartment(dynamic instance)
        {
            // List department from postname in database
            List<MstPostModel> depart = CommonUtility.DynamicToObject<List<MstPostModel>>(instance.ListDepartment());
            Dictionary<string, string> comboboxDictionary = new Dictionary<string, string>();
            comboboxDictionary.Add("", "");
            foreach (var item in depart)
            {
                comboboxDictionary.Add(item.POSTID, item.POSTNAME);
            }
            CommonUtility.BindingCombobox(cboDepartment, comboboxDictionary);
        }


        // Click Button 更新				
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if users don't have any role, show message
                List<SysRoleModel> roles = new List<SysRoleModel>();
                bool flag = false;

                // Check row count in datagridview
                for (int i = 0; i < dgvRole.Rows.Count; i++)
                {
                    // Check column in  datagridview
                    for (int j = 2; j < dgvRole.ColumnCount; j++)
                    {
                        bool isCheck = Convert.ToBoolean(dgvRole.Rows[i].Cells[j].Value);
                        if (isCheck)
                        {
                            flag = true;

                            // If check = true add to list
                            roles.Add(new SysRoleModel
                            {
                                USERID = dgvRole.Rows[i].Cells[CommonConstant.UserId].Value.ToString(),
                                ROLEID = dgvRole.Rows[i].Cells[j].OwningColumn.Name.ToString(),
                                UPDATEDATE = DateTime.Now,
                                UPDUSER = CommonConstant.UserInfo.UserId
                            });
                        }
                    }

                    // If false show message
                    if (!flag)
                    {
                        Dialog.Warning(MessageConstant.NoRoleSelected);
                        return;
                    }
                    flag = false;
                }

                // Update role in database
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.RoleManagementBLO];
                bool updateRole = instance.UpdateRole(UserIds, RoleIds, roles);
                if (updateRole)
                {
                    // To do viet vao contanst
                    // Message success
                    Dialog.Info(MessageConstant.SuccessMessage);
                }
                else
                {
                    // Log error to file
                    Dialog.Error(MessageConstant.ErrorUpdateRole);
                    CommonConstant.Logger.Error(MessageConstant.RollbackUpdateRole);
                }
            }
            catch (Exception)
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        // Click Button 検索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if function it not choose
                if (cboFunctionList.SelectedIndex == -1)
                {
                    Dialog.Warning(MessageConstant.ChooseOneItemInList);
                    this.ActiveControl = cboFunctionList;
                }
                else
                {
                    dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.RoleManagementBLO];

                    string funcName = cboFunctionList.Text;
                    string postName = cboDepartment.SelectedValue?.ToString();
                    string fullName = txtFullname.Text;
                    // Get list search row
                    List<MstRoleModel> listRoleModel = CommonUtility.DynamicToObject<List<MstRoleModel>>(instance.SearchRow(postName, fullName));

                    // Clear datagridview
                    dgvRole.Columns.Clear();
                    dgvRole.Rows.Clear();
                    dgvRole.Refresh();

                    if (listRoleModel.Count == 0)
                    {
                        Dialog.Info(MessageConstant.NoSearchResults);
                    }
                    else
                    {
                        AddDataToDatagridview(instance, funcName, listRoleModel);
                    }
                }
            }
            catch (Exception)
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            }
        }

        /// <summary>
        /// Add Data TO Datagridview
        /// </summary>
        private void AddDataToDatagridview(dynamic instance, string funcname, List<MstRoleModel> listRoleModel)
        {
            // Search column role by function name
            List<string> listRoleId = new List<string>();
            List<string> listUserId = new List<string>();

            List<MstRoleModel> columns = CommonUtility.DynamicToObject<List<MstRoleModel>>(instance.SearchColumn(funcname));
            dgvRole.Columns.Add(CommonConstant.UserId, CommonConstant.UserId);
            dgvRole.Columns.Add(CommonConstant.FullName, CommonConstant.FullName);
            dgvRole.Columns[CommonConstant.UserId].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRole.Columns[CommonConstant.FullName].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRole.Columns[CommonConstant.FullName].ReadOnly = true;
            
            foreach (var column in columns)
            {
                // Auto resize column and rows in dgv
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = column.ROLEID;
                checkColumn.HeaderText = column.ROLENAME;
                checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvRole.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 10;
                dgvRole.Columns.Add(checkColumn);

                // Add list Role
                listRoleId.Add($"'{column.ROLEID}'");
            }

            RoleIds = string.Join(",", listRoleId);
            
            if (listRoleModel != null && listRoleModel.Count > 0)
            {
                // Get result from searchrow function
                foreach (var row in listRoleModel)
                {
                    listUserId.Add($"'{row.USERID}'");
                    dgvRole.Rows.Add(row.USERID, row.USERNAME);
                }

                // Visible Column UserId
                dgvRole.Columns[CommonConstant.UserId].Visible = false;

                UserIds = string.Join(",", listUserId);
            }

            // Check role
            List<SysRoleModel> listSystemRole = CommonUtility.DynamicToObject<List<SysRoleModel>>(instance.GetRoleChecked(UserIds, RoleIds));

            if (listSystemRole != null)
            {
                // Get rows from data gridview
                foreach (DataGridViewRow row in dgvRole.Rows)
                {
                    var userId = row.Cells[CommonConstant.UserId].Value.ToString();

                    foreach (var item in listSystemRole)
                    {
                        if (userId.Equals(item.USERID))
                        {
                            row.Cells[item.ROLEID].Value = true;
                        }
                    }
                }
            }
        }
    }
}
