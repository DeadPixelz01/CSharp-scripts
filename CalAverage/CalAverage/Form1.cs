using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalAverage
{
    public partial class FrmCalAverage : Form
    {
        public FrmCalAverage()
        {
            InitializeComponent();

            txtAverage.ReadOnly = true;
        }

        

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            int intNum1 = int.Parse(txtNum1.Text);
            int intNum2 = int.Parse(txtNum2.Text);
            int intNum3 = int.Parse(txtNum3.Text);

            int intAverageNum = intNum1 + intNum2 + intNum3 / 3;

            txtAverage.Text = intAverageNum.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
