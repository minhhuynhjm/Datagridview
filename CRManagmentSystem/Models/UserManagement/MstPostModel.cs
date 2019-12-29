using System;

namespace CRManagmentSystem.Models.UserManagement
{
    public class MstPostModel
    {
        /// <summary>
        /// POSTID primary key of table   
        /// </summary>
        public string POSTID { get; set; }

        /// <summary>
        /// POSTNAME 
        /// </summary>
        public string POSTNAME { get; set; }

        /// <summary>
        /// CREATEDATE 
        /// </summary>
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// UPDATEDATE 
        /// </summary>
        public DateTime UPDATEDATE { get; set; }

        /// <summary>
        /// UPDUSER 
        /// </summary>
        public string UPDUSER
        {
            get; set;
        }

    }
}
