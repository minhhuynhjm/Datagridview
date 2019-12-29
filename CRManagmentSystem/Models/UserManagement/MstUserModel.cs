using System;

namespace CRManagmentSystem.Models.UserManagement
{
    public class MstUserModel
    {
        /// <summary>
        /// ID primary key of table 
        /// </summary>
        public string USERID { get; set; }

        /// <summary>
        /// PASSWORD 
        /// </summary>
        public string PASSWORD { get; set; }

        /// <summary>
        /// USERNAME 
        /// </summary>
        public string USERNAME { get; set; }

        /// <summary>
        /// POSTID 
        /// </summary>
        public string POSTID { get; set; }

        /// <summary>
        /// POSTNAME 
        /// </summary>
        public string POSTNAME { get; set; }

        /// <summary>
        /// CREATEDATE 
        /// </summary>
        public DateTime CREATEDATE
        {
            get; set;
        }

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
