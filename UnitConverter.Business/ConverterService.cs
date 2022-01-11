using System;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class ConverterService : IConverterService
    {
        private readonly LoggingService _logging;

        public ConverterService()
        {
            _logging = new LoggingService();
        }

        private void NegativeNumberErrorMessage()
        {
            string _errorMsgNegaNumber = "You accidentally entered a negative number, no worries, I fixed it for you.";
            _logging.WriteToLogFile(_errorMsgNegaNumber); //TODO Have it only log to the logfile when using the consoleapp, and only log to the database when using the visual ui
            //_logging.WriteToDatabase(_errorMsgNegaNumber);
            Console.WriteLine(_errorMsgNegaNumber);
        }

        public double MeterToCentimeter(double meter)
        {
            if (meter < 0)
            {
                NegativeNumberErrorMessage();
                meter *= -1;
            }
            return meter * 100;
        }

        public double CentimeterToMeter(double centimeter)
        {
            if (centimeter < 0)
            {
                NegativeNumberErrorMessage();
                centimeter *= -1;
            }
            return centimeter / 100;
        }

        public double CentimeterToMillimeter(double centimeter)
        {
            if (centimeter < 0)
            {
                NegativeNumberErrorMessage();
                centimeter *= -1;
            }
            return centimeter * 10;
        }

        public double MillimeterToCentimeter(double millimeter)
        {
            if (millimeter < 0)
            {
                NegativeNumberErrorMessage();
                millimeter *= -1;
            }
            return millimeter / 10;
        }

        public double MeterToInch(double meter)
        {
            if (meter < 0)
            {
                NegativeNumberErrorMessage();
                meter *= -1;
            }
            return meter * 39.37008;
        }

        public double InchToMeter(double inch)
        {
            if (inch < 0)
            {
                NegativeNumberErrorMessage();
                inch *= -1;
            }
            return inch / 39.37008;
        }
    }
}
