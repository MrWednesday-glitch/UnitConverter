using System;
using UnitConverter.Business;

namespace UnitConverter
{
    internal class Program
    {
        private readonly ConverterService _converterService;
        private readonly LoggingService _logging;

        #region Constructors
        public Program()
        {
            _converterService = new ConverterService();
            _logging = new LoggingService();
        }
        #endregion

        #region Methods
        static void Main(string[] args)
        {
            Program program = new();
            while (true)
            {
                program.ShowMainMenu();
            }
        }

        private enum ConversionChoice
        {
            KillProgram,
            MeterToCentimeter,
            CentimeterToMeter,
            CentimeterToMillimeter,
            MillimeterToCentimeter,
            MeterToInch,
            InchToMeter
        }

        private void ShowMainMenu()
        {
            Console.WriteLine("Welcome to this Unit Converter. " +
                "\n\nPlease select an option by pressing the appropriate number and pressing enter afterwards: " +
                "\n\n1. Convert meter to centimeter. " +
                "\n2. Convert centimeter to meter. " +
                "\n3. Convert centimeter to millimeter. " +
                "\n4. Convert millimeter to centimeter. " +
                "\n5. Convert meter to inch. " +
                "\n6. Convert inch to meter. " +
                "\n\n0. Kill this program.");

            bool success = int.TryParse(Console.ReadLine(), out int choice);
            if (success)
            {
                ConversionChoice userChoice = (ConversionChoice)choice;
                Console.Clear();

                switch (userChoice)
                {
                    case ConversionChoice.KillProgram:
                        Environment.Exit(0);
                        break;
                    case ConversionChoice.MeterToCentimeter:
                        MToCm();
                        break;
                    case ConversionChoice.CentimeterToMeter:
                        CmToM();
                        break;
                    case ConversionChoice.CentimeterToMillimeter:
                        CmToMm();
                        break;
                    case ConversionChoice.MillimeterToCentimeter:
                        MmToCm();
                        break;
                    case ConversionChoice.MeterToInch:
                        MToIn();
                        break;
                    case ConversionChoice.InchToMeter:
                        InToM();
                        break;
                    default:
                        ShowUserInputError();
                        break;
                }
            }
            else
            {
                ShowUserInputError();
            }
        }

        private void MToCm()
        {
            Convert(MToCm, _converterService.MeterToCentimeter, "m", "cm");

            ShowSecondMenu(MToCm);
        }

        private void CmToM()
        {
            Convert(CmToM, _converterService.CentimeterToMeter, "cm", "m");

            ShowSecondMenu(CmToM);
        }

        private void CmToMm()
        {
            Convert(CmToMm, _converterService.CentimeterToMillimeter, "cm", "mm");

            ShowSecondMenu(CmToMm);
        }

        private void MmToCm()
        {
            Convert(MmToCm, _converterService.MillimeterToCentimeter, "mm", "cm");

            ShowSecondMenu(MmToCm);
        }

        private void MToIn()
        {
            Convert(MToIn, _converterService.MeterToInch, "m", "in");

            ShowSecondMenu(MToIn);
        }

        private void InToM()
        {
            Convert(InToM, _converterService.InchToMeter, "in", "m");

            ShowSecondMenu(InToM);
        }

        private void Convert(Action currentMethod, Func<double, double> serviceMethod, string inputType, string outputType)
        {
            Console.WriteLine($"Please enter a number of {inputType} to be converted to {outputType}");
            bool success = double.TryParse(Console.ReadLine(), out double input);
            if (!success)
            {
                ShowNoValidNumberError();
                currentMethod();
            }

            if (input < 0)
            {
                ShowNegativeNumberError();
                currentMethod();
            }

            Func<double, double> convert = serviceMethod;
            double output = convert(input);
            Console.WriteLine($"{output} {outputType}");
            _logging.WriteToLogFile($"{input} {inputType} to {output} {outputType}.");
        }

        private enum PostConversionChoice
        {
            KillProgram,
            Recalculate,
            ReturnMainMenu
        }

        private void ShowSecondMenu(Action currentMethod)
        {
            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n\n0. Kill this program.");

            bool success = int.TryParse(Console.ReadLine(), out int choice);
            if (success)
            {
                PostConversionChoice userChoice = (PostConversionChoice)choice;
                switch (userChoice)
                {
                    case PostConversionChoice.KillProgram:
                        Environment.Exit(0);
                        break;
                    case PostConversionChoice.Recalculate:
                        Console.Clear();
                        currentMethod();
                        break;
                    case PostConversionChoice.ReturnMainMenu:
                        break;
                    default:
                        Console.WriteLine("Choose a valid option.");
                        break;
                }
            }
            else
            {
                ShowUserInputError();
            }

            Console.Clear();
        }

        private void ShowNegativeNumberError()
        {
            string errorMessage = "Error: You entered a negative number. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMessage} \n");
            _logging.WriteToLogFile(errorMessage);
        }

        private void ShowNoValidNumberError()
        {
            string errorMessage = "Error: You did not enter a valid number to be converted. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMessage} \n");
            _logging.WriteToLogFile(errorMessage);
        }

        private void ShowUserInputError()
        {
            string errorMessage = "Error: Input was not recognized, please enter a correct number!";

            Console.Clear();
            _logging.WriteToLogFile(errorMessage);
            Console.WriteLine(errorMessage +
                "\nPress any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion
    }
}
