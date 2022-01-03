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

            float userMeasurement = 0;

            if (input == 1)
            {
                Console.WriteLine("Please enter a number of meters to be converted to centimeter");
                try
                {
                    float.TryParse(Console.ReadLine(), out userMeasurement);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a correct number!");
                    throw;
                }
                Console.WriteLine($"{converterService.MeterToCentimeter(userMeasurement)} centimeter");
                //Console.ReadKey();
            }
            else if (input == 2)
            {
                Console.WriteLine("Please enter a number of centimeters to be converted to meters");
                try
                {
                    float.TryParse(Console.ReadLine(), out userMeasurement);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a correct number!");
                    throw;
                }
                Console.WriteLine($"{converterService.CentimeterToMeter(userMeasurement)} meter");
            }
            else if (input == 3)
            {

                Console.WriteLine("Please enter a number of centimeters to be converted to millimeters");
                try
                {
                    float.TryParse(Console.ReadLine(), out userMeasurement);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a correct number!");
                    throw;
                }
                Console.WriteLine($"{converterService.CentimeterToMillimeter(userMeasurement)} millimeter");
            }
            else if (input == 4)
            {

            }
            else if (input == 5)
            {

            }
            else if (input == 6)
            {

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
    }
}
