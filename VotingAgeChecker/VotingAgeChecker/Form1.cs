using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingAgeChecker
{
    public partial class FrmVote : Form
    {
        public FrmVote()
        {
            InitializeComponent();
            txtOutput.ReadOnly = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const string strNoVote = "Sorry, but you cannot vote!";
            const string strYesVote = "Yes, you can vote!";
            var intAge = int.Parse(txtAge.Text);

            txtOutput.Text = intAge >= 18 ? strYesVote : strNoVote;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
