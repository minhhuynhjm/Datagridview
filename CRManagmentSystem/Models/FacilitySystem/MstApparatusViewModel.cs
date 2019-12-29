using System.ComponentModel;

namespace CRManagmentSystem.Models.FacilitySystem
{
    public class MstApparatusViewModel
    {
        /// <summary>
        /// APPARATUSID primary key of table 
        /// </summary>
        [DisplayName("装置ID")]
        public string APPARATUSID { get; set; }

        /// <summary>
        /// APPARATUSNAME
        /// </summary>
        [DisplayName("装置名")]
        public string APPARATUSNAME { get; set; }

        /// <summary>
        /// PERIOD
        /// </summary>
        [DisplayName("期")]
        public short PERIOD { get; set; }

        /// <summary>
        /// HIERARCHY
        /// </summary>
        [DisplayName("階層")]
        public string HIERARCHY { get; set; }

        /// <summary>
        /// AREA
        /// </summary>
        [DisplayName("エリア")]
        public string AREA { get; set; }

        /// <summary>
        /// PILLAR
        /// </summary>
        [DisplayName("柱")]
        public string PILLAR { get; set; }

        /// <summary>
        /// STREET
        /// </summary>
        [DisplayName("通")]
        public string STREET { get; set; }
    }
}
