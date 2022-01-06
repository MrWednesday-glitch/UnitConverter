using System;
using System.Windows.Forms;
using UnitConverter.Business;
using UnitConverter.Common;

namespace UnitConverter.Winforms
{//TODO make 5 more subforms for the other buttons
    public partial class Overview : Form
    {
        private readonly ConverterService _converterService;
        private readonly Logging _logging;

        public Overview()
        {
            InitializeComponent();
            _converterService = new ConverterService();
            _logging = new Logging();
        }

        private void button_MeterToCentimeter_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.MeterToCentimeter(input);
            _logging.WriteToLogFile($"{input} meter to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "m";
            label_OutputType.Text = "cm";
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
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.CentimeterToMeter(input);
            _logging.WriteToLogFile($"{input} centimeter to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "cm";
            label_OutputType.Text = "m";
        }

        private void button_CentimeterToMillimeter_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.CentimeterToMillimeter(input);
            _logging.WriteToLogFile($"{input} centimeter to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "cm";
            label_OutputType.Text = "mm";
        }

        private void button_MillimeterToCentimeter_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.MillimeterToCentimeter(input);
            _logging.WriteToLogFile($"{input} millimeter to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "mm";
            label_OutputType.Text = "cm";
        }

        private void button_MeterToInch_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.MeterToInch(input);
            _logging.WriteToLogFile($"{input} meter to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "m";
            label_OutputType.Text = "in";
        }

        private void button_InchToMeter_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(textBox_Input.Text, out double input);
            if (!success)
            {
                string errorMessage = "Error: You did not enter a valid number, please try again.";
                _logging.WriteToLogFile(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double output = _converterService.InchToMeter(input);
            _logging.WriteToLogFile($"{input} inch to {output}.");
            label_Output.Text = output.ToString();
            label_InputType.Text = "in";
            label_OutputType.Text = "m";
        }
    }
}
