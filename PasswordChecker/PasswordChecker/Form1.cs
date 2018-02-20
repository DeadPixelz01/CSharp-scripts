using System;
using System.Windows.Forms;

namespace PasswordChecker
{
    public partial class FrmPasswordCheck : Form
    {
        public FrmPasswordCheck()
        {
            InitializeComponent();

            txtCompPass.ReadOnly = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string strLoginSuccess = "Success!";
            const string strLoginFail = "Failed, try agian!";
            var strUsrPass = txtUsrPass.Text;
            const string strCompPass = "12345";

            txtCompPass.Text = strUsrPass == strCompPass ? strLoginSuccess : strLoginFail;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
