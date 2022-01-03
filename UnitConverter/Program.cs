using System;
using UnitConverter.Business;
using UnitConverter.Common;

namespace UnitConverter
{
    internal class Program
    {
        private readonly ConverterService converterService;
        private readonly Logging logging;

        public Program()
        {
            converterService = new ConverterService();
            logging = new Logging();
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

                if (input == 1)
                {
                    MToCm();
                }
                else if (input == 2)
                {
                    CmToM();
                }
                else if (input == 3)
                {
                    CmToMm();
                }
                else if (input == 4)
                {
                    MmToCm();
                }
                else if (input == 5)
                {
                    MToIn();
                }
                else if (input == 6)
                {
                    InToM();
                }
                else if (input == 7)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a correct number! " +
                        "\nPress any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a correct number! " +
                    "\nPress any key to return to the main menu.");
                Console.ReadKey();
                Console.Clear();
            }

            //Console.Clear();

            //if (input == 1)
            //{
            //    MToCm();
            //}
            //else if (input == 2)
            //{
            //    CmToM();
            //}
            //else if (input == 3)
            //{
            //    CmToMm();
            //}
            //else if (input == 4)
            //{
            //    MmToCm();
            //}
            //else if (input == 5)
            //{
            //    MToIn();
            //}
            //else if (input == 6)
            //{
            //    InToM();
            //}
            //else if (input == 7)
            //{
            //    Environment.Exit(0);
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please enter a correct input! " +
            //        "\nPress any key to return to the main menu.");
            //    Console.ReadKey();
            //    Console.Clear();
            //}
        }

        void CmToM()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to meters");
            bool success = float.TryParse(Console.ReadLine(), out float input);
            
            if (!success)
            {
                Console.Clear();
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                CmToM();
            }

            string output = $"{converterService.CentimeterToMeter(input)} meter";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} centimeter to {output}.");

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
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                MToCm();
            }

            string output = $"{converterService.MeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} meter to {output}.");

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
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                CmToMm();
            }

            string output = $"{converterService.CentimeterToMillimeter(input)} millimeter";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} centimeters to {output}.");

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
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                MmToCm();
            }

            string output = $"{converterService.MillimeterToCentimeter(input)} centimeter";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} millimeter to {output}.");

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
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                MToIn();
            }

            string output = $"{converterService.MeterToInch(input)} inch";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} meter to {output}.");

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
                Console.WriteLine("You did not enter a number! Please try again. \n");
                logging.WriteToLogFile("Error: User did not enter a number!");
                InToM();
            }

            string output = $"{converterService.InchToMeter(input)} meter";
            Console.WriteLine(output);
            logging.WriteToLogFile($"{input} inches to {output}.");

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
