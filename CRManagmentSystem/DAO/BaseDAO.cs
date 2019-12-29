using CRManagmentSystem.Common;
using CRManagmentSystem.Properties;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace CRManagmentSystem.DAO
{
    public abstract class BaseDAO
    {

        #region Fields
        /// <summary>
        /// Control is used to write log to Windows Event Log
        /// </summary>
        private readonly Logger _logger = new Logger();

        /// <summary>
        /// Database connection object
        /// </summary>
        private OracleConnection _connection;

        /// <summary>
        /// Connection string to database
        /// </summary>
        protected string _connectionString;

        protected OracleConnection _transaction;

        protected bool _useExistingConnection;

        #endregion // Fields

        #region Properties

        /// <summary>
        /// Connection string to database
        /// </summary>
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }

        /// <summary>
        /// Database connection
        /// </summary>
        public IDbConnection Connection
        {
            get { return this._connection; }
            set
            {
                if (value is OracleConnection)
                {
                    this._connection = value as OracleConnection;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
        }

        /// <summary>
        /// Get state of connection to database
        /// </summary>
        public bool DbConnectionOpened
        {
            get
            {
                if (this._connection == null ||
                    this._connection.State == ConnectionState.Closed ||
                    this._connection.State == ConnectionState.Broken)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Get state of connection to database
        /// </summary>
        public bool UseExistingConnection
        {
            get { return this._useExistingConnection; }
            set { this._useExistingConnection = value; }
        }

        #endregion // Properties

        /// <summary>
        ///  Construtor
        /// </summary>
        /// <param name="connectionStringName">Name connect string read file app.config</param>
        public BaseDAO(string connectionStringName)
        {
            //Get connection string from app.config
            this._connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            this._useExistingConnection = false;
        }

        /// <summary>
        /// Method Open connection 
        /// </summary>
        /// <remarks>if using connection then Open connection </remarks>
        public void Open()
        {
            try
            {
                if (!this.DbConnectionOpened)
                {
                    //Initialize then open the connection
                    this._connection = new OracleConnection(this._connectionString);
                    this._connection.Open();
                }
            }
            catch (NotSupportedException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00010);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorDbConnectionOpenFailed + this._connectionString, ex);
                throw reportExp;
            }
            catch (OracleException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00010);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorDbConnectionOpenFailed + this._connectionString, ex);
                throw reportExp;
            }
            catch (Exception ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00010);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorDbConnectionOpenFailed + this._connectionString, ex);
                throw reportExp;
            }
        }
        /// <summary>
        /// Method close connection 
        /// </summary>
        /// <remarks>if connection not used then call method close</remarks>
        public void Close()
        {
            if (this.DbConnectionOpened && !this._useExistingConnection)
            {
                this._connection.Close();
                this._connection.Dispose();
                this._connection = null;
            }
        }

        /// <summary>
        /// Method Execute Query string get data from database
        /// </summary>
        /// <param name="query">String query</param>
        /// <returns>return value into datatable </returns>
        /// <param name="parameters">List paramters for the <c>query</c></param>
        /// <example>implement query "SELECT *FROM table"</example>
        public DataSet ExecuteQuery(string query, OracleParameter[] parameters = null)
        {
            DataSet resultDataSet = new DataSet();
            try
            {
                // Open connection
                Open();
                OracleCommand command = new OracleCommand(query, this._connection);
                if (parameters != null)
                {
                    command.BindByName = true;
                    command.Parameters.AddRange(parameters);
                }
                //init Data Adapter
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = command;

                // Fill data to dataset
                adapter.Fill(resultDataSet);
            }
            catch (CRManagmentSystemException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorExecuteQueryFailed, ex);
                throw reportExp;
            }
            catch (OracleException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00020);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorExecuteQueryFailed, ex);
                throw reportExp;
            }
            finally
            {
                Close();
            }
            return resultDataSet;
        }

        /// <summary>
        /// Method Executes the query, and returns the first column of the first row in the result set returned by the query
        /// </summary>
        /// <param name="query">string query data</param>
        /// <param name="parameters">List paramters for the <c>query</c></param>
        /// <remarks>Use the ExecuteScalar method to retrieve a single value, for example,
        /// an aggregate value, from a data source</remarks>
        /// <returns>result return is 1 if execute success</returns>
        /// <example>
        /// OracleCommand orComm = new OracleCommand("SELECT count(*) FROM Table_Name", OracleConnection);
        /// orComm.ExecuteScalar();
        /// </example>
        public object ExecuteScalar(string query, OracleParameter[] parameters = null)
        {
            try
            {
                // Open connection
                Open();

                //Init command
                OracleCommand command = new OracleCommand(query, _connection);
                if (parameters != null)
                {
                    command.BindByName = true;
                    command.Parameters.AddRange(parameters);
                }
                //Execute query, store to temp object for easy confirm when debugging
                object result = command.ExecuteScalar();
                return result;
            }
            catch (CRManagmentSystemException ex)
            {
                throw new CRManagmentSystemException(ex.Message);
            }
            catch (OracleException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00020);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorExecuteQueryFailed, ex);
                throw reportExp;
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
        /// Execute query string Insert/Update/Delete to database
        /// </summary>
        /// <param name="query">String query</param>     
        /// <param name="parameters">List paramters for the <c>query</c></param>
        /// <returns>Number of added/updated/deleted records </returns>
        public int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
        {
            int rowAffected = 0;
            OracleTransaction transaction;
            // Open connection
            Open();
            // Start a local transaction
            transaction = this._connection.BeginTransaction();
            // Assign transaction object for a pending local transaction
            try
            {
                //Init command
                OracleCommand command = new OracleCommand(query, _connection);

                command.Transaction = transaction;
                if (parameters != null)
                {
                    command.BindByName = true;
                    command.Parameters.AddRange(parameters);
                }

                //Execute query
                rowAffected = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (CRManagmentSystemException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                transaction.Rollback();
                throw new CRManagmentSystemException(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                transaction.Rollback();
                this._logger.WriteLog(ex, CommonConstant.Fatal00020);
                CRManagmentSystemException reportExp = new CRManagmentSystemException(Resources.MsgErrorExecuteQueryFailed, ex);
                throw reportExp;
            }
            catch (OracleException ex)
            {
                CommonConstant.Logger.Error(ex.Message);
                this._logger.WriteLog(ex, CommonConstant.Fatal00020);
                CRManagmentSystemException reportExp =
                        new CRManagmentSystemException(Resources.MsgErrorExecuteQueryFailed, ex);
                throw reportExp;
            }
            finally
            {
                Close();
            }
            return rowAffected;
        }

        #region Private methods
        /// <summary>
        /// Make a list command parameter objects from their name and value
        /// </summary>
        /// <param name="parametersNameValue">List name and value of parameters</param>
        /// <returns>
        /// Array command parameter objects
        /// </returns>
        protected OracleParameter[] MakeCommandParameters(Dictionary<string, object> parametersNameValue)
        {
            if (parametersNameValue == null || parametersNameValue.Count == 0)
            {
                return null;
            }

            // Make list Command paramter objects
            var parameters = new OracleParameter[parametersNameValue.Count];
            int paramIndex = 0;
            foreach (var kvp in parametersNameValue)
            {
                parameters[paramIndex] = new OracleParameter()
                {
                    ParameterName = kvp.Key,
                    Value = (kvp.Value == null) ? DBNull.Value : kvp.Value
                };
                paramIndex++;
            }
            return parameters;
        }
        #endregion // Private methods
    }
}
