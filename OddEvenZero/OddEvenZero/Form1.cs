using System;
using System.Windows.Forms;

namespace OddEvenZero
{
    public partial class FrmOddEvenZero : Form
    {
        public FrmOddEvenZero()
        {
            InitializeComponent();

            txtOutput.ReadOnly = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var intNumber = int.Parse(txtNumber.Text);
            const string strZero = "You entered zero!";
            const string strPositive = "You entered an even number!";
            const string strNegative = "You entered an odd number!";

            if (intNumber == 0)
            {
                txtOutput.Text = strZero;
            }
            else if (intNumber % 2 == 0)
            {
                txtOutput.Text = strPositive;
            }
            else
            {
                txtOutput.Text = strNegative;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
