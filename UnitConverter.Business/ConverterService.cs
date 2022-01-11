using System;
using UnitConverter.Domain.Interfaces;

namespace UnitConverter.Business
{
    public class ConverterService : IConverterService
    {
        private const double _meterCentimeterRelation = 100;
        private const double _centimeterMillimeterRelation = 10;
        private const double _meterInchRelation = 39.37008;

        public ConverterService()
        {

        }

        public double MeterToCentimeter(double meter)
        {
            return meter * _meterCentimeterRelation;
        }

        public double CentimeterToMeter(double centimeter)
        {
            return centimeter / _meterCentimeterRelation;
        }

        public double CentimeterToMillimeter(double centimeter)
        {
            return centimeter * _centimeterMillimeterRelation;
        }

        public double MillimeterToCentimeter(double millimeter)
        {
            return millimeter / _centimeterMillimeterRelation;
        }

        public double MeterToInch(double meter)
        {
            return meter * _meterInchRelation;
        }

        public double InchToMeter(double inch)
        {
            return inch / _meterInchRelation;
        }
    }
}
