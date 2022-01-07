using System;
using System.Data.SqlClient;
using System.IO;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class LoggingService : ILoggingService
    {
        private const string _connectionstring = @""; //Pretend that there is a dbo connection here
        private readonly SqlConnection _connection;

        public LoggingService()
        {
            _connection = new SqlConnection(_connectionstring);
        }

        public void WriteToDatabase(string sMsg)
        {
            try
            {
                string date = DateTime.Now.ToShortDateString().ToString();
                string time = DateTime.Now.ToLongTimeString().ToString();

                string query = $"INSERT INTO dbo.Logs (Dates, Times, Msg) VALUES (@Dates, @Times, @Msg)";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Dates", date);
                    command.Parameters.AddWithValue("@Times", time);
                    command.Parameters.AddWithValue("@Msg", sMsg);

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
                Console.WriteLine(ex);
            }
        }

        public void WriteToLogFile(string sMsg)
        {
            try
            {
                string sLogFormat = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ==> ";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();
                string sTime = sYear + sMonth + sDay;

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
    }
}
