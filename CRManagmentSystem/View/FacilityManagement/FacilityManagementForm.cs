using CRManagmentSystem.Common;
using CRManagmentSystem.Models.FacilityManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.FacilityManagement
{
    public partial class FacilityManagementForm : Form
    {
        private string LoginId;
        public FacilityManagementForm(string appKind)
        {
            AppKind = appKind;

            InitializeComponent();
            btnSearch.Enabled = false;
        }

        /// <summary>
        ///  AppKind
        /// </summary>
        private string AppKind { get; set; }

        // Click button 検索	
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEquipment.DataSource = null;
            // Don't forget to re-enable the button
            btnSearch.Enabled = true;
            // Add post name and user name get from combobox and text field to search values
            string Division = cboEquipmentList.SelectedValue?.ToString().Split(',').Last();
            string equipmentId = txtEquipmentID.Text;
            string equipmentName = txtEquipmentName.Text;

            // Get list division
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            // List equipment of search
            List<MstFacilityDivisionModel> listEquipment = CommonUtility.DynamicToObject<List<MstFacilityDivisionModel>>(instance.SearchEquipmentList(Division, equipmentId, equipmentName));

            // Check if null show message
            if (listEquipment.Count == 0)
            {
                Dialog.Info(MessageConstant.NoSearchResults);
            }
            else
            {
                // Add Search Value
                dgvEquipment.DataSource = listEquipment;
                dgvEquipment.Columns["FACILITYKBN"].Visible = false;
            }

        }

        // Click button 閉じる
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquipmentManagement_Load(object sender, EventArgs e)
        {
            // Get id login
            this.getLoginId();

            // Maken screen center
            this.CenterToScreen();

            if (!CheckRoleUserIDs(CommonConstant.UserInfo.UserId))
            {
                this.Close();
            }
            else
            {
                this.ActiveControl = txtEquipmentID;
            }

            // Get list division
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            var result = instance.ListDivision();
            // Get list division to combobox
            List<MstDivisionModel> listDivision = CommonUtility.DynamicToObject<List<MstDivisionModel>>(result);
            Dictionary<string, string> comboboxDictionary = new Dictionary<string, string>();
            comboboxDictionary.Add("", "");
            foreach (var item in listDivision)
            {
                // Hide parent_id and child_id but just use child_id
                comboboxDictionary.Add(item.PARENT_ID + "," + item.CHILD_ID, item.DIV_NAME);
            }
            cboEquipmentList.DataSource = new BindingSource(comboboxDictionary, null);
            cboEquipmentList.DisplayMember = "Value";
            cboEquipmentList.ValueMember = "Key";
        }

        // Get login id from menu screen
        private void getLoginId()
        {
            // Dummy data
            LoginId = AppKind;
        }

        public bool CheckRoleUserIDs(string userIds)
        {
            // Check role when access to this form
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            // Check role access to screen
            bool checkRoleAccess = instance.CheckUserRoleAccess(userIds);

            // Check if user doesn't have role hide this button and change location
            Dictionary<string, bool> checkRoleBtn = instance.CheckUserRoleButton(userIds);
            if (!checkRoleAccess)
            {
                Dialog.Warning(MessageConstant.CheckRoleScreen);
                this.Close();
                return false;
            }
            if (!checkRoleBtn["btnAdd"] && !checkRoleBtn["btnUpdate"] && !checkRoleBtn["btnDelete"])
            {
                btnDelete.Location = btnUpdate.Location;
                btnUpdate.Location = btnAdd.Location;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
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

        // Click Button 追加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFacilityManagementForm addEquipmentManagementForm = new AddFacilityManagementForm(AppKind);
            addEquipmentManagementForm.ShowDialog();
        }

        // Click button 詳細
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count > 0)
            {
                string equipmentKbn = dgvEquipment.SelectedCells[0].Value.ToString();
                string equipmentId = dgvEquipment.SelectedCells[2].Value.ToString();
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];
                var checkEquipmentKbnExist = instance.GetFacilityKbnId(equipmentKbn, equipmentId);
                if (checkEquipmentKbnExist == null)
                {
                    Dialog.Warning(MessageConstant.EquipmentNotSelected);
                }
                else
                {
                    DetailFacilityManagementForm detailFacilityForm = new DetailFacilityManagementForm(equipmentKbn, equipmentId, AppKind);
                    detailFacilityForm.ShowDialog();
                }
            }
            else
            {
                Dialog.Warning(MessageConstant.EquipmentNotSelected);
            }
        }

        // Click button 更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count > 0)
            {
                string equipmentKbn = dgvEquipment.SelectedCells[0].Value.ToString();
                string equipmentId = dgvEquipment.SelectedCells[2].Value.ToString();
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];
                var checkEquipmentKbnExist = instance.GetFacilityKbnId(equipmentKbn, equipmentId);
                if (checkEquipmentKbnExist == null)
                {
                    Dialog.Warning(MessageConstant.EquipmentNotSelected);
                }
                else
                {
                    UpdateFacilityManagementForm updateEquipmentManagementForm = new UpdateFacilityManagementForm(equipmentKbn, equipmentId, AppKind);
                    updateEquipmentManagementForm.ShowDialog();
                }
            }
            else
            {
                Dialog.Warning(MessageConstant.EquipmentNotSelected);
            }
        }

        // check if cboequipment null disable search button
        private void cboEquipmentList_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = CheckNull();
        }

        // check if equipmentid null disable search button
        private void txtEquipmentID_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = CheckNull();
        }

        // check if equipmentname null disable search button
        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = CheckNull();
        }

        /// <summary>
        /// check if field is null disable search button
        /// </summary>
        /// <returns></returns>
        private bool CheckNull()
        {
            if (!string.IsNullOrWhiteSpace(cboEquipmentList.Text) && !string.IsNullOrWhiteSpace(txtEquipmentID.Text) && !string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Focus first cbo on load
        private void EquipmentManagementForm_Shown(object sender, EventArgs e)
        {
            cboEquipmentList.Focus();
        }

        // Click Button 削除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Division = cboEquipmentList.SelectedValue?.ToString();
            if (dgvEquipment.SelectedRows.Count > 0)
            {
                bool confirm = Dialog.Confirm(MessageConstant.ConfirmDeleteUser);
                if (confirm)
                {
                    string facilityKbn = Division.Split(',').Last();
                    string facilityId = dgvEquipment.SelectedCells[2].Value.ToString();

                    dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];
                    var equipmentDelete = instance.DeleteEquipment(facilityKbn, facilityId);
                    if (equipmentDelete)
                    {
                        Dialog.Info(MessageConstant.UserHasBeenDelete);
                        btnSearch_Click(sender, e);
                    }
                }
            }
            else
            {
                Dialog.Warning(MessageConstant.NoUserSelected);
            }
        }

        // Click Button エクスポート
        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = "APPARATUS_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            if (!CommonUtility.ExportToCSV(dgvEquipment, fileName))
            {
                Dialog.Error(MessageConstant.ExportCSVFailed);
            }
        }
    }
}
