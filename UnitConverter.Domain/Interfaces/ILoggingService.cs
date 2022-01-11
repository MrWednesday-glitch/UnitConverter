namespace UnitConverter.Domain.Interfaces
{
    public  interface ILoggingService
    {
        void WriteToLogFile(string sMsg);

        void WriteToDatabase(string sMsg);
    }
}
