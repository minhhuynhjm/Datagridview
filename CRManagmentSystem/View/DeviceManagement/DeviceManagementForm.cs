using CRManagmentSystem.Common;
using CRManagmentSystem.Models.DeviceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.DeviceManagement
{
    public partial class DeviceManagementForm : Form
    {
        public DeviceManagementForm(string appKind)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void DeviceMaintenanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                if (!CheckRoleByUserId(CommonConstant.UserInfo.UserId))
                {
                    Close();
                }
                else
                {
                    var resultListDivision = instance.GetDivision110to160();
                    //create combobox period
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPeriod, cboPeriod);
                    //create combobox Floor1
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboFloor1);
                    //create combobox Floor2
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboFloor2);
                    //create combobox Area
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionArea, cboArea);
                    //create combobox Pillar1
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar1);
                    //create combobox Pillar2
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar2);
                    //create combobox Street1
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet1);
                    //create combobox Street2
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet2);
                    //create combobox Process
                    BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionProcess, cboProcess);

                    // Focus texbox deviceId
                    this.ActiveControl = txtDeviceId;
                }
            }
            catch (Exception ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                Close();
            }
        }

        /// <summary>
        /// Check role button by userId
        /// </summary>
        /// <param name="loginUserId">loginUserId</param>
        public bool CheckRoleByUserId(string loginUserId)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
            // Check role user into screen by userId from DeviceMaintenanceBLO
            bool checkRoleScreen = instance.CheckRoleScreenListByUserId(loginUserId);

            // Check role button screen by userId from DeviceMaintenanceBLO
            Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(loginUserId);
            if (!checkRoleScreen)
            {
                Dialog.Warning(MessageConstant.CheckRoleScreen);
                return false;
            }
            if (!checkRoleBtn["btnAdd"])
            {
                btnExport.Location = btnDelete.Location;
                btnDelete.Location = btnUpdate.Location;
                btnUpdate.Location = btnAdd.Location;
                btnAdd.Visible = false;
            }
            if (!checkRoleBtn["btnUpdate"])
            {
                if (!btnAdd.Visible)
                {
                    btnExport.Location = btnDelete.Location;
                    btnDelete.Location = btnAdd.Location;
                }
                else
                {
                    btnExport.Location = btnDelete.Location;
                    btnDelete.Location = btnUpdate.Location;
                }
                btnUpdate.Visible = false;
            }
            if (!checkRoleBtn["btnDelete"])
            {
                btnExport.Location = btnDelete.Location;
                btnDelete.Visible = false;
            }
            return true;
        }


        /// <summary>
        /// Binding data combobox
        /// </summary>
        /// <param name="division">division</param>
        /// <param name="cbo">combobox</param>
        public void BindingDataCombobox(dynamic resultListDivision, string division, ComboBox cbo)
        {

            Dictionary<string, string> divisionDictionary = new Dictionary<string, string>();
            divisionDictionary.Add("", "");
            if (resultListDivision != null)
            {
                List<MstDivisionModel> listDivision = CommonUtility.DynamicToObject<List<MstDivisionModel>>(resultListDivision);
                List<MstDivisionModel> listDivisionByDivision = listDivision.Where(x => x.DIVISION == division).ToList();
                foreach (var item in listDivisionByDivision)
                {
                    divisionDictionary.Add(item.DIVISIONID, item.DIVISIONNAME);
                }
            }
            cbo.DataSource = new BindingSource(divisionDictionary, null);
            cbo.DisplayMember = "Value";
            cbo.ValueMember = "Key";
        }


        /// <summary>
        /// Click button 検索 (search)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];

                //Get data from form
                string deviceId = txtDeviceId.Text;
                string deviceName = txtDeviceName.Text;
                string period = cboPeriod.Text;
                string floor1 = cboFloor1.Text;
                string floor2 = cboFloor2.Text;
                string area = cboArea.Text;
                string pillar1 = cboPillar1.Text;
                string pillar2 = cboPillar2.Text;
                string street1 = cboStreet1.Text;
                string street2 = cboStreet2.Text;
                string processId = cboProcess.Text;

                //Dictionary parameter
                Dictionary<string, object> paramSearchDevice = new Dictionary<string, object>
                {
                    {"deviceId", deviceId},
                    {"deviceName", deviceName},
                    {"period", period},
                    {"floor1", floor1},
                    {"floor2", floor2},
                    {"area", area},
                    {"pillar1", pillar1},
                    {"pillar2", pillar2},
                    {"street1", street1},
                    {"street2", street2},
                    {"processId", processId}
                };

                // Search Device from DeviceMaintenanceBLO
                var result = instance.SearchDevice(paramSearchDevice);
                dgvDevice.DataSource = null;
                if (result == null)
                {
                    Dialog.Info(MessageConstant.NoSearchResults);
                }
                else
                {
                    //Check record more than 1000
                    int countDevice = instance.CountDevice(paramSearchDevice);
                    if (countDevice > 1000)
                    {
                        Dialog.Warning(MessageConstant.MoreThan1000);
                    }
                    else
                    {
                        List<MstApparatusViewModel> listDevice = CommonUtility.DynamicToObject<List<MstApparatusViewModel>>(result);
                        dgvDevice.DataSource = listDevice;
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
        /// Click button 追加 (add)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(CommonConstant.UserInfo.UserId);
                if (!checkRoleBtn["btnAdd"])
                {
                    Dialog.Warning(MessageConstant.CheckRoleScreen);
                }
                else
                {
                    AddDeviceForm addDeviceForm = new AddDeviceForm();
                    addDeviceForm.ShowDialog();
                    if (dgvDevice.DataSource != null)
                    {
                        btnSearch_Click(sender, e);
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
        /// Click button 閉じる (close)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Click button エクスポート (export)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDevice.DataSource == null)
                {
                    Dialog.Info(MessageConstant.NoInformationToOutput);
                }
                else
                {
                    string fileName = "APPARATUS_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    if (!CommonUtility.ExportToCSV(dgvDevice, fileName, MessageConstant.ExportCSVDeviceManagement))
                    {
                        Dialog.Error(MessageConstant.ExportCSVFailed);
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
        /// Click button 削除 (delete)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDevice.SelectedRows.Count > 0)
                {
                    bool confirm = Dialog.Confirm(MessageConstant.ConfirmDeleteDevice);
                    if (confirm)
                    {
                        string deviceId = dgvDevice.SelectedCells[0].Value.ToString();
                        dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                        //Check exist device
                        var checkExistDevice = instance.GetDeviceByDeviceId(deviceId);
                        if (checkExistDevice == null)
                        {
                            Dialog.Warning(MessageConstant.DeviceNotExist);
                        }
                        else
                        {
                            var deviceDelete = instance.DeleteDevice(deviceId);
                            if (deviceDelete)
                            {
                                Dialog.Info(MessageConstant.DeviceHasBeenDelete);
                                if (dgvDevice.DataSource != null)
                                {
                                    btnSearch_Click(sender, e);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Dialog.Warning(MessageConstant.NoDeviceSelected);
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
        /// Click button 詳細 (detail)
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDevice.SelectedRows.Count > 0)
                {
                    string deviceId = dgvDevice.SelectedCells[0].Value.ToString();
                    dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                    //Check exis device
                    var checkExistDevice = instance.GetDeviceByDeviceId(deviceId);
                    if (checkExistDevice == null)
                    {
                        Dialog.Warning(MessageConstant.DeviceNotExist);
                    }
                    else
                    {
                        DetailDeviceForm detailDeviceForm = new DetailDeviceForm(deviceId);
                        detailDeviceForm.ShowDialog();
                    }
                }
                else
                {
                    Dialog.Warning(MessageConstant.NoDeviceSelected);
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
        /// Click button 更新 (update)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                Dictionary<string, bool> checkRoleBtn = instance.CheckRoleBtnScreenListByUserId(CommonConstant.UserInfo.UserId);
                if (!checkRoleBtn["btnUpdate"])
                {
                    Dialog.Warning(MessageConstant.CheckRoleScreen);
                }
                else
                {
                    if (dgvDevice.SelectedRows.Count > 0)
                    {
                        string deviceId = dgvDevice.SelectedCells[0].Value.ToString();
                        var checkExistDevice = instance.GetDeviceByDeviceId(deviceId);
                        if (checkExistDevice == null)
                        {
                            Dialog.Warning(MessageConstant.DeviceNotExist);
                        }
                        else
                        {
                            UpdateDeviceForm updateDeviceForm = new UpdateDeviceForm(deviceId);
                            updateDeviceForm.ShowDialog();
                            btnSearch_Click(sender, e);
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

    }
}
