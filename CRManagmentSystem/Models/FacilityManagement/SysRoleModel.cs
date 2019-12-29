using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.FacilityManagement
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
