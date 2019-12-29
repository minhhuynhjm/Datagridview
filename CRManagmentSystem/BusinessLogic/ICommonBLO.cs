using System.Collections.Generic;

namespace CRManagmentSystem.BusinessLogic
{
    public interface ICommonBLO<T> where T : class
    {
        /// <summary>
        /// Add new a record to table
        /// </summary>
        /// <param name="newRecordInfo">
        /// The business entity object contains information of new record
        /// </param>
        /// <returns>Number of record added (only 0/1)</returns>
        bool Add(T newRecordInfo);

        /// <summary>
        /// Update a record in table
        /// </summary>
        /// <param name="updateRecordInfo">
        /// The business entity object contains new information of updating record
        /// </param>
        /// <returns>Number of record updated (only 0/1)</returns>
        bool Update(T updateRecordInfo);

        /// <summary>
        /// Delete a record in table
        /// </summary>
        /// <param name="deleteRecordInfo">
        /// The business entity object contains information of deleting record
        /// </param>
        /// <returns></returns>
        bool Delete(T deleteRecordInfo);

        /// <summary>
        /// Get all records in table and map to a list of business entity objects 
        /// </summary>
        /// <param name="allRecords">List of business entity objects</param>
        void GetAll(out List<T> allRecords);
    }
}
