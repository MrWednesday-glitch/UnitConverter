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

        #region Constructors
        public MainWindow()
        {
            InitializeComponent();
            _converterService = new ConverterService();
            _loggingService = new LoggingService();
        }
        #endregion

        #region Methods
        private void NoValidNumberError()
        {
            string errorMessage = "Error: You did not enter a valid number, please try again.";
            _loggingService.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NegativeNumberError()
        {
            string errorMessage = "Error: You entered a negative number, please try again.";
            _loggingService.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Convert(Func<double, double> serviceMethod, string inputType, string outputType)
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

            Func<double, double> convert = serviceMethod;
            double output = convert(input);
            _loggingService.WriteToDatabase($"{input} {inputType} to {output} {outputType}.");
            Output_Label.Content = output.ToString();
            InputType_Label.Content = inputType;
            OutputType_Label.Content = outputType;
        }

        private void Convert_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MeterToCentimeter_Radio.IsChecked == true)
            {
                Convert(_converterService.MeterToCentimeter, "m", "cm");
            }
            else if (CentimeterToMeter_Radio.IsChecked == true)
            {
                Convert(_converterService.CentimeterToMeter, "cm", "m");
            }
            else if (CentimeterToMillimeter_Radio.IsChecked == true)
            {
                Convert(_converterService.CentimeterToMillimeter, "cm", "mm");
            }
            else if (MillimeterToCentimeter_Radio.IsChecked == true)
            {
                Convert(_converterService.MillimeterToCentimeter, "mm", "cm");
            }
            else if (MeterToInch_Radio.IsChecked == true)
            {
                Convert(_converterService.MeterToInch, "m", "in");
            }
            else if (InchToMeter_Radio.IsChecked == true)
            {
                Convert(_converterService.InchToMeter, "in", "m");
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
        #endregion
    }
}
