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

        private void Convert_Button_Click(object sender, RoutedEventArgs e)
        { //It does not get here...?
            if (MeterToCentimeter_Radio.IsChecked == true)
            {
                bool success = double.TryParse(Input_TextBox.Text, out double input);
                if (!success)
                {
                    string errorMessage = "Error: You did not enter a valid number, please try again.";
                    _loggingService.WriteToDatabase(errorMessage);

                }
                double output = _converterService.MeterToCentimeter(input);
                _loggingService.WriteToDatabase($"{input} meter to {output}.");
                Output_TextBox.Text = output.ToString();
            }
        }
    }
}
