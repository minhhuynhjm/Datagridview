using CRManagmentSystem.Common;
using CRManagmentSystem.Models.FacilitySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.FacilitySystem
{
    public partial class FacilitySystemForm : Form
    {
        public FacilitySystemForm(string appKind)
        {
            AppKind = appKind;
            InitializeComponent();
        }

        private string AppKind { get; set; }

        private void FacilitySystemForm_Load(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilitySystemBLO];

                // Check role Initial
                if (CheckRoleInitial(CommonConstant.UserInfo.UserId))
                {
                    // Create combobox SystemType
                    BindingDataSystemType(instance, cboSystemType);

                    var resultListDivision = instance.GetDivision120to160();
                    // Create combobox Period - 120
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPeriod, cboPeriod);
                    // Create combobox Hierachy Tier1, Tier2 - 130
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboTier1);
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboTier2);
                    // Create combobox Area - 140
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionArea, cboArea);
                    // Create combobox Pillar1, Pillar2 - 150
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar1);
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar2);
                    // Create combobox Street1, Street2 - 160
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet1);
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet2);

                    // Focus Textbox DeviceId
                    this.ActiveControl = txtDeviceId;
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.Error(ex.Message);
                Close();
            }
        }

        /// <summary>
        /// Click Button Search: 検索
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilitySystemBLO];

                // Get data from form
                string childId = null;
                if (!string.IsNullOrEmpty(cboSystemType.SelectedValue.ToString()))
                {
                    childId = cboSystemType.SelectedValue.ToString().Split(':')[1];
                }

                Dictionary<string, object> searchParam = new Dictionary<string, object>
                {
                    {"device_id", txtDeviceId.Text },
                    {"child_id", childId },
                    {"system_value", txtSystemValue.Text },
                    {"device_name", txtEquipmentName.Text },
                    {"period", cboPeriod.Text },
                    {"tier1", cboTier1.Text },
                    {"tier2", cboTier2.Text },
                    {"area", cboArea.Text },
                    {"pillar1", cboPillar1.Text },
                    {"pillar2", cboPillar2.Text },
                    {"street1", cboStreet1.Text },
                    {"street2", cboStreet2.Text },
                };

                // Search Facility System
                var result = instance.Search(searchParam);
                dgvListFacility.DataSource = null;

                if (result.Count == 0)
                {
                    Dialog.Info(MessageConstant.NoSearchResults);
                }
                else
                {
                    if (!CommonUtility.IsMoreThan1000Record(result.Count))
                    {
                        List<MstApparatusViewModel> listFacility = CommonUtility.DynamicToObject<List<MstApparatusViewModel>>(result);
                        dgvListFacility.DataSource = listFacility;
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.Error(ex.Message);
            }
        }

        /// <summary>
        /// Click Button Detail: 詳細
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvListFacility.SelectedRows.Count > 0)
            {
                string deviceId = dgvListFacility.SelectedCells[0].ToString();
                // To do Open Screen SystemDetail - Model Device Details
            }
            else
            {
                Dialog.Warning(MessageConstant.NoDeviceSelected);
            }
        }

        /// <summary>
        /// Click Button System: 系統
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSystem_Click(object sender, EventArgs e)
        {
            string systemSearchVaule = txtSystemValue.Text;
            if (!string.IsNullOrEmpty(cboSystemType.SelectedValue.ToString()))
            {
                string childId = cboSystemType.SelectedValue.ToString().Split(':')[1];

                if (!string.IsNullOrEmpty(systemSearchVaule))
                {
                    // To do Open Screen system details - Model System Details
                }
                else
                {
                    Dialog.Warning(MessageConstant.SystemSearchVauleNotEnter);
                }
            }
            else
            {
                Dialog.Warning(MessageConstant.ChildIdNotSelected);
            }
        }

        /// <summary>
        /// Click Button Map: マップ表示
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnMap_Click(object sender, EventArgs e)
        {
            if (dgvListFacility.DataSource != null)
            {
                List<string> listDeviceId = dgvListFacility.Rows
                             .OfType<DataGridViewRow>()
                             .Select(r => r.Cells[0].Value.ToString())
                             .ToList();
                // To do Open the map screen in `` device '' mode
            }
            else
            {
                Dialog.Info(MessageConstant.NoSearchResults);
            }
        }

        /// <summary>
        /// Click Button SystemEditing: 系統編集
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSystemEditing_Click(object sender, EventArgs e)
        {
            if (dgvListFacility.SelectedRows.Count > 0)
            {
                string deviceId = dgvListFacility.SelectedCells[0].ToString();
                // Open the power system details screen in `` system editing '' mode
            }
            else
            {
                Dialog.Warning(MessageConstant.NoDeviceSelected);
            }
        }

        /// <summary>
        /// Click Button Export: エクスポート
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnExport_Click(object sender, EventArgs e)
        {

            if (dgvListFacility.DataSource != null)
            {
                string fileName = "FacilitySystem_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                if (!CommonUtility.ExportToCSV(dgvListFacility, fileName))
                {
                    Dialog.Error(MessageConstant.ExportCSVFailed);
                }
            }
            else
            {
                Dialog.Info(MessageConstant.NoSearchResults);
            }            
        }

        /// <summary>
        /// Click button: 閉じる
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
        /// <param name="division">division</param>
        /// <param name="cbo">combobox</param>
        public void BindingDataCombobox(dynamic result, string division, ComboBox cbo)
        {
            List<MstDivisionViewModel> listDivision = CommonUtility.DynamicToObject<List<MstDivisionViewModel>>(result);
            List<MstDivisionViewModel> listDivisionByDivision = listDivision.Where(x => x.DIV == division).ToList();
            Dictionary<string, string> divisionDictionary = new Dictionary<string, string>();
            divisionDictionary.Add("", "");
            foreach (var item in listDivisionByDivision)
            {
                divisionDictionary.Add(item.DIV_ID, item.DIV_NAME);
            }

            CommonUtility.BindingCombobox(cbo, divisionDictionary);
        }

        /// <summary>
        /// Binding data SystemType
        /// </summary>
        /// <param name="instance">instance</param>
        /// <param name="cbo">ComboBox</param>
        public void BindingDataSystemType(dynamic instance, ComboBox cbo)
        {
            var result = instance.GetSystemType();
            List<SystemTypeModel> listSystemType = CommonUtility.DynamicToObject<List<SystemTypeModel>>(result);

            Dictionary<string, string> systemTypeDictionary = new Dictionary<string, string>();
            systemTypeDictionary.Add("", "");
            // Add default value Gas Type 1110
            systemTypeDictionary.Add(CommonConstant.GasType.Key, CommonConstant.GasType.Value);

            foreach (var item in listSystemType)
            {
                systemTypeDictionary.Add($"{item.PARENT_ID}:{item.CHILD_ID}", item.DIV_NAME);
            }

            CommonUtility.BindingCombobox(cbo, systemTypeDictionary);
        }

        /// <summary>
        /// Check role into screen and show/hide button
        /// </summary>
        /// <param name="listRoles">List roles of user</param>
        /// <returns>Bool</returns>
        public bool CheckRoleInitial(string userId)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilitySystemBLO];

            // Check role display screen
            if (!instance.CheckRoleIntoScreen(userId))
            {
                Dialog.Warning(MessageConstant.CheckRoleScreen);
                return false;
            }
            else
            {
                // Check role show/hide button System Editing
                if (!instance.CheckRoleShowButton(userId))
                {
                    btnSystemEditing.Visible = false;
                    btnExport.Location = btnSystemEditing.Location;
                }

                return true;
            }
        }
    }
}
