using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.DeviceManagement
{
    public class MstApparatusModel
    {
        /// <summary>
        /// APPARATUSID primary key of table 
        /// </summary>
        public string APPARATUSID { get; set; }

        /// <summary>
        /// APPARATUSNAME
        /// </summary>
        public string APPARATUSNAME { get; set; }

        /// <summary>
        /// PERIOD
        /// </summary>
        public short PERIOD { get; set; }

        /// <summary>
        /// FLOOR
        /// </summary>
        public string FLOOR { get; set; }

        /// <summary>
        /// FLOOR1
        /// </summary>
        public short FLOOR1 { get; set; }

        /// <summary>
        /// FLOOR2
        /// </summary>
        public short FLOOR2 { get; set; }

        /// <summary>
        /// AREA
        /// </summary>
        public string AREA { get; set; }

        /// <summary>
        /// PILLAR
        /// </summary>
        public string PILLAR { get; set; }

        /// <summary>
        /// PILLAR1
        /// </summary>
        public string PILLAR1 { get; set; }

        /// <summary>
        /// PILLAR2
        /// </summary>
        public string PILLAR2 { get; set; }

        /// <summary>
        /// STREET
        /// </summary>
        public string STREET { get; set; }

        /// <summary>
        /// STREET1
        /// </summary>
        public short STREET1 { get; set; }

        /// <summary>
        /// STREET2
        /// </summary>
        public short STREET2 { get; set; }

        /// <summary>
        /// PROCESS
        /// </summary>
        public string PROCESS { get; set; }

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
        public string UPDUSER { get; set; }
    }
}
