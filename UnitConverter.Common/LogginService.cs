using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Common
{
    public class LogginService
    {
        #region "Variables"

        private string _date;
        private string _time;
        private const string _connectionstring = @""; //Pretend that there is a dbo connection here
        private SqlConnection _connection;

        #endregion

        public LogginService()
        {
            _connection = new SqlConnection(_connectionstring);
        }

        #region "Local methods"

        public void WriteToDatabase(string sMsg)
        {
            try
            {
                _date = DateTime.Now.ToShortDateString().ToString();
                _time = DateTime.Now.ToLongTimeString().ToString();

                string query = $"INSERT INTO dbo.Logs (Dates, Times, Msg) VALUES (@Dates, @Times, @Msg)";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Dates", _date);
                    command.Parameters.AddWithValue("@Times", _time);
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

        #endregion
    }
}
