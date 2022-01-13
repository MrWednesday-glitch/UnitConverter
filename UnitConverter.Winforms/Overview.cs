using System;
using System.Windows.Forms;
using UnitConverter.Business;

namespace UnitConverter.Winforms
{
    public partial class Overview : Form
    {
        private readonly ConverterService _converterService;
        private readonly LoggingService _logging;

        #region Constructors
        public Overview()
        {
            InitializeComponent();
            _converterService = new ConverterService();
            _logging = new LoggingService();
        }
        #endregion

        #region Methods
        private void NoValidNumberError()
        {
            string errorMessage = "Error: You did not enter a valid number, please try again.";
            _logging.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegativeNumberError()
        {
            string errorMessage = "Error: You entered a negative number, please try again.";
            _logging.WriteToDatabase(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Convert(Func<double, double> serviceMethod, string inputType, string outputType)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                NoValidNumberError();
                goto end;
            }

            if (input < 0)
            {
                NegativeNumberError();
                goto end;
            }

            Func<double, double> convert = serviceMethod;
            double output = convert(input);
            _logging.WriteToDatabase($"{input} {inputType} to {output} {outputType}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = inputType;
            label_OutputType.Text = outputType;
        end:;
        }

        private void button_MeterToCentimeter_Click(object sender, EventArgs e)
        {
            Convert(_converterService.MeterToCentimeter, "m", "cm");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Input.Clear();
            label_Output.Text = "0";
        }

        private void button_CentimeterToMeter_Click(object sender, EventArgs e)
        {
            Convert(_converterService.CentimeterToMeter, "cm", "m");
        }

        private void button_CentimeterToMillimeter_Click(object sender, EventArgs e)
        {
            Convert(_converterService.CentimeterToMillimeter, "cm", "mm");
        }

        private void button_MillimeterToCentimeter_Click(object sender, EventArgs e)
        {
            Convert(_converterService.MillimeterToCentimeter, "mm", "cm");
        }

        private void button_MeterToInch_Click(object sender, EventArgs e)
        {
            Convert(_converterService.MeterToInch, "m", "in");
        }

        private void button_InchToMeter_Click(object sender, EventArgs e)
        {
            Convert(_converterService.InchToMeter, "in", "m");
        }
        #endregion
    }
}
