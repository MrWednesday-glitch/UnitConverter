﻿using System;
using System.Diagnostics;
using System.IO;

namespace UnitConverter.Common
{
    public class LoggingService
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
                Console.WriteLine(ex);
            }
        }

        #endregion
    }
}
