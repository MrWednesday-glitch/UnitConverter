using System;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class ConverterService : IConverterService 
    {
        private readonly LoggingService _logging;
        private const string _errorMsgNegaNumber = "You accidentally entered a negative number, no worries, I fixed it for you.";

        public ConverterService()
        {
            _logging = new LoggingService();
        }

        public double MeterToCentimeter(double meter)
        {
            if (meter < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                meter *= -1;
            }
            return meter * 100;
        }

        public double CentimeterToMeter(double centimeter)
        {
            if (centimeter < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                centimeter *= -1;
            }
            return centimeter / 100;
        }

        public double CentimeterToMillimeter(double centimeter)
        {
            if (centimeter < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                centimeter *= -1;
            }
            return centimeter * 10;
        }

        public double MillimeterToCentimeter(double millimeter)
        {
            if (millimeter < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                millimeter *= -1;
            }
            return millimeter / 10;
        }

        public double MeterToInch(double meter)
        {
            if (meter < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                meter *= -1;
            }
            return meter * 39.37008;
        }

        public double InchToMeter(double inch)
        {
            if (inch < 0)
            {
                _logging.WriteToLogFile(_errorMsgNegaNumber);
                Console.WriteLine(_errorMsgNegaNumber);
                inch *= -1;
            }
            return inch / 39.37008;
        }
    }
}
