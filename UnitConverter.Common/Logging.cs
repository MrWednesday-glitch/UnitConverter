using System;
using System.Diagnostics;
using System.IO;

namespace UnitConverter.Common
{
    public class Logging
    {
        #region "Variables"

        private string sLogFormat;
        private string sTime;

        #endregion

        #region "Local methods"

        public void WriteToLogFile(string sMsg)
        {
            try
            {
                sLogFormat = $"{DateTime.Now.ToShortDateString().ToString()} {DateTime.Now.ToLongTimeString().ToString()} ==> ";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();
                sTime = sYear + sMonth + sDay;

                string sPathName = @"C:\Users\itvadmin\Documents\programma's\Log" + sTime;
                StreamWriter sw = new(sPathName + ".txt", true);
                sw.WriteLine(sLogFormat + sMsg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                WriteToEventLog("MySite", "Logging.WriteToLogFile", "Error: " + ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void WriteToEventLog(string sLog, string sSource, string message, EventLogEntryType level)
        {
            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }

            EventLog.WriteEntry(sSource, message, level);
        }

        #endregion
    }
}
