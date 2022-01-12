﻿using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class LoggingService : ILoggingService
    {
        private const string _connectionstring = @""; //Pretend that there is a dbo connection here, or enter your own
        private readonly SqlConnection _connection;

        #region Constructors
        public LoggingService()
        {
            _connection = new SqlConnection(_connectionstring);
        }
        #endregion

        #region Methods
        public void WriteToDatabase(string message)
        {
            try
            {
                string date = DateTime.Now.ToShortDateString().ToString();
                string time = DateTime.Now.ToLongTimeString().ToString();

                string query = $"INSERT INTO dbo.Logs (Dates, Times, Msg) VALUES (@Dates, @Times, @Msg)";

                using (SqlCommand command = new(query, _connection))
                {
                    command.Parameters.AddWithValue("@Dates", date);
                    command.Parameters.AddWithValue("@Times", time);
                    command.Parameters.AddWithValue("@Msg", message);

                    _connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into database!");
                    }

                    _connection.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void WriteToLogFile(string message)
        {
            string logFormat = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ==> ";
            string date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            StreamWriter sw = new(@$"C:\Users\itvadmin\Documents\programma's\Log{date}.txt", true); //Probably enter your own pathname to prevent crashes
            try
            {
                sw.WriteLine(logFormat + message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(logFormat + ex);
                sw.WriteLine(logFormat + ex);
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }
        }
        #endregion

        //internal void WriteToLogFile(object errorMsgNegaNumber)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
