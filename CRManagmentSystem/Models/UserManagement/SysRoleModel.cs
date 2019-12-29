using System;

namespace CRManagmentSystem.Models.UserManagement
{
    class SysRoleModel
    {
        /// <summary>
        /// USERID primary key of table 
        /// </summary>
        public string USERID { get; set; }

        /// <summary>
        /// ROLEID primary key of table 
        /// </summary>
        public string ROLEID { get; set; }


        /// <summary>
        /// UPDATEDATE 
        /// </summary>
        public DateTime UPDATEDATE
        {
            get; set;
        }

        /// <summary>
        /// UPDUSER 
        /// </summary>
        public string UPDUSER
        {
            get; set;
        }
    }
}
