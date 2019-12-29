using CRManagmentSystem.Common;
using CRManagmentSystem.Models.DeviceManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.DeviceManagement
{
    public partial class DetailDeviceForm : Form
    {
        public DetailDeviceForm(string deviceId)
        {
            InitializeComponent();
            txtDeviceId.Text = deviceId;
        }

        /// <summary>
        /// Load when show form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void DetailDeviceForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.DeviceManagementBLO];
            string deviceId = txtDeviceId.Text;

            // Get device by deviceId from DeviceMaintenanceBLO
            var resultDeviceById = instance.GetDeviceByDeviceId(deviceId);
            MstApparatusModel deviceById = CommonUtility.DynamicToObject<MstApparatusModel>(resultDeviceById);
            txtDeviceName.Text = deviceById.APPARATUSNAME;
            var resultListDivision = instance.GetDivision110to160();
            //create combobox period
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionPeriod, cboPeriod);
            cboPeriod.SelectedIndex = cboPeriod.FindStringExact(deviceById.PERIOD.ToString());
            //create combobox Floor1
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionFloor, cboFloor1);
            cboFloor1.SelectedIndex = cboFloor1.FindStringExact(deviceById.FLOOR1.ToString());
            //create combobox Floor2
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionFloor, cboFloor2);
            cboFloor2.SelectedIndex = cboFloor2.FindStringExact(deviceById.FLOOR2.ToString());
            //create combobox Area
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionArea, cboArea);
            cboArea.SelectedIndex = cboArea.FindStringExact(deviceById.AREA);
            //create combobox Pillar1
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionPillar, cboPillar1);
            cboPillar1.SelectedIndex = cboPillar1.FindStringExact(deviceById.PILLAR1);
            //create combobox Pillar2
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionPillar, cboPillar2);
            cboPillar2.SelectedIndex = cboPillar2.FindStringExact(deviceById.PILLAR2);
            //create combobox Street1
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionStreet, cboStreet1);
            cboStreet1.SelectedIndex = cboStreet1.FindStringExact(deviceById.STREET1.ToString());
            //create combobox Street2
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionStreet, cboStreet2);
            cboStreet2.SelectedIndex = cboStreet2.FindStringExact(deviceById.STREET2.ToString());
            //create combobox Process
            BindingDataCombobox(resultListDivision,CommonConstant.Division.DivisionProcess, cboProcess);
            cboProcess.SelectedIndex = cboProcess.FindStringExact(deviceById.PROCESS);
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
    }
}
