using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.DeviceManagement
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
        /// FLOOR
        /// </summary>
        [DisplayName("階層")]
        public string FLOOR { get; set; }

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

        /// <summary>
        /// PROCESS
        /// </summary>
        [DisplayName("行程")]
        public string PROCESS { get; set; }
    }
}
