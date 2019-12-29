using System;

namespace CRManagmentSystem.Models.RoleManagement
{
    public class MstPostModel
    {
        /// <summary>
        /// PostId
        /// </summary>
        public string POSTID { get; set; }
        /// <summary>
        ///PostName
        /// </summary>
        public string POSTNAME { get; set; }
        /// <summary>
        /// CreateDate
        /// </summary>
        public DateTime CREATEDATE { get; set; }
        /// <summary>
        /// UpdateDate
        /// </summary>
        public DateTime UPDATEDATE { get; set; }
        /// <summary>
        /// UPDUser
        /// </summary>
        public string UPDUSER { get; set; }
    }
}
