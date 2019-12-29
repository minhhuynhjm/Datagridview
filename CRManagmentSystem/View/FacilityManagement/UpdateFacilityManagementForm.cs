using CRManagmentSystem.Common;
using CRManagmentSystem.Models.FacilityManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.FacilityManagement
{
    public partial class UpdateFacilityManagementForm : Form
    {
        public UpdateFacilityManagementForm(string equipmentKbn, string equipmentId, string appKind)
        {
            InitializeComponent();
            AppKind = appKind;
            EquipmentKbn = equipmentKbn;
            EquipmentId = equipmentId;
        }

        private string AppKind { get; set; }
        private string EquipmentKbn { get; set; }
        private string EquipmentId { get; set; }
        private void UpdateEquipmentManagementForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            // Check role access to screen
            bool checkRoleAccess = instance.CheckUserRoleAccess(CommonConstant.UserInfo.UserId);

            if (!checkRoleAccess)
            {
                Dialog.Warning(MessageConstant.CheckRoleScreen);
                this.Close();
            }

            var checkEquipmentKbnExist = instance.GetFacilityKbnId(EquipmentKbn, EquipmentId);

            // Get Equipment by FacilityKbn from FacilityMaintenanceBLO
            MstFacilityModel facilityKbn = CommonUtility.DynamicToObject<MstFacilityModel>(checkEquipmentKbnExist);

            // Get FacilityKbn Name from child_iD
            BindingDataComboboxDivision(EquipmentKbn, cboEquipmentList);
            cboEquipmentList.SelectedValue = EquipmentKbn;

            // Get FacilityId
            MstFacilityModel facilityId = CommonUtility.DynamicToObject<MstFacilityModel>(checkEquipmentKbnExist);
            txtEquipmentID.Text = facilityId.FACILITYID;

            // Get FacilityName
            MstFacilityModel facilityName = CommonUtility.DynamicToObject<MstFacilityModel>(checkEquipmentKbnExist);
            txtEquipmentName.Text = facilityName.FACILITYNAME;

            // create combobox period
            BindingDataCombobox(CommonConstant.Division.DivisionPeriod, cboPeriod);
            cboPeriod.SelectedIndex = cboPeriod.FindStringExact(facilityKbn.PERIOD.ToString());

            //create combobox Floor1
            BindingDataCombobox(CommonConstant.Division.DivisionFloor, cboFloor1);
            cboFloor1.SelectedIndex = cboFloor1.FindStringExact(facilityKbn.FLOOR1.ToString());

            //create combobox Floor2
            BindingDataCombobox(CommonConstant.Division.DivisionFloor, cboFloor2);
            cboFloor2.SelectedIndex = cboFloor2.FindStringExact(facilityKbn.FLOOR2.ToString());

            //create combobox Area
            BindingDataCombobox(CommonConstant.Division.DivisionArea, cboArea);
            cboArea.SelectedIndex = cboArea.FindStringExact(facilityKbn.AREA);

            //create combobox Pillar1
            BindingDataCombobox(CommonConstant.Division.DivisionPillar, cboPillar1);
            cboPillar1.SelectedIndex = cboPillar1.FindStringExact(facilityKbn.PILLAR1);

            //create combobox Pillar2
            BindingDataCombobox(CommonConstant.Division.DivisionPillar, cboPillar2);
            cboPillar2.SelectedIndex = cboPillar2.FindStringExact(facilityKbn.PILLAR2);

            //create combobox Street1
            BindingDataCombobox(CommonConstant.Division.DivisionStreet, cboStreet1);
            cboStreet1.SelectedIndex = cboStreet1.FindStringExact(facilityKbn.STREET1.ToString());

            //create combobox Street2
            BindingDataCombobox(CommonConstant.Division.DivisionStreet, cboStreet2);
            cboStreet2.SelectedIndex = cboStreet2.FindStringExact(facilityKbn.STREET2.ToString());
        }

        // Click Button 閉じる
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click Button 更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            // Get List FacilityKbn And FacilityId to check duplicate
            string facilityKbn = cboEquipmentList.SelectedValue.ToString().Split(',').Last();
            string facilityId = txtEquipmentID.Text;
            List<MstFacilityModel> getByFacilityKbnId = CommonUtility.DynamicToObject<List<MstFacilityModel>>(instance.GetListByFacilityIdKbn(facilityKbn, facilityId));


            // Add data to add
            MstFacilityModel mstFacilityModel = new MstFacilityModel();
            mstFacilityModel.FACILITYKBN = cboEquipmentList.SelectedValue.ToString().Split(',').Last();
            mstFacilityModel.FACILITYID = txtEquipmentID.Text;
            mstFacilityModel.FACILITYNAME = txtEquipmentName.Text;
            mstFacilityModel.PARENTID = cboEquipmentList.SelectedValue.ToString().Split(',').First();
            mstFacilityModel.AREA = cboArea.Text;
            mstFacilityModel.PILLAR1 = cboPillar1.Text;
            mstFacilityModel.PILLAR2 = cboPillar2.Text;

            // Check null in combobox
            if (!string.IsNullOrEmpty(cboPeriod.Text))
            {
                mstFacilityModel.PERIOD = Convert.ToInt16(cboPeriod.Text);
            }
            if (!string.IsNullOrEmpty(cboFloor1.Text))
            {
                mstFacilityModel.FLOOR1 = Convert.ToInt16(cboFloor1.Text);
            }
            if (!string.IsNullOrEmpty(cboFloor2.Text))
            {
                mstFacilityModel.FLOOR2 = Convert.ToInt16(cboFloor2.Text);
            }
            if (!string.IsNullOrEmpty(cboStreet1.Text))
            {
                mstFacilityModel.STREET1 = Convert.ToInt16(cboStreet1.Text);
            }
            if (!string.IsNullOrEmpty(cboStreet2.Text))
            {
                mstFacilityModel.STREET2 = Convert.ToInt16(cboStreet2.Text);
            }

            // Check Duplicate FacilityId
            if (getByFacilityKbnId == null)
            {
                Dialog.Warning(MessageConstant.EquipmentNotExist);
            }
            else
            {
                if (CheckValueAdd(mstFacilityModel))
                {
                    bool addFacility = instance.Update(mstFacilityModel);
                    Dialog.Info(MessageConstant.SuccessMessage);
                    txtEquipmentID.Refresh();
                }
            }
        }

        //Check equipment
        public bool CheckEquipment(string equipment)
        {
            if (string.IsNullOrEmpty(equipment))
            {
                Dialog.Warning(MessageConstant.EquipmentNotSelected);
                this.ActiveControl = cboEquipmentList;
                return false;
            }
            return true;
        }

        //Check equipmentId
        public bool CheckEquimentId(string equipmentId)
        {
            if (string.IsNullOrEmpty(equipmentId))
            {
                Dialog.Warning(MessageConstant.IdNotEntered);
                this.ActiveControl = txtEquipmentID;
                return false;
            }
            if (equipmentId.Length > 10)
            {
                Dialog.Warning(MessageConstant.IdTooLong);
                this.ActiveControl = txtEquipmentID;
                return false;
            }
            foreach (char c in equipmentId)
            {
                bool checkCharater = CommonUtility.IsWideEastAsianWidth_SJIS(c);
                if (checkCharater)
                {
                    Dialog.Warning(MessageConstant.IdInvalid);
                    this.ActiveControl = txtEquipmentID;
                    return false;
                }
            }
            return true;
        }

        //Check equipmentName
        public bool CheckEquimentName(string equipmentName)
        {
            if (string.IsNullOrEmpty(equipmentName))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = txtEquipmentName;
                return false;
            }
            if (equipmentName.Length > 12)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = txtEquipmentName;
                return false;
            }
            return true;
        }

        //Check period
        public bool CheckPeriod(string period)
        {
            if (string.IsNullOrEmpty(period))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboPeriod;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboPeriod;
                return false;
            }
            return true;
        }

        //Check floor1
        public bool CheckFloor1(string floor1)
        {
            if (string.IsNullOrEmpty(floor1))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboFloor1;
                return false;
            }
            if (floor1.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboFloor1;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboFloor1;
                return false;
            }
            return true;
        }

        //Check floor2
        public bool CheckFloor2(string floor2)
        {
            if (floor2.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboFloor2;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.IdInvalid);
                this.ActiveControl = cboFloor2;
                return false;
            }
            return true;
        }

        //Check area
        public bool CheckArea(string area)
        {
            if (string.IsNullOrEmpty(area))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboArea;
                return false;
            }
            if (area.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboArea;
                return false;
            }
            return true;
        }

        //Check pillar 1
        public bool CheckPillar1(string pillar1)
        {
            if (string.IsNullOrEmpty(pillar1))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboPillar1;
                return false;
            }
            if (pillar1.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboPillar1;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboPillar1;
                return false;
            }
            return true;
        }

        //Check pillar 2
        public bool CheckPillar2(string pillar2)
        {
            if (pillar2.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboPillar2;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboPillar2;
                return false;
            }
            return true;
        }

        //Check street1
        public bool CheckStreet1(string street1)
        {
            if (string.IsNullOrEmpty(street1))
            {
                Dialog.Warning(MessageConstant.EquipmentNameNotEntered);
                this.ActiveControl = cboStreet1;
                return false;
            }
            if (street1.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboStreet1;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.IdInvalid);
                this.ActiveControl = cboStreet1;
                return false;
            }
            return true;
        }

        //Check street2
        public bool CheckStreet2(string street2)
        {
            if (street2.Length > 2)
            {
                Dialog.Warning(MessageConstant.EquipmentNameToLong);
                this.ActiveControl = cboStreet2;
                return false;
            }
            int distance;
            if (!int.TryParse(cboPeriod.Text, out distance))
            {
                Dialog.Warning(MessageConstant.IdInvalid);
                this.ActiveControl = cboStreet2;
                return false;
            }
            return true;
        }
        public bool CheckValueAdd(MstFacilityModel mstFacilityModel)
        {
            return CheckEquipment(mstFacilityModel.FACILITYKBN) && CheckEquimentId(mstFacilityModel.FACILITYID) && CheckEquimentName(mstFacilityModel.FACILITYNAME) && CheckPeriod(mstFacilityModel.PERIOD.ToString()) && CheckFloor1(mstFacilityModel.FLOOR1.ToString()) && CheckFloor2(mstFacilityModel.FLOOR2.ToString()) && CheckArea(mstFacilityModel.AREA) && CheckPillar1(mstFacilityModel.PILLAR1) && CheckPillar2(mstFacilityModel.PILLAR2) && CheckStreet1(mstFacilityModel.STREET1.ToString()) && CheckStreet2(mstFacilityModel.STREET2.ToString());


        }

        /// <summary>
        /// Binding data combobox
        /// </summary>
        /// <param name="division">division</param>
        /// <param name="cbo">combobox</param>
        public void BindingDataCombobox(string division, ComboBox cbo)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];
            var resultListDivision = instance.GetList120To160();
            List<MstDivisionModel> listDivision = CommonUtility.DynamicToObject<List<MstDivisionModel>>(resultListDivision);
            List<MstDivisionModel> listDivisionByDivision = listDivision.Where(x => x.DIVISION == division).ToList();
            Dictionary<string, string> divisionDictionary = new Dictionary<string, string>();
            divisionDictionary.Add("", "");
            foreach (var item in listDivisionByDivision)
            {
                divisionDictionary.Add(item.DIVISIONID, item.DIVISIONNAME);
            }

            cbo.DataSource = new BindingSource(divisionDictionary, null);
            cbo.DisplayMember = "Value";
            cbo.ValueMember = "Key";
        }

        public void BindingDataComboboxDivision(string division, ComboBox cbo)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];

            // Get list division to combobox
            List<MstDivisionModel> listDivision = CommonUtility.DynamicToObject<List<MstDivisionModel>>(instance.ListDivision());
            Dictionary<string, string> comboboxDictionary = new Dictionary<string, string>();
            comboboxDictionary.Add("", "");
            foreach (var item in listDivision)
            {
                // Hide parent_id and child_id but just use child_id
                comboboxDictionary.Add(item.CHILD_ID, item.DIV_NAME);
            }
            cboEquipmentList.DataSource = new BindingSource(comboboxDictionary, null);
            cboEquipmentList.DisplayMember = "Value";
            cboEquipmentList.ValueMember = "Key";
        }
    }
}
