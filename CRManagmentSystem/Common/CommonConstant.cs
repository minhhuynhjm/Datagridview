using CRManagmentSystem.View.FacilityManagement;
using CRManagmentSystem.View.Login;
using log4net;
using System.Collections.Generic;

namespace CRManagmentSystem.Common
{
    public sealed class CommonConstant
    {
        /// <summary>
        /// Key in file App.config file to get connection string to Report Creator database 
        /// </summary>
        public const string CRManagmentSystemDbConnectionString = "CRManagmentSystemdevdb";

        public static List<System.Type> Types = new List<System.Type>();
        public const string DLLFolder = "\\DLL";
        public const string DLLExtension = "*.dll";
        private static List<string> listBLOs = new List<string>
        {
            FunctionDllConstant.UserManagementBLO,
            FunctionDllConstant.RoleManagementBLO,
            FunctionDllConstant.FacilityManagementBLO,
            FunctionDllConstant.FacilitySystemBLO,
            FunctionDllConstant.DeviceManagementBLO,
            FunctionDllConstant.PluginBase
        };
        private static Dictionary<string, dynamic> instanceDictionaries = new Dictionary<string, dynamic>();
        /// <summary>
        /// Logger
        /// </summary>
        public static ILog Logger = LogManager.GetLogger(EventLogSourceName);

        /// <summary>
        /// Login form
        /// </summary>
        public static LoginForm LoginForm;

        /// <summary>
        /// Login form
        /// </summary>
        public static FacilityManagementForm FacilityManagementForm;

        /// <summary>
        /// Information user when login
        /// </summary>
        public static class UserInfo
        {
            public static string UserId { get; set; }
        }

        public sealed class CodeLimitation
        {
            #region Private constructor

            /// <summary>
            /// Create private constructor to prevent compilers generate automatically public constructor in runtime.
            /// </summary>
            private CodeLimitation()
            {
                // Do nothing
            }

            #endregion Private constructor

            /// <summary>
            /// Maximum event id of error level zero
            /// </summary>          
            public const int MaximumErrorLevelZero = 9999;

            /// <summary>
            /// Minimum event id of error level one
            /// </summary>          
            public const int MinimumErrorLevelOne = 10000;

            /// <summary>
            /// Maximum event id of error level one
            /// </summary>         
            public const int MaximumErrorLevelOne = 19000;

            /// <summary>
            /// Minimum event id of error level two
            /// </summary>          
            public const int MinimumErrorLevelTwo = 20000;

            /// <summary>
            /// Maximum event id of error level two
            /// </summary>          
            public const int MaximumErrorLevelTwo = 29999;

            /// <summary>
            /// Minimum event id of error level three
            /// </summary>          
            public const int MinimumErrorLevelThree = 30000;

            /// <summary>
            /// Maximum event id of error level three
            /// </summary>         
            public const int MaximumErrorLevelThree = 39999;
        }

        /// <summary>
        /// Event log source name CRManagmentSystem.CRManagementSys
        /// </summary>      
        public const string EventLogSourceName = "CRManagmentSystem.CRManagementSys";

        //Add LogEvent

        /// <summary>
        /// Error when reading Appconfig file
        /// </summary>
        public const int Fatal00000 = 00000;

        /// <summary>
        /// Error command 
        /// </summary>
        public const int Fatal00010 = 00010;

        /// <summary>
        /// Access Database Fail
        /// </summary>
        public const int Fatal00020 = 00020;

        /// <summary>
        /// Access file error
        /// </summary>
        public const int Fatal00030 = 00030;


        /// <summary>
        /// List role default system
        /// </summary>
        public static class Role
        {
            public const string RLA_MSTFAC = "RLU_MSTROLE";
            public const string RLU_MSTFAC = "RLU_MSTROLE";
            public const string RLD_MSTFAC = "RLU_MSTROLE";
            public const string RLU_MSTROLE = "RLU_MSTROLE";
            public const string RLA_MSTUSER = "RLA_MSTUSER";
            public const string RLU_MSTUSER = "RLU_MSTUSER";
            public const string RLU_FACILITY = "RLU_FACILITY";
            public const string RLD_MSTUSER = "RLD_MSTUSER";
            public const string SYSTEM = "SYSTEM";

