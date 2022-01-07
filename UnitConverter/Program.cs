using System;
using UnitConverter.Business;

namespace UnitConverter
{
    internal class Program
    {
        private readonly ConverterService _converterService;
        private readonly LogginService _logging;
        private string _errorMsgUserInput = "Error: Input was not recognized, please enter a correct number! ";
        private string _errorMsgNoValidnumber = "Error: You did not enter a valid number to be converted. Please try again.";

        public Program()
        {
            _converterService = new ConverterService();
            _logging = new LogginService();
        }

        static void Main(string[] args)
        {
            Program program = new();
            while (true)
            {
                program.MainMenu();
            }
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
                        Console.Clear();
                        _logging.WriteToLogFile(_errorMsgUserInput);
                        Console.WriteLine(_errorMsgUserInput +
                            "\nPress any key to return to the main menu."); 
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            else
            {
                Console.Clear();
                _logging.WriteToLogFile(_errorMsgUserInput);
                Console.WriteLine(_errorMsgUserInput + 
                    "\nPress any key to return to the main menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        void CmToM()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to meters");
            bool success = float.TryParse(Console.ReadLine(), out float input);
            
            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                CmToM();
            }

            string output = $"{_converterService.CentimeterToMeter(input)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeter to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
    "\n1. Recalculate a different number. " +
    "\n2. Return to Main Menu. " +
    "\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                CmToM();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }

        void MToCm()
        {
            Console.WriteLine("Please enter a number of meters to be converted to centimeter");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                MToCm();
            }

            string output = $"{_converterService.MeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                MToCm();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }

        void CmToMm()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to millimeters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                CmToMm();
            }

            string output = $"{_converterService.CentimeterToMillimeter(input)} millimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} centimeters to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                CmToMm();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }

        void MmToCm()
        {
            Console.WriteLine("Please enter a number of millimeters to be converted to centimeters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                MmToCm();
            }

            string output = $"{_converterService.MillimeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} millimeter to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                MmToCm();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }

        void MToIn()
        {
            Console.WriteLine("Please enter a number of meters to be converted to inches");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                MToIn();
            }

            string output = $"{_converterService.MeterToInch(input)} inch";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} meter to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                MToIn();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }

        void InToM()
        {
            Console.WriteLine("Please enter a number of inches to be converted to meters");
            bool success = float.TryParse(Console.ReadLine(), out float input);

            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"{_errorMsgNoValidnumber} \n");
                _logging.WriteToLogFile(_errorMsgNoValidnumber);
                InToM();
            }

            string output = $"{_converterService.InchToMeter(input)} meter";
            Console.WriteLine(output);
            _logging.WriteToLogFile($"{input} inches to {output}.");

            Console.WriteLine("\nPlease select any of the following options and press enter: " +
"\n1. Recalculate a different number. " +
"\n2. Return to Main Menu. " +
"\n3. Kill this program.");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.Clear();
                InToM();
            }
            else if (choice == 2)
            {
                //Keep empty to return to MainMenu()
            }
            else if (choice == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Choose a valid option.");
            }

            Console.Clear();
        }
    }
}
