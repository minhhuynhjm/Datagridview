using CRManagmentSystem.Common;
using CRManagmentSystem.View.DeviceManagement;
using CRManagmentSystem.View.FacilityManagement;
using CRManagmentSystem.View.FacilitySystem;
using CRManagmentSystem.View.RoleManagement;
using CRManagmentSystem.View.UserManagement;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CRManagmentSystem.Menu
{
    public partial class MenuForm : Form
    {
        /// <summary>
        /// Contructor Menuform
        /// </summary>
        /// <param name="listRoles">Roles user login</param>
        public MenuForm(List<string> listRoles)
        {
            List<string> role = new List<string>(new string[] { "SYSTEM" });
            ListRoles = role;
            InitializeComponent();

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
                    Dictionary<string, dynamic> testDic = new Dictionary<string, dynamic>();
                    //List<Type> listType = CommonConstant.Types.Where(x => CommonConstant.ListBLOs.Contains(x.FullName)).ToList();
                    foreach (Type item in CommonConstant.Types.Where(x=>!x.Namespace.EndsWith(".View")))
                    {
                        try
                        {
                            if (!item.IsSealed)
                            {
                                testDic.Add(item.FullName, Activator.CreateInstance(item));
                            }
                            else
                            {
                                testDic.Add(item.FullName, item);
                            }
                        }
                        catch
                        {
                        }
                    }



                    Type type = CommonConstant.Types.Single(t => t.FullName.Equals("CRCommon.Common.CommonConstant"));
                    var propertyInfo = type.GetField("Types");
                    
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(type, CommonConstant.Types);
                    }

                    var propertyInstance = type.GetField("InstanceDictionaries");
                    if(propertyInstance != null)
                    {
                        propertyInstance.SetValue(type, testDic);
                    }

                    //.Add(item.FullName, Activator.CreateInstance(item));

                }
                else
                {
                    Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                    CommonConstant.Logger.Error(MessageConstant.DllFileNotFound);
                }
            }
        }

        /// <summary>
        /// List roles of user
        /// </summary>
        private List<string> ListRoles { get; set; }

        /// <summary>
        /// Loading all of DLL files from DLL folder.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void MenuForm_Load(object sender, EventArgs e)
        {
            //Dictionary<string, dynamic> testDic = new Dictionary<string, dynamic>();
            //testDic.Add("Hello", "Hello World");

            Type type = CommonConstant.Types.Single(t => t.FullName.Equals("CRCommon.Common.CommonConstant"));
            var propertyInfo = type.GetField("InstanceDictionaries");
            var result = propertyInfo.GetValue(type) as Dictionary<string, dynamic>;
            //propertyInfo.SetValue(type, testDic);
            //var a = type.GetField("Logger").GetValue(type) as ILog;
            //a.Info("Hello worlds");
            //var result = propertyInfo.GetValue(type) as Dictionary<string, dynamic>;

            // Hide all screen
            this.panelDeviceManagement.Hide();
            this.panelFacilityManagement.Hide();
            this.panelPostManagement.Hide();
            this.panelRoleManagement.Hide();
            this.panelUserManagement.Hide();
            this.panelFacilitySystem.Hide();

            //bool isSort = true;

            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + CommonConstant.DLLFolder;

            //if (Directory.Exists(path) && CommonConstant.InstanceDictionaries.Any())
            //{
            //    try
            //    {
            //        dynamic instance = CommonConstant.InstanceDictionaries[FunctionDllConstant.PluginBase];
            //        Dictionary<int, string> appKind = instance.AppKind;

            //        // Hide all screen
            //        this.panelDeviceManagement.Hide();
            //        this.panelFacilityManagement.Hide();
            //        this.panelPostManagement.Hide();
            //        this.panelRoleManagement.Hide();
            //        this.panelUserManagement.Hide();
            //        this.panelFacilitySystem.Hide();

            //        // Sort menu
            //        if (appKind.Any())
            //        {
            //            foreach (KeyValuePair<int, string> item in CommonConstant.AppKind)
            //            {
            //                try
            //                {
            //                    if (CommonConstant.AppKind[item.Key] != appKind[item.Key])
            //                    {
            //                        Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            //                        CommonConstant.Logger.ErrorFormat(MessageConstant.MenuCouldNotSort, CommonConstant.AppKind[item.Key]);
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    isSort = false;
            //                    Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            //                    CommonConstant.Logger.ErrorFormat(MessageConstant.MenuCouldNotSort, CommonConstant.AppKind[item.Key]);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            isSort = false;
            //            Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            //            CommonConstant.Logger.ErrorFormat(MessageConstant.MenuCouldNotSort, CommonConstant.AppKind[0]);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        isSort = false;
            //        Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
            //        CommonConstant.Logger.ErrorFormat(MessageConstant.InheritanceDllNotFound, CommonConstant.Dll.PluginBase);
            //    }
            //}

            //// Close form menu and show form login
            //if (!Directory.Exists(path) || !CommonConstant.InstanceDictionaries.Any() || !isSort)
            //{
            //    this.Close();
            //    CommonConstant.LoginForm.Show();
            //}
        }

        #region Menu 
        /// <summary>
        /// Click button: 終了
        /// AppKind 1
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnFacility_Click(object sender, EventArgs e)
        {
            // Hide all screen
            this.panelDeviceManagement.Hide();
            this.panelFacilityManagement.Hide();
            this.panelPostManagement.Hide();
            this.panelRoleManagement.Hide();
            this.panelUserManagement.Hide();
            this.panelFacilitySystem.Hide();

            // Role Guest
            if (ListRoles == null)
            {
                Dialog.Error(MessageConstant.DoNotHavePermission);
                CommonConstant.Logger.Error(MessageConstant.NoRole);
            }
            // Role System or Role RLM_FACILITY
            else if (ListRoles.Exists(role => role == CommonConstant.Role.SYSTEM || role == CommonConstant.Role.RLM_FACILITY))
            {
                // Show screen Facility
                this.panelFacilitySystem.Show();
            }
            else
            {
                Dialog.Error(MessageConstant.DoNotHavePermission);
                CommonConstant.Logger.Error(MessageConstant.NoRole);
            }
        }

        /// <summary>
        /// Click button: メンテナンス
        /// AppKind 0
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            int numberScreen = 0;
            int positionX = 6;
            int positionY = 11;
            int screenDistance = 106;

            // Hide all screen function
            this.panelDeviceManagement.Hide();
            this.panelFacilityManagement.Hide();
            this.panelPostManagement.Hide();
            this.panelRoleManagement.Hide();
            this.panelUserManagement.Hide();
            this.panelFacilitySystem.Hide();

            // Role Guest
            if (ListRoles == null)
            {
                Dialog.Error(MessageConstant.DoNotHavePermission);
                CommonConstant.Logger.Error(MessageConstant.NoRole);
            }
            // Role System
            else if (ListRoles.Exists(role => role == CommonConstant.Role.SYSTEM))
            {
                // Show screen function Maintenance
                this.panelDeviceManagement.Show();
                this.panelDeviceManagement.Location = new Point(positionX, positionY);
                this.panelFacilityManagement.Show();
                this.panelPostManagement.Show();
                this.panelRoleManagement.Show();
                this.panelUserManagement.Show();
            }
            // All role into screen
            else if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTAPP || role == CommonConstant.Role.RLM_MSTDIV
                                           || role == CommonConstant.Role.RLM_MSTFAC || role == CommonConstant.Role.RLM_MSTROLE
                                           || role == CommonConstant.Role.RLM_MSTUSER))
            {
                // Role into screen Device Management
                if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTAPP))
                {
                    this.panelDeviceManagement.Show();
                    this.panelDeviceManagement.Location = new Point(positionX + (numberScreen * screenDistance), positionY);
                    numberScreen++;
                }

                // Role into screen Post Management
                if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTDIV))
                {
                    this.panelPostManagement.Show();
                    this.panelPostManagement.Location = new Point(positionX + (numberScreen * screenDistance), positionY);
                    numberScreen++;
                }

                // Role into screen Facility Management
                if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTFAC))
                {
                    this.panelFacilityManagement.Show();
                    this.panelFacilityManagement.Location = new Point(positionX + (numberScreen * screenDistance), positionY);
                    numberScreen++;
                }

                // Role into screen Role Maintenance
                if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTROLE))
                {
                    this.panelRoleManagement.Show();
                    this.panelRoleManagement.Location = new Point(positionX + (numberScreen * screenDistance), positionY);
                    numberScreen++;
                }

                // Role into screen User Maintenance
                if (ListRoles.Exists(role => role == CommonConstant.Role.RLM_MSTUSER))
                {
                    this.panelUserManagement.Show();
                    this.panelUserManagement.Location = new Point(positionX + (numberScreen * screenDistance), positionY);

                }
            }
            else
            {
                Dialog.Error(MessageConstant.DoNotHavePermission);
                CommonConstant.Logger.Error(MessageConstant.NoRole);
            }
        }

        /// <summary>
        /// Click button: 終了
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Function
        /// <summary>
        /// Click button: 設備システム
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnFacilitySystem_Click(object sender, EventArgs e)
        {
            this.panelFacilitySystem.BorderStyle = BorderStyle.FixedSingle;
            Type type = CommonConstant.Types.Single(t => t.FullName.Equals("CRFacility.View.FacilitySystemForm"));
            Form facilitySystem = (Form)Activator.CreateInstance(type);

            //FacilitySystemForm facilitySystem = new FacilitySystemForm(CommonConstant.AppKind[1]);
            facilitySystem.Show();
            facilitySystem.FormClosed += FacilitySystem_FormClosed;

            if (!CommonUtility.CheckFormIsOpen(facilitySystem.Name))
            {
                // Border panel
                this.panelFacilitySystem.BorderStyle = BorderStyle.None;
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.ErrorFormat(MessageConstant.CouldNotCallForm, facilitySystem.Name);
            }
        }

        /// <summary>
        /// Click button: 装置管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnDeviceManagement_Click(object sender, EventArgs e)
        {
            // Border panel
            this.panelDeviceManagement.BorderStyle = BorderStyle.FixedSingle;
            DeviceManagementForm deviceManagement = new DeviceManagementForm(CommonConstant.AppKind[0]);
            deviceManagement.Show();
            deviceManagement.FormClosed += DeviceManagement_FormClosed;

            if (!CommonUtility.CheckFormIsOpen(deviceManagement.Name))
            {
                // Border panel
                this.panelDeviceManagement.BorderStyle = BorderStyle.None;
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.ErrorFormat(MessageConstant.CouldNotCallForm, deviceManagement.Name);
            }
        }

        /// <summary>
        /// Click button: 区分管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnPostManagement_Click(object sender, EventArgs e)
        {
            // Border panel Todo
            //this.panelPostManagement.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Click button: 設備管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnFacilityManagement_Click(object sender, EventArgs e)
        {
            // Border panel
            this.panelFacilityManagement.BorderStyle = BorderStyle.FixedSingle;
            FacilityManagementForm facilityManagement = new FacilityManagementForm(CommonConstant.AppKind[0]);
            facilityManagement.Show();
            facilityManagement.FormClosed += FacilityManagement_FormClosed;

            if (!CommonUtility.CheckFormIsOpen(facilityManagement.Name))
            {
                this.panelFacilityManagement.BorderStyle = BorderStyle.None;
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.ErrorFormat(MessageConstant.CouldNotCallForm, facilityManagement.Name);
            }
        }

        /// <summary>
        /// Click button: ロール管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnRoleManagement_Click(object sender, EventArgs e)
        {
            // Border panel
            this.panelRoleManagement.BorderStyle = BorderStyle.FixedSingle;
            RoleManagementForm roleManagement = new RoleManagementForm(CommonConstant.AppKind[0]);
            roleManagement.Show();
            roleManagement.FormClosed += RoleManagement_FormClosed;

            if (!CommonUtility.CheckFormIsOpen(roleManagement.Name))
            {
                this.panelRoleManagement.BorderStyle = BorderStyle.None;
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.ErrorFormat(MessageConstant.CouldNotCallForm, roleManagement.Name);
            }
        }

        /// <summary>
        /// Click button: ユーザー管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            // Border panel
            this.panelUserManagement.BorderStyle = BorderStyle.FixedSingle;
            UserManagementForm userManagement = new UserManagementForm(CommonConstant.AppKind[0]);
            userManagement.Show();
            userManagement.FormClosed += UserManagement_FormClosed;

            if (!CommonUtility.CheckFormIsOpen(userManagement.Name))
            {
                this.panelUserManagement.BorderStyle = BorderStyle.None;
                Dialog.Error(MessageConstant.PleaseContactSystemAdministrator);
                CommonConstant.Logger.ErrorFormat(MessageConstant.CouldNotCallForm, userManagement.Name);
            }
        }
        #endregion

        #region FormClosed
        /// <summary>
        /// Form Close
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void RoleManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.panelRoleManagement.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Form Close
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void DeviceManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Border panel
            this.panelDeviceManagement.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Form Close
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Border panel
            this.panelUserManagement.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Form Close
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void FacilityManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Border panel
            this.panelFacilityManagement.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Form Close
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void FacilitySystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.panelFacilitySystem.BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Label
        /// <summary>
        /// Click label:設備システム
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblFacilitySystem_Click(object sender, EventArgs e)
        {
            this.btnFacilitySystem.PerformClick();
        }

        /// <summary>
        /// Click label:装置管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblDeviceManagement_Click(object sender, EventArgs e)
        {
            this.btnDeviceManagement.PerformClick();
        }

        /// <summary>
        /// Click label: 区分管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblPostManagement_Click(object sender, EventArgs e)
        {
            this.btnPostManagement.PerformClick();
        }

        /// <summary>
        /// Click label: ロール管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblFacilityManagement_Click(object sender, EventArgs e)
        {
            this.btnFacilityManagement.PerformClick();
        }

        /// <summary>
        /// Click label: ロール管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblRoleManagement_Click(object sender, EventArgs e)
        {
            this.btnRoleManagement.PerformClick();
        }

        /// <summary>
        /// Click label: ユーザー管理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void lblUserManagement_Click(object sender, EventArgs e)
        {
            this.btnUserManagement.PerformClick();
        }
        #endregion


    }
}
