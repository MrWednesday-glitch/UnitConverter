using System;
using UnitConverter.Business;

namespace UnitConverter
{
    internal class Program
    {
        private readonly ConverterService converterService;

        public Program()
        {
            converterService = new ConverterService();
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

            int.TryParse(Console.ReadLine(), out int input);

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
                Console.WriteLine("Please enter a correct input! " +
                    "\nPress any key to return to the main menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        void CmToM()
        {
            Console.WriteLine("Please enter a number of centimeters to be converted to meters");
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.CentimeterToMeter(input)} meter");

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
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.MeterToCentimeter(input)} centimeter");

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
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.CentimeterToMillimeter(input)} millimeter");

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
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.MillimeterToCentimeter(input)} centimeter");

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
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.MeterToInch(input)} inch");

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
            float.TryParse(Console.ReadLine(), out float input);
            Console.WriteLine($"{converterService.InchToMeter(input)} meter");

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
