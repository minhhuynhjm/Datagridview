using System.ComponentModel;

namespace CRManagmentSystem.Models.UserManagement
{
    public class MstRoleModel
    {

        /// <summary>
        /// ROLEID primary key of table 
        /// </summary>
      
        [DisplayName("ロールID")]
        public string ROLEID { get; set; }

        /// <summary>
        /// ROLENAME
        /// </summary>
        [DisplayName("ロール名")]
        public string ROLENAME { get; set; }

        /// <summary>
        /// FUNCNAME
        /// </summary>
        [DisplayName("機能名")]
        public string FUNCNAME { get; set; }

        /// <summary>
        /// DESCRIPTION
        /// </summary>
        [DisplayName("説明")]
        public string DESCRIPTION { get; set; }
    }
}
