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
