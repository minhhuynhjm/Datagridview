using CRManagmentSystem.Common;
using CRManagmentSystem.Models.DeviceManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.DeviceManagement
{
    public partial class UpdateDeviceForm : Form
    {
        public UpdateDeviceForm(string deviceId)
        {
            InitializeComponent();
            txtDeviceId.Text = deviceId;
        }

        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void UpdateDeviceForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
            string deviceId = txtDeviceId.Text;

            // Get device by deviceId from DeviceMaintenanceBLO
            var resultDeviceById = instance.GetDeviceByDeviceId(deviceId);
            MstApparatusModel deviceById = CommonUtility.DynamicToObject<MstApparatusModel>(resultDeviceById);
            txtDeviceName.Text = deviceById.APPARATUSNAME;
            var resultListDivision = instance.GetDivision110to160();
            //create combobox period
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPeriod, cboPeriod);
            cboPeriod.SelectedIndex = cboPeriod.FindStringExact(deviceById.PERIOD.ToString());
            //create combobox Floor1
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboFloor1);
            cboFloor1.SelectedIndex = cboFloor1.FindStringExact(deviceById.FLOOR1.ToString());
            //create combobox Floor2
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionFloor, cboFloor2);
            cboFloor2.SelectedIndex = cboFloor2.FindStringExact(deviceById.FLOOR2.ToString());
            //create combobox Area
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionArea, cboArea);
            cboArea.SelectedIndex = cboArea.FindStringExact(deviceById.AREA);
            //create combobox Pillar1
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar1);
            cboPillar1.SelectedIndex = cboPillar1.FindStringExact(deviceById.PILLAR1);
            //create combobox Pillar2
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionPillar, cboPillar2);
            cboPillar2.SelectedIndex = cboPillar2.FindStringExact(deviceById.PILLAR2);
            //create combobox Street1
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet1);
            cboStreet1.SelectedIndex = cboStreet1.FindStringExact(deviceById.STREET1.ToString());
            //create combobox Street2
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionStreet, cboStreet2);
            cboStreet2.SelectedIndex = cboStreet2.FindStringExact(deviceById.STREET2.ToString());
            //create combobox Process
            BindingDataCombobox(resultListDivision, CommonConstant.Division.DivisionProcess, cboProcess);
            cboProcess.SelectedIndex = cboProcess.FindStringExact(deviceById.PROCESS);

            // Focus texbox deviceName
            this.ActiveControl = txtDeviceName;
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
        /// Button close form 閉じる
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button update 閉じる
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
                MstApparatusModel mstApparatusModel = new MstApparatusModel();
                mstApparatusModel.APPARATUSID = txtDeviceId.Text;
                mstApparatusModel.APPARATUSNAME = txtDeviceName.Text;
                mstApparatusModel.AREA = cboArea.Text;
                mstApparatusModel.PILLAR1 = cboPillar1.Text;
                mstApparatusModel.PILLAR2 = cboPillar2.Text;
                mstApparatusModel.PROCESS = cboProcess.Text;
                mstApparatusModel.UPDUSER = CommonConstant.UserInfo.UserId;
                //Check value update
                if (CheckValueAdd(mstApparatusModel))
                {
                    if (!string.IsNullOrEmpty(cboPeriod.Text))
                    {
                        mstApparatusModel.PERIOD = short.Parse(cboPeriod.Text);
                    }
                    if (!string.IsNullOrEmpty(cboFloor1.Text))
                    {
                        mstApparatusModel.FLOOR1 = short.Parse(cboFloor1.Text);
                    }
                    if (!string.IsNullOrEmpty(cboFloor2.Text))
                    {
                        mstApparatusModel.FLOOR2 = short.Parse(cboFloor2.Text);
                    }
                    if (!string.IsNullOrEmpty(cboStreet1.Text))
                    {
                        mstApparatusModel.STREET1 = short.Parse(cboStreet1.Text);
                    }
                    if (!string.IsNullOrEmpty(cboStreet2.Text))
                    {
                        mstApparatusModel.STREET2 = short.Parse(cboStreet2.Text);
                    }
                    instance.UpdateDevice(mstApparatusModel);
                }
            }
            catch (Exception ex)
            {
                // Todo log
                CommonConstant.Logger.Error($"RollBack update device in 装置画面設計書 {ex.Message} AppKind");
                Dialog.Error(MessageConstant.ErrorLogUpdateUser);
            }

        }

        //Check deviceId
        public bool CheckDeviceId(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
            {
                Dialog.Warning(MessageConstant.DeviceIdNotEntered);
                this.ActiveControl = txtDeviceId;
                return false;
            }
            if (deviceId.Length > 10)
            {
                Dialog.Warning(MessageConstant.DeviceIdTooLong);
                this.ActiveControl = txtDeviceId;
                return false;
            }
            foreach (char c in deviceId)
            {
                bool checkCharater = CommonUtility.IsWideEastAsianWidth_SJIS(c);
                if (checkCharater)
                {
                    Dialog.Warning(MessageConstant.DeviceIdInvalid);
                    this.ActiveControl = txtDeviceId;
                    return false;
                }
            }
            return true;
        }

        //Check device name
        public bool CheckDeviceName(string deviceName)
        {
            if (string.IsNullOrEmpty(deviceName))
            {
                Dialog.Warning(MessageConstant.NoDeviceNameEntered);
                this.ActiveControl = txtDeviceName;
                return false;
            }
            if (deviceName.Length > 12)
            {
                Dialog.Warning(MessageConstant.DeviceNameTooLong);
                this.ActiveControl = txtDeviceName;
                return false;
            }
            return true;
        }

        //Check period
        public bool CheckPeriod(string period)
        {
            if (string.IsNullOrEmpty(period))
            {
                Dialog.Warning(MessageConstant.PeriodNotEntered);
                this.ActiveControl = cboPeriod;
                return false;
            }
            int checkNumber;
            if (!int.TryParse(period, out checkNumber))
            {
                Dialog.Warning(MessageConstant.PeriodInvalid);
                this.ActiveControl = cboPeriod;
                return false;
            }
            return true;
        }

        //Check floor 1
        public bool CheckFloor1(string floor1)
        {
            if (string.IsNullOrEmpty(floor1))
            {
                Dialog.Warning(MessageConstant.NoFloor1Entered);
                this.ActiveControl = cboFloor1;
                return false;
            }
            if (floor1.Length > 1)
            {
                Dialog.Warning(MessageConstant.OneDigitEnteredFloor1);
                this.ActiveControl = cboFloor1;
                return false;
            }
            int checkNumber;
            if (!int.TryParse(floor1, out checkNumber))
            {
                Dialog.Warning(MessageConstant.Floor1Invalid);
                this.ActiveControl = cboFloor1;
                return false;
            }
            return true;
        }


        //Check floor 2
        public bool CheckFloor2(string floor2)
        {
            if (!string.IsNullOrEmpty(floor2))
            {
                if (floor2.Length > 1)
                {
                    Dialog.Warning(MessageConstant.OneDigitEnteredFloor2);
                    this.ActiveControl = cboFloor2;
                    return false;
                }
                int checkNumber;
                if (!int.TryParse(floor2, out checkNumber))
                {
                    Dialog.Warning(MessageConstant.Floor2Invalid);
                    this.ActiveControl = cboFloor2;
                    return false;
                }
            }

            return true;
        }

        //Check area
        public bool CheckArea(string area)
        {
            if (string.IsNullOrEmpty(area))
            {
                Dialog.Warning(MessageConstant.NoAreaEntered);
                this.ActiveControl = cboArea;
                return false;
            }
            if (area.Length > 1)
            {
                Dialog.Warning(MessageConstant.OneDigitEnteredArea);
                this.ActiveControl = cboArea;
                return false;
            }

            return true;
        }

        //Check pillar 1
        public bool CheckPillar1(string pillar1)
        {
            if (!string.IsNullOrEmpty(pillar1))
            {
                bool checkCharater = CommonUtility.IsWideEastAsianWidth_SJIS(pillar1[0]);
                if (pillar1.Length > 1 || checkCharater)
                {
                    Dialog.Warning(MessageConstant.OneDigitEnteredPillar1);
                    this.ActiveControl = cboPillar1;
                    return false;
                }
            }

            return true;
        }

        //Check pillar 2
        public bool CheckPillar2(string pillar2)
        {
            if (!string.IsNullOrEmpty(pillar2))
            {
                bool checkCharater = CommonUtility.IsWideEastAsianWidth_SJIS(pillar2[0]);
                if (pillar2.Length > 1 && checkCharater)
                {
                    Dialog.Warning(MessageConstant.OneDigitEnteredPillar2);
                    this.ActiveControl = cboPillar2;
                    return false;
                }
            }

            return true;
        }

        //Check street 1
        public bool CheckStreet1(string street1)
        {
            if (!string.IsNullOrEmpty(street1))
            {
                if (street1.Length > 1)
                {
                    Dialog.Warning(MessageConstant.OneDigitEnteredStreet1);
                    this.ActiveControl = cboStreet1;
                    return false;
                }
                int checkNumber;
                if (!int.TryParse(street1, out checkNumber))
                {
                    Dialog.Warning(MessageConstant.Pillar2Invalid);
                    this.ActiveControl = cboStreet1;
                    return false;
                }
            }

            return true;
        }

        //Check street 2
        public bool CheckStreet2(string street2)
        {
            if (!string.IsNullOrEmpty(street2))
            {
                if (street2.Length > 1)
                {
                    Dialog.Warning(MessageConstant.OneDigitEnteredStreet2);
                    this.ActiveControl = cboStreet2;
                    return false;
                }
                int checkNumber;
                if (!int.TryParse(street2, out checkNumber))
                {
                    Dialog.Warning(MessageConstant.Street2Invalid);
                    this.ActiveControl = cboStreet2;
                    return false;
                }
            }

            return true;
        }

        //Check process
        public bool CheckProcess(string process)
        {
            if (string.IsNullOrEmpty(process))
            {
                Dialog.Warning(MessageConstant.NoProcessSelected);
                this.ActiveControl = cboProcess;
                return false;
            }
            return true;
        }

        //Check exist device
        public bool CheckExistDevice(string deviceId)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
            var checkExistDevice = instance.GetDeviceByDeviceId(deviceId);
            if (checkExistDevice == null)
            {
                Dialog.Warning(MessageConstant.DeviceNotExist);
                this.ActiveControl = txtDeviceId;
                return false;
            }
            return true;
        }

        //Check Value add
        public bool CheckValueAdd(MstApparatusModel mstApparatusModel)
        {
            return CheckDeviceId(mstApparatusModel.APPARATUSID)
                 && CheckDeviceName(mstApparatusModel.APPARATUSNAME)
                 && CheckPeriod(cboPeriod.Text)
                 && CheckFloor1(cboFloor1.Text)
                 && CheckFloor2(cboFloor2.Text)
                 && CheckArea(mstApparatusModel.AREA)
                 && CheckPillar1(mstApparatusModel.PILLAR1)
                 && CheckPillar2(mstApparatusModel.PILLAR2)
                 && CheckStreet1(cboStreet1.Text)
                 && CheckStreet2(cboStreet2.Text)
                 && CheckProcess(mstApparatusModel.PROCESS)
                 && CheckExistDevice(mstApparatusModel.APPARATUSID);
        }
    }
}
