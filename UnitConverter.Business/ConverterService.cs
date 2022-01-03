using System;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class ConverterService : IConverterService 
    {
        public double MeterToCentimeter(double meter)
        {
            return meter * 100;
        }

        public double CentimeterToMeter(double centimeter)
        {
            return centimeter / 100;
        }

        public double CentimeterToMillimeter(double centimeter)
        {
            return centimeter * 10;
        }

        public double MillimeterToCentimeter(double millimeter)
        {
            return millimeter / 10;
        }

        public double MeterToInch(double meter)
        {
            return meter * 39.37008;
        }

        public double InchToMeter(double inch)
        {
            return inch / 39.37008;
        }
    }
}
