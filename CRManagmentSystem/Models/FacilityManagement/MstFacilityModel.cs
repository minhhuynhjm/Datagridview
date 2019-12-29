using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.FacilityManagement
{
    public class MstFacilityModel
    {
        /// <summary>
        /// facilityid
        /// </summary>
        public string FACILITYKBN { get; set; }

        /// <summary>
        /// facilityid
        /// </summary>
        public string FACILITYID { get; set; }

        /// <summary>
        /// facilityname
        /// </summary>
        public string FACILITYNAME { get; set; }

        /// <summary>
        /// facilityname
        /// </summary>
        public string PARENTID { get; set; }

        /// <summary>
        /// period
        /// </summary>
        public short PERIOD { get; set; }

        /// <summary>
        /// tier
        /// </summary>
        public short FLOOR1 { get; set; }

        /// <summary>
        /// tier
        /// </summary>
        public short FLOOR2 { get; set; }

        /// <summary>
        /// area
        /// </summary>
        public string AREA { get; set; }

        /// <summary>
        /// pillar
        /// </summary>
        public string PILLAR1 { get; set; }

        /// <summary>
        /// pillar
        /// </summary>
        public string PILLAR2 { get; set; }

        /// <summary>
        /// street
        /// </summary>
        public short STREET1 { get; set; }

        /// <summary>
        /// street
        /// </summary>
        public short STREET2 { get; set; }

        /// <summary>
        /// street
        /// </summary>
        public string UPDUSER { get; set; }
    }
}
