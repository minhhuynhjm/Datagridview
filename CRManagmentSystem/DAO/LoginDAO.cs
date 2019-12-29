using CRManagmentSystem.Common;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRManagmentSystem.DAO
{
    public class LoginDAO : BaseDAO
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginDAO()
            : base(CommonConstant.CRManagmentSystemDbConnectionString)
        {
        }

        /// <summary>
        /// Get list role by userId
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <returns></returns>
        public List<string> GetRolesUser(string userId)
        {
            DataSet dtSet = new DataSet();
            List<string> listRoles = null;
            try
            {
                const string query = @"SELECT ROLEID FROM SYS_ROLE WHERE USERID ='{0}'";
                string queryFormat = string.Format(query, userId);

                dtSet = this.ExecuteQuery(queryFormat);

                listRoles = dtSet.Tables[0].AsEnumerable().Select(x => x[0].ToString()).ToList();

                return listRoles;
            }
            catch (Exception ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                throw ex;
            }
        }
    }
}
