using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRManagmentSystem.Models.FacilityManagement
{
    public class QueryModel
    {
        /// <summary>
        /// Query
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// Parameters
        /// </summary>
        public OracleParameter[] Parameters { get; set; }
    }
}
