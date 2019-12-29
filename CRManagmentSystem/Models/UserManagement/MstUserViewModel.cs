using System.ComponentModel;

namespace CRManagmentSystem.Models.UserManagement
{
    public class MstUserViewModel
    {
        /// <summary>
        /// ID primary key of table 
        /// </summary>
        [DisplayName("ID")]
        public string USERID { get; set; }

        /// <summary>
        /// USERNAME 
        /// </summary>
        [DisplayName("氏名")]
        public string USERNAME { get; set; }

        /// <summary>
        /// POSTNAME 
        /// </summary>
        [DisplayName("部署")]
        public string POSTNAME { get; set; }
    }
}
