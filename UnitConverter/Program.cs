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

        void NegativeNumberError()
        {
            string errorMsgNegaNumber = "Error: You entered a negative number. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMsgNegaNumber} \n");
            _logging.WriteToLogFile(errorMsgNegaNumber);
        }

        void NoValidNumberError()
        {
            string errorMsgNoValidNumber = "Error: You did not enter a valid number to be converted. Please try again.";

            Console.Clear();
            Console.WriteLine($"{errorMsgNoValidNumber} \n");
            _logging.WriteToLogFile(errorMsgNoValidNumber);
        }

        void UserInputError()
        {
            string errorMsgUserInput = "Error: Input was not recognized, please enter a correct number!";

            Console.Clear();
            _logging.WriteToLogFile(errorMsgUserInput);
            Console.WriteLine(errorMsgUserInput +
                "\nPress any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }

        void MainMenu()
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

        void CmToM()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to meters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                CmToM();
            }

            if (input < 0)
            {
                NegativeNumberError();
                CmToM();
            }

            string output = $"{_converterService.CentimeterToMeter(input)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeter to {output}.");

            SecondMenu(CmToM);
        }

        void MToCm()
        {
            Console.WriteLine("Please enter a number of meters to be converted to centimeter");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                MToCm();
            }

            if (input < 0)
            {
                NegativeNumberError();
                MToCm();
            }

            string output = $"{_converterService.MeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            SecondMenu(MToCm);
        }

        void CmToMm()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to millimeters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                CmToMm();
            }

            if (input < 0)
            {
                NegativeNumberError();
                CmToMm();
            }

            string output = $"{_converterService.CentimeterToMillimeter(input)} millimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeters to {output}.");

            SecondMenu(CmToMm);
        }

        void MmToCm()
        {
            Console.WriteLine("Please enter a number of millimeters to be converted to centimeters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                MmToCm();
            }

            if (input < 0)
            {
                NegativeNumberError();
                MmToCm();
            }

            string output = $"{_converterService.MillimeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} millimeter to {output}.");

            SecondMenu(MmToCm);
        }

        void MToIn()
        {
            Console.WriteLine("Please enter a number of meters to be converted to inches");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                MToIn();
            }

            if (input < 0)
            {
                NegativeNumberError();
                MToIn();
            }

            string output = $"{_converterService.MeterToInch(input)} inch";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            SecondMenu(MToIn);
        }

        void InToM()
        {
            Console.WriteLine("Please enter a number of inches to be converted to meters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                NoValidNumberError();
                InToM();
            }

            if (input < 0)
            {
                NegativeNumberError();
                InToM();
            }

            string output = $"{_converterService.InchToMeter(input)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} inches to {output}.");

            SecondMenu(InToM);
        }

        void SecondMenu(Action action)
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
                    action();
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
