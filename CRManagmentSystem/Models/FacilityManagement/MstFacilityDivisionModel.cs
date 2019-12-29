using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.FacilityManagement
{
    public class MstFacilityDivisionModel
    {


        /// <summary>
        /// FACILITYKBN
        /// </summary>
        public string FACILITYKBN { get; set; }

        /// <summary>
        /// divisionname
        /// </summary>
        [DisplayName("設備区分名")]
        public string DIVISIONNAME { get; set; }

        /// <summary>
        /// facilityid
        /// </summary>
        [DisplayName("設備ID")]
        public string FACILITYID { get; set; }
        /// <summary>
        /// facilityname
        /// </summary>
        [DisplayName("設備名")]
        public string FACILITYNAME { get; set; }
        /// <summary>
        /// period
        /// </summary>
        [DisplayName("期")]
        public string PERIOD { get; set; }
        /// <summary>
        /// tier
        /// </summary>
        [DisplayName("階層")]
        public string TIER { get; set; }
        /// <summary>
        /// area
        /// </summary>
        [DisplayName("エリア")]
        public string AREA { get; set; }
        /// <summary>
        /// pillar
        /// </summary>
        [DisplayName("柱	")]
        public string PILLAR { get; set; }
        /// <summary>
        /// street
        /// </summary>
        [DisplayName("通	")]
        public string STREET { get; set; }
    }
}
