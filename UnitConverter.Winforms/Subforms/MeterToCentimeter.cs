using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitConverter.Business;

namespace UnitConverter.Winforms.Subforms
{
    public partial class MeterToCentimeter : Form
    {
        private readonly ConverterService _converterService;

        public MeterToCentimeter()
        {
            InitializeComponent();
            _converterService = new ConverterService();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label_Output_Click(object sender, EventArgs e)
        {

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Input.Clear();
            label_Output.Text = "0";
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox_Input.Text, out double input);
            double output = _converterService.MeterToCentimeter(input);
            label_Output.Text = output.ToString();
        }

        private void MeterToCentimeter_Load(object sender, EventArgs e)
        {

        }
    }
}
