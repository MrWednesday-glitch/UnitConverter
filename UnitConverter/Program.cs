using System;
using UnitConverter.Business;

namespace UnitConverter
{
    internal class Program
    {
        private readonly ConverterService _converterService;
        private readonly LoggingService _logging;

        public Program()
        {
            _converterService = new ConverterService();
            _logging = new LoggingService();
        }

        static void Main(string[] args)
        {
            Program program = new();
            while (true)
            {
                program.MainMenu();
            }
        }

        private void NegativeNumberError()
        {
            string errorMessage = "Error: You entered a negative number. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMessage} \n");
            _logging.WriteToLogFile(errorMessage);
        }

        private void NoValidNumberError()
        {
            string errorMessage = "Error: You did not enter a valid number to be converted. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMessage} \n");
            _logging.WriteToLogFile(errorMessage);
        }

        private void UserInputError()
        {
            string errorMessage = "Error: Input was not recognized, please enter a correct number!";

            Console.Clear();
            _logging.WriteToLogFile(errorMessage);
            Console.WriteLine(errorMessage +
                "\nPress any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }

        private void MainMenu()
        {
            Console.WriteLine("Welcome to this Unit Converter. " +
                "\n\nPlease select an option by pressing the appropriate number and pressing enter afterwards: " +
                "\n1. Convert meter to centimeter. " +
                "\n2. Convert centimeter to meter. " +
                "\n3. Convert centimeter to millimeter. " +
                "\n4. Convert millimeter to centimeter. " +
                "\n5. Convert meter to inch. " +
                "\n6. Convert inch to meter. " +
                "\n7. Kill this program.");

            bool success = int.TryParse(Console.ReadLine(), out int input);
            if (success)
            {
                Console.Clear();

                switch (input)
                {
                    case 1:
                        MToCm();
                        break;
                    case 2:
                        CmToM();
                        break;
                    case 3:
                        CmToMm();
                        break;
                    case 4:
                        MmToCm();
                        break;
                    case 5:
                        MToIn();
                        break;
                    case 6:
                        InToM();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        UserInputError();
                        break;
                }
            }
            else
            {
                UserInputError();
            }
        }

        private double Convert(bool success, double input, Action currentMethod, Func<double, double> serviceMethod)
        {
            if (!success)
            {
                NoValidNumberError();
                currentMethod();
            }

            if (input < 0)
            {
                NegativeNumberError();
                currentMethod();
            }

            Func<double, double> convert = serviceMethod;
            //double result = convert(input);
            return convert(input);
        }

        private void CmToM()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to meters");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, CmToM, _converterService.CentimeterToMeter)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeter to {output}.");

            SecondMenu(CmToM);
        }

        private void MToCm()
        {
            Console.WriteLine("Please enter a number of meters to be converted to centimeter");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, MToCm, _converterService.MeterToCentimeter)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            SecondMenu(MToCm);
        }

        private void CmToMm()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to millimeters");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, CmToMm, _converterService.CentimeterToMillimeter)} millimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeters to {output}.");

            SecondMenu(CmToMm);
        }

        private void MmToCm()
        {
            Console.WriteLine("Please enter a number of millimeters to be converted to centimeters");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, MmToCm, _converterService.MillimeterToCentimeter)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} millimeter to {output}.");

            SecondMenu(MmToCm);
        }

        private void MToIn()
        {
            Console.WriteLine("Please enter a number of meters to be converted to inches");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, MToIn, _converterService.MeterToInch)} inch";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            SecondMenu(MToIn);
        }

        private void InToM()
        {
            Console.WriteLine("Please enter a number of inches to be converted to meters");
            bool success = double.TryParse(Console.ReadLine(), out double input);

            string output = $"{Convert(success, input, InToM, _converterService.InchToMeter)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} inches to {output}.");

            SecondMenu(InToM);
        }

        private void SecondMenu(Action currentMethod)
        {
            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            bool success = int.TryParse(Console.ReadLine(), out int input);
            if (success)
            {
                if (input == 1)
                {
                    Console.Clear();
                    currentMethod();
                }
                else if (input == 2)
                {
                    //Keep empty to return to MainMenu()
                }
                else if (input == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Choose a valid option.");
                }
            }
            else
            {
                UserInputError();
            }

            Console.Clear();
        }
    }
}
