using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnitConverter.Business;

namespace UnitConverter.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ConverterService _converterService;
        private readonly LoggingService _loggingService;

        public MainWindow()
        {
            InitializeComponent();
            _converterService = new ConverterService();
            _loggingService = new LoggingService();
        }

        void NoValidNumberError()
        {
            string errorMessage = "Error: You did not enter a valid number, please try again.";
            _loggingService.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        void NegativeNumberError()
        {
            string errorMessage = "Error: You entered a negative number, please try again.";
            _loggingService.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Convert_Button_Click(object sender, RoutedEventArgs e)
        { 
            if (MeterToCentimeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
NoValidNumberError();
                }

                if(input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.MeterToCentimeter(input);
                _loggingService.WriteToDatabase($"{input} meter to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "m";
                OutputType_Label.Content = "cm";
            }
            else if (CentimeterToMeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
                    NoValidNumberError();
                }

                if (input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.CentimeterToMeter(input);
                _loggingService.WriteToDatabase($"{input} centimeter to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "cm";
                OutputType_Label.Content = "m";
            }
            else if (CentimeterToMillimeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
                    NoValidNumberError();
                }

                if (input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.CentimeterToMillimeter(input);
                _loggingService.WriteToDatabase($"{input} centimeter to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "cm";
                OutputType_Label.Content = "mm";
            }
            else if (MillimeterToCentimeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
                    NoValidNumberError();
                }

                if (input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.MillimeterToCentimeter(input);
                _loggingService.WriteToDatabase($"{input} millimeter to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "mm";
                OutputType_Label.Content = "cm";
            }
            else if (MeterToInch_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                { 
                    NoValidNumberError();
                }

                if (input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.MeterToInch(input);
                _loggingService.WriteToDatabase($"{input} meter to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "m";
                OutputType_Label.Content = "in";
            }
            else if (InchToMeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
                    NoValidNumberError();
                }

                if (input < 0)
                {
                    NegativeNumberError();
                }

                double output = _converterService.InchToMeter(input);
                _loggingService.WriteToDatabase($"{input} inch to {output}.");
                Output_Label.Content = output.ToString();
                InputType_Label.Content = "in";
                OutputType_Label.Content = "m";
            }
            else
            {
                string noSelectionMadeError = "You failed to select any convertmethod, you dummy.";
                _loggingService.WriteToDatabase(noSelectionMadeError);
                MessageBox.Show(noSelectionMadeError, "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Kill_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            Input_TextBox.Clear();
            Output_Label.Content = "0";
        }
    }
}
