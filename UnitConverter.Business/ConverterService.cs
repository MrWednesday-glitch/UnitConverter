using System;

namespace UnitConverter.Business
{
    public class ConverterService
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
            return meter / 39.37;
        }

        public double InchToMeter(double inch)
        {
            return inch * 39.37;
        }
    }
}
