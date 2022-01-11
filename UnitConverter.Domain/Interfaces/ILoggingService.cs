namespace UnitConverter.Domain.Interfaces
{
    public  interface ILoggingService
    {
        void WriteToLogFile(string message);

        void WriteToDatabase(string message);
    }
}
