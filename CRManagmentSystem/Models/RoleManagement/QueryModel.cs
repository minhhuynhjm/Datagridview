using Oracle.ManagedDataAccess.Client;

namespace CRManagmentSystem.Models.RoleManagement
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
