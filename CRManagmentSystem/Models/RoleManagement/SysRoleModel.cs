using System;

namespace CRManagmentSystem.Models.RoleManagement
{
    public class SysRoleModel
    {
        /// <summary>
        /// ID primary key of table <br/>  
        /// </summary>
        public string USERID { get; set; }
        /// <summary>
        /// RoleId <br/>  
        /// </summary>
        public string ROLEID { get; set; }
        /// <summary>
        /// UpdateDate <br/>  
        /// </summary>
        public DateTime UPDATEDATE { get; set; }
        /// <summary>
        /// UPDUser <br/>  
        /// </summary>
        public string UPDUSER { get; set; }
    }
}
