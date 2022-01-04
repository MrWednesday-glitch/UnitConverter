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
            Application.Exit();
        }
    }
}
