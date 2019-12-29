using CRManagmentSystem.Common;
using CRManagmentSystem.Models.FacilityManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRManagmentSystem.View.FacilityManagement
{
    public partial class DetailFacilityManagementForm : Form
    {
        public DetailFacilityManagementForm(string equipmentKbn, string equipmentId, string appkind)
        {
            InitializeComponent();
            AppKind = appkind;
            EquipmentKbn = equipmentKbn;
            EquipmentId = equipmentId;
        }
        private string AppKind { get; }

        private string EquipmentKbn { get; set; }

        private string EquipmentId { get; set; }
        /// <summary>
        /// Load on show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailEquipmentManagementForm_Load(object sender, EventArgs e)
        {
            dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilityManagementBLO];
            var checkEquipmentKbnExist = instance.GetFacilityKbnId(EquipmentKbn , EquipmentId);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
