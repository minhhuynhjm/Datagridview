using CRManagmentSystem.Common;
using CRManagmentSystem.Models.FacilitySystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CRManagmentSystem.View.FacilitySystem
{
    public partial class FacilitySystemDetailForm : Form
    {
        private Dictionary<string, short> MaxPatternTable = new Dictionary<string, short>();
        public FacilitySystemDetailForm(CommonConstant.FacilityDetailMode mode, string DeviceOrChildId, string SystemSearchValue)
        {
            #region Load DLL
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + CommonConstant.DLLFolder;
            if (!Directory.Exists(path))
            {
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.Error(MessageConstant.DirectoryNotFound);
            }
            else
            {
                foreach (string dll in Directory.GetFiles(path, CommonConstant.DLLExtension))
                {
                    AssemblyName assemblyName = AssemblyName.GetAssemblyName(dll);
                    CommonConstant.Types.AddRange(Assembly.Load(assemblyName).GetTypes());
                }

                if (CommonConstant.Types.Any())
                {
                    List<Type> listType = CommonConstant.Types.Where(x => CommonConstant.ListBLOs.Contains(x.FullName)).ToList();
                    foreach (Type item in listType)
                    {
                        CommonConstant.InstanceDictionaries.Add(item.FullName, Activator.CreateInstance(item));
                    }
                }
                else
                {
                    Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                    CommonConstant.Logger.Error(MessageConstant.DllFileNotFound);
                }
            }
            #endregion

            InitializeComponent();

            //dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.FacilitySystemBLO];
            //CheckRoleShowButton(instance, "hcminh", mode);
            CreateTabPage();

        }

        /// <summary>
        /// Button Close: 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int CountPattern { get; set; }
        /// <summary>
        /// Create tab page
        /// </summary>
        /// <param name="instance">Instance</param>
        private void CreateTabPage()
        {
            List<ViewDivFacilityCategory> listViewFacilityCategory = new List<ViewDivFacilityCategory>();
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1110", CATEGORY_NAME = "ガス供給", FAC_TABLE_NAME = "FAC_GAS_SUPPLY" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1120", CATEGORY_NAME = "ガス排気", FAC_TABLE_NAME = "FAC_GAS_EXHAUST" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1130", CATEGORY_NAME = "超純水", FAC_TABLE_NAME = "FAC_PURE_WATER" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1140", CATEGORY_NAME = "給水", FAC_TABLE_NAME = "FAC_WATER_SUPPLY" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1150", CATEGORY_NAME = "一般空気圧力", FAC_TABLE_NAME = "FAC_AIR_PRESSURE" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1160", CATEGORY_NAME = "薬液供給イメージ", FAC_TABLE_NAME = "FAC_CHEMICAL_SUPPLY_IMAGE" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1170", CATEGORY_NAME = "薬液供給", FAC_TABLE_NAME = "FAC_CHEMICAL_SUPPLY" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1180", CATEGORY_NAME = "薬液回収", FAC_TABLE_NAME = "FAC_CHEMICAL_RECOVERY" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1190", CATEGORY_NAME = "薬液排水", FAC_TABLE_NAME = "FAC_CHEMICAL_DRAINAGE" });
            listViewFacilityCategory.Add(new ViewDivFacilityCategory { CATEGORY_ID = "1200", CATEGORY_NAME = "薬液排気", FAC_TABLE_NAME = "FAC_CHEMICAL_EXHAUST" });
            List<MstDivisionHeader> mstDivisionHeader = new List<MstDivisionHeader>();
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1010", DIVISIONNAME = "ガス種類", STRING1 = "" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1020", DIVISIONNAME = "ポート", STRING1 = "CR内設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1030", DIVISIONNAME = "パネル", STRING1 = "CR内設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1040", DIVISIONNAME = "三方弁", STRING1 = "CR内設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1050", DIVISIONNAME = "V/B №", STRING1 = "CR内設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1060", DIVISIONNAME = "V/B №(中継)", STRING1 = "供給経路" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1070", DIVISIONNAME = "C/B №", STRING1 = "供給経路" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1080", DIVISIONNAME = "S/B №", STRING1 = "供給経路" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1090", DIVISIONNAME = "C/C", STRING1 = "供給元設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1100", DIVISIONNAME = "設置エリア", STRING1 = "供給元設備" });
            mstDivisionHeader.Add(new MstDivisionHeader { DIVISIONID = "1110", DIVISIONNAME = "供給元", STRING1 = "" });

            List<FacTableModel> listFac = new List<FacTableModel>();
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 1, FACILITYKBN = "1010", FACILITYID = "He" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 2, FACILITYKBN = "1010", FACILITYID = "He" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 3, FACILITYKBN = "1010", FACILITYID = "He" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 4, FACILITYKBN = "1010", FACILITYID = "Xe" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 5, FACILITYKBN = "1010", FACILITYID = "CO2" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 1, FACILITYKBN = "1020", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 2, FACILITYKBN = "1020", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 3, FACILITYKBN = "1020", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 4, FACILITYKBN = "1020", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 5, FACILITYKBN = "1020", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 1, FACILITYKBN = "1030", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 2, FACILITYKBN = "1030", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 3, FACILITYKBN = "1030", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 4, FACILITYKBN = "1030", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 5, FACILITYKBN = "1030", FACILITYID = null });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 1, FACILITYKBN = "1040", FACILITYID = "三方弁" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 2, FACILITYKBN = "1040", FACILITYID = "三方弁" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 3, FACILITYKBN = "1040", FACILITYID = "三方弁" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 4, FACILITYKBN = "1040", FACILITYID = "三方弁" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 5, FACILITYKBN = "1040", FACILITYID = "三方弁" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 1, FACILITYKBN = "1100", FACILITYID = "3F供給元設備1" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 2, FACILITYKBN = "1100", FACILITYID = "3F供給元設備1" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 3, FACILITYKBN = "1100", FACILITYID = "3F供給元設備1" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 4, FACILITYKBN = "1100", FACILITYID = "3F供給元設備1" });
            listFac.Add(new FacTableModel { APPARATUSID = "OFXDP01", PATTERN = 5, FACILITYKBN = "1100", FACILITYID = "3F供給元設備1" });

            List<MstFacilityCboModel> listCombobox = new List<MstFacilityCboModel>();
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "", FACILITYNAME = "" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "Ar/Xe/Ne" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "He" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "F2/Ar/Ne" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "Xe" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "F2/Kr/Ne" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "Kr/Ne" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "CO2" });
            listCombobox.Add(new MstFacilityCboModel { FACILITYID = "1100", FACILITYNAME = "O2" });

            const string device = "装置";
            const string pattern = "パターン";
            const string deviceId = "OFXDP01";

            txtCondition.Text = "装置ID : " + deviceId;
            foreach (var item in listViewFacilityCategory)
            {
                TabPage tabPage = new TabPage();
                tabPage.Name = $"{item.CATEGORY_ID}:{item.FAC_TABLE_NAME}";
                tabPage.Text = item.CATEGORY_NAME;
                tabPage.UseVisualStyleBackColor = true;
                DataGridView dataGridView = new DataGridView();

                tabPage.Controls.Add(dataGridView);
                tabControlFacilitySystem.TabPages.Add(tabPage);
            }
            var tabId = $"{listViewFacilityCategory.FirstOrDefault().CATEGORY_ID}:{listViewFacilityCategory.FirstOrDefault().FAC_TABLE_NAME}";
            TabPage tag = tabControlFacilitySystem.TabPages[tabId];
            //DataGridView dgv = new DataGridView();
            DataGridView dgv = tag.Controls.OfType<DataGridView>().FirstOrDefault();
            dgv.AllowUserToAddRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            //dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;

            // Select Rows
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ReadOnly Datagridview
            //dgv.ReadOnly = true;

            dgv.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells });
            dgv.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells });
            dgv.Rows.Add(new DataGridViewRow());
            dgv.Rows.Add(new DataGridViewRow());
            dgv.Rows[1].Cells[0].Value = device;
            dgv.Rows[1].Cells[1].Value = pattern;
            int i = 2;
            foreach (var item in mstDivisionHeader)
            {
                dgv.Columns.Add(new DataGridViewColumn { Name = item.DIVISIONID, CellTemplate = new DataGridViewTextBoxCell(), AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells });
                dgv.Rows[0].Cells[i].Value = item.STRING1;
                dgv.Rows[1].Cells[i].Value = item.DIVISIONNAME;
                ++i;
            }
            int j = 2;
            foreach (var item in listFac.GroupBy(x => x.PATTERN))
            {
                dgv.Rows.Add(new DataGridViewRow());
                dgv.Rows[j].Cells[1].Value = item.Key;

                for (int k = 2; k < dgv.Columns.Count; k++)
                {
                    dgv.Rows[j].Cells[k].Value = listFac.FirstOrDefault(x => x.FACILITYKBN == dgv.Columns[k].Name && x.PATTERN == item.Key)?.FACILITYID;
                }

                ++j;
            }
            CountPattern = listFac.Max(x => x.PATTERN);
            dgv.Rows[2].Cells[0].Value = deviceId;
            //dgv.AutoGenerateColumns = false;
            DataGridViewComboBoxCell cboCell = new DataGridViewComboBoxCell();
            cboCell.DataSource = listCombobox.Select(x => x.FACILITYNAME).ToList();
            cboCell.Value = "O2";
            cboCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgv.Rows[2].Cells[2] = cboCell;


            HMergedCell pCell;
            //for (i = 0; i < 3; i++)
            //{
            for (int x = 3; x <= 6; x++)
            {
                dgv.Rows[0].Cells[x] = new HMergedCell();
                pCell = (HMergedCell)dgv.Rows[0].Cells[x];
                pCell.LeftColumn = 3;
                pCell.RightColumn = 6;
            }

            //}

            //for (int z = 3; z < 7; z++)
            //{
            //    dgv.Rows[0].Cells[z].Value = "CR閉じる";
            //}


            i = 2;
            foreach (var item in mstDivisionHeader)
            {
                //dgv.Columns.Add(new DataGridViewColumn { Name = item.DIVISIONID, CellTemplate = new DataGridViewTextBoxCell(), AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells });
                dgv.Rows[0].Cells[i].Value = item.STRING1;
                dgv.Rows[1].Cells[i].Value = item.DIVISIONNAME;
                ++i;
            }

            dgv.CellPainting += Dgv_CellPainting;
            tag.Controls.Add(dgv);
        }

        private void Dgv_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangles();
        }

        private void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            TabPage tagPage = tabControlFacilitySystem.TabPages[tabControlFacilitySystem.SelectedTab.Name];
            DataGridView dgv = tagPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (e.RowIndex == 2)
            {
                // Calculate the bounds of the row
                int rowHeaderWidth = dgv.RowHeadersVisible ?
                                     dgv.RowHeadersWidth : 0;
                Rectangle rowBounds = new Rectangle(
                    rowHeaderWidth,
                    e.RowBounds.Top,
                    dgv.Columns.GetColumnsWidth(
                            DataGridViewElementStates.Visible) -

                            dgv.HorizontalScrollingOffset + 1,
                   e.RowBounds.Height);

                // Paint the border
                ControlPaint.DrawBorder(e.Graphics, rowBounds,
                                 Color.Red, ButtonBorderStyle.Solid);

                // Paint the background color
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                                                     Color.BlanchedAlmond;
            }

        }

        public Random rand = new Random();
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            TabPage tagPage = tabControlFacilitySystem.TabPages[tabControlFacilitySystem.SelectedTab.Name];
            DataGridView dgv = tagPage.Controls.OfType<DataGridView>().FirstOrDefault();
            //e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            if (e.RowIndex > 0)
            {
                if (!string.IsNullOrEmpty(e.Value?.ToString()))
                {
                    //e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Black, 0.1F))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
                else
                {
                    e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Check Role Show Button
        /// </summary>
        /// <param name="userId"></param>
        private void CheckRoleShowButton(dynamic instance, string userId, CommonConstant.FacilityDetailMode mode)
        {
            if (mode == CommonConstant.FacilityDetailMode.SystemEdit)
            {
                if (!instance.CheckRoleShowButton(userId))
                {
                    btnAddPattern.Visible = false;
                    btnDeletePattern.Visible = false;
                    btnUpdate.Visible = false;
                }
            }
            else
            {
                btnAddPattern.Visible = false;
                btnDeletePattern.Visible = false;
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            TabPage tagPage = tabControlFacilitySystem.TabPages[tabControlFacilitySystem.SelectedTab.Name];
            DataGridView dgv = tagPage.Controls.OfType<DataGridView>().FirstOrDefault();
            int lineRowsSelected = dgv.CurrentCell.RowIndex;
            int rowCount = dgv.Rows.Count - 1;
            dgv.Rows.RemoveAt(lineRowsSelected);
            // set value so luong pattern
            CountPattern--;
            // Neu la dong cuoi thi ko phai renew pattern            
            if (lineRowsSelected != rowCount)
            {
                int j = 0;
                for (int i = 2; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells[1].Value = ++j;
                }
            }
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            ++CountPattern;
            TabPage tagPage = tabControlFacilitySystem.TabPages[tabControlFacilitySystem.SelectedTab.Name];
            DataGridView dgv = tagPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {
                dgv.Rows.Add(new DataGridViewRow());
                dgv.Rows[dgv.Rows.Count - 1].Cells[1].Value = CountPattern;
            }

        }

        private void btnSelectLineSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }

        private bool IsTheSameCellValue(int column, int row, DataGridView dgv)
        {
            if (dgv.Columns.Count > column + 1)
            {
                DataGridViewCell cell1 = dgv[column, row];
                DataGridViewCell cell2 = dgv[column + 1, row];
                if (cell1.Value == null || cell2.Value == null)
                {
                    return false;
                }
                return cell1.Value.ToString() == cell2.Value.ToString();
            }
            else
            {
                return false;
            }
        }

    }
}
