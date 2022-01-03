using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Domain.Interfaces
{
    public interface IConverterService
    {
        double MeterToCentimeter(double meter);

        double CentimeterToMeter(double centimeter);

        double CentimeterToMillimeter(double centimeter);

        double MillimeterToCentimeter(double millimeter);

        double MeterToInch(double meter);

        double InchToMeter(double inch);
    }
}
