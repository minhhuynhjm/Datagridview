using CRManagmentSystem.Properties;
using System;
using System.Diagnostics;
using System.Reflection;

namespace CRManagmentSystem.Common
{
    public class Logger
    {
        private readonly string _sourceName = Settings.Default.EventLogSourceName;

        public Logger(string sourceName = "")
        {
            if (!string.IsNullOrWhiteSpace(sourceName))
            {
                this._sourceName = sourceName;
            }
        }

        /// <summary>
        /// Write log to Windows Event log
        /// </summary>      
        /// <param name="ex">Exception information</param>
        /// <param name="strSpotCode">Spot Code</param>
        /// <param name="nEventId">EventId</param>
        /// <remarks>
        /// The format of the event log becomes it as follows:</BR>
        /// Module name
        /// File name
        /// Method name - Spot code
        /// Content of error
        /// </remarks>
        public void WriteLog(Exception exception,
                            string strSpotCode,
                            int nEventId,
                            int category = 0)
        {
            EventLogEntryType eletType;
            //The error level is set by EventId. 
            //0～9999	Error level 0
            if (nEventId <= CommonConstant.CodeLimitation.MaximumErrorLevelZero)
            {
                eletType = EventLogEntryType.Error;
            }
            //10000～19999 	Error level 1 20000～29999	Error level 2
            else if ((nEventId >= CommonConstant.CodeLimitation.MinimumErrorLevelOne) && (nEventId <= CommonConstant.CodeLimitation.MaximumErrorLevelTwo))
            {
                eletType = EventLogEntryType.Warning;
            }
            //30000～39999	Error level 3
            else
            {
                eletType = EventLogEntryType.Information;
            }

            try
            {
                MethodBase methodBase = new StackTrace(true).GetFrame(1).GetMethod();
                //Write log
                EventLog.WriteEntry(this._sourceName,
                                    methodBase.Module +
                                    System.Environment.NewLine +
                                    methodBase.DeclaringType.Name +
                                    System.Environment.NewLine +
                                    methodBase.Name +
                                    "-" +
                                    strSpotCode +
                                    System.Environment.NewLine +
                                    exception.ToString(),
                                    eletType,
                                    nEventId,
                                    (short)category);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Write log to Windows Event log
        /// </summary>   
        /// <param name="message">Log message</param>        
        /// <param name="nEventId">Event ID</param>
        /// <param name="category">Category number (given ReportID for this parameter)</param>
        /// <remarks>
        /// The format of the event log becomes it as follows:</BR>
        /// Module name
        /// File name
        /// Content of error
        /// </remarks>
        public void WriteLog(string message,
                            int nEventId,
                            int category = 0,
                            int callerLevel = 1)
        {
            EventLogEntryType eletType;
            //The error level is set by EventId. 
            //0～9999	Error level 0
            if (nEventId <= CommonConstant.CodeLimitation.MaximumErrorLevelZero)
            {
                eletType = EventLogEntryType.Error;
            }
            //10000～19999 	Error level 1 20000～29999	Error level 2
            else if (nEventId >= CommonConstant.CodeLimitation.MinimumErrorLevelOne && nEventId <= CommonConstant.CodeLimitation.MaximumErrorLevelTwo)
            {
                eletType = EventLogEntryType.Warning;
            }
            //30000～39999	Error level 3
            else
            {
                eletType = EventLogEntryType.Information;
            }

            try
            {
                MethodBase methodBase = new StackTrace(true).GetFrame(callerLevel).GetMethod();

                //Write log
                EventLog.WriteEntry(this._sourceName,
                                    methodBase.Module +
                                    System.Environment.NewLine +
                                    methodBase.DeclaringType.Name +
                                    System.Environment.NewLine +
                                    methodBase.Name +
                                    "-" +
                                    System.Environment.NewLine +
                                    message,
                                    eletType,
                                    nEventId,
                                    (short)category);
            }
            catch
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Write log to Windows Event log
        /// </summary>   
        /// <param name="ex">Exception</param>        
        /// <param name="nEventId">Event ID</param>
        /// <remarks>
        /// The format of the event log becomes it as follows:</BR>
        /// Module name
        /// File name
        /// Content of error
        /// </remarks>
        public void WriteLog(Exception ex,
                            int nEventId,
                            int category = 0)
        {
            WriteLog(ex.ToString(), nEventId, category, 2);
        }
    }
}