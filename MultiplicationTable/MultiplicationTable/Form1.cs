using System;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class FrmMultiTables : Form
    {
        public FrmMultiTables()
        {
            InitializeComponent();
            txtTable.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var intNumber = int.Parse(txtNum.Text);
            var i = 0;

            while (i < 12)
            {
                i = i + 1;
                var intTimes = intNumber * i;
                txtTable.AppendText(intNumber + @"*" + i + @"=" + intTimes + '\n');
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
