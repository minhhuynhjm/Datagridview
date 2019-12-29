using CRManagmentSystem.DAO;
using System;
using System.Collections.Generic;

namespace CRManagmentSystem.BusinessLogic
{
    public class LoginBLO
    {
        private readonly LoginDAO loginDAO;
        public LoginBLO()
        {
            this.loginDAO = new LoginDAO();
        }

        /// <summary>
        /// Get list Roles by UserId
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <returns>List roles</returns>
        public List<string> GetRolesUser(string userId)
        {
            try
            {
                List<string> listRoles = this.loginDAO.GetRolesUser(userId);

                return listRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