            /// <summary>
            /// Role into screen Role Maintenance
            /// </summary>
            public const string RLM_MSTROLE = "RLM_MSTROLE";

            /// <summary>
            /// Role into screen Facility Management
            /// </summary>
            public const string RLM_MSTFAC = "RLM_MSTFAC";

            /// <summary>
            /// Role into screen User Maintenance
            /// </summary>
            public const string RLM_MSTUSER = "RLM_MSTUSER";

            /// <summary>
            /// Role into screen Device Management
            /// </summary>
            public const string RLM_MSTAPP = "RLM_MSTAPP";

            /// <summary>
            /// Role into screen Post Management
            /// </summary>
            public const string RLM_MSTDIV = "RLM_MSTDIV";

            /// <summary>
            /// Role into screen Facility System
            /// </summary>
            public const string RLM_FACILITY = "RLM_FACILITY";
        }

        /// <summary>
        /// AppKind in CRBasePlugin
        /// </summary>
        private static Dictionary<int, string> appKind = new Dictionary<int, string>
        {
            {0, "メンテナンス"}, // Maintenance
            {1, "設備"}, // Facilities
            {2, "アラート"}, // Alert
            {3, "点検"} // Inspection
        };

        /// <summary>
        /// AppKind in CRBasePlugin
        /// </summary>
        public static Dictionary<int, string> AppKind
        {
            get { return appKind; }           
            private set { appKind = value; }          
        }

        /// <summary>
        /// Instance Dictionary
        /// </summary>
        public static Dictionary<string, dynamic> InstanceDictionaries
        {
            get
            {
                return instanceDictionaries;
            }

            set
            {
                instanceDictionaries = value;
            }
        }

        /// <summary>
        /// List string BLO
        /// </summary>
        public static List<string> ListBLOs
        {
            get
            {
                return listBLOs;
            }

            set
            {
                listBLOs = value;
            }
        }

        /// <summary>
        /// Gas Type Default Value in Combobox System Type
        /// </summary>
        public static class GasType
        {
            public const string Key = "0:1110";
            public const string Value = "ガス種類";
        }

        /// <summary>
        /// List division in MST_DIVISION
        /// </summary>
        public static class Division
        {
            public const string DivisionPeriod = "120";
            public const string DivisionFloor = "130";
            public const string DivisionArea = "140";
            public const string DivisionPillar = "150";
            public const string DivisionStreet = "160";
            public const string DivisionProcess = "110";
        }

        public static class Dll
        {
            /// <summary>
            /// Dll for AppKind
            /// </summary>
            public const string PluginBase = "PluginBase.dll";

            /// <summary>
            /// FacilitySystem dll
            /// </summary>
            public const string FacilitySystem = "CRFacility.dll";

            /// <summary>
            /// Dll for Device management
            /// </summary>
            public const string DeviceManagement = "CRMstApp.dll";
        }
        public enum FacilityDetailMode
        {
            DeviceDetail,
            SystemDetail,
            SystemEdit
        }

        /// <summary>
        /// List Form
        /// </summary>
        public static class Form
        {
            public const string UserManagerment = "UserManagermentForm";
            public const string RoleManagerment = "RoleManagermentForm";
            public const string DeviceManagement = "DeviceManagementForm";
            public const string FacilityManagement = "FacilityManagementForm";
            public const string FacilitySystem = "FacilitySystemForm";
        }

        /// <summary>
        /// Full name header
        /// </summary>
        public const string FullName = "氏名";

        /// <summary>
        /// USERID
        /// </summary>
        public const string UserId = "USERID";

        /// <summary>
        /// ROLEID
        /// </summary>
        public const string RoleId = "ROLEID";

        /// <summary>
        /// DESCRIPTION
        /// </summary>
        public const string Description = "DESCRIPTION";
    }
}
