using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitConverter.Winforms.Subforms;

namespace UnitConverter.Winforms
{//TODO make 5 more subforms for the other buttons
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void button_MeterToCentimeter_Click(object sender, EventArgs e)
        {
            MeterToCentimeter formMToCm = new MeterToCentimeter();
            formMToCm.ShowDialog();
            //this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
