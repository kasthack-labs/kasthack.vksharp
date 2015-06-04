using System.Diagnostics;
using System.Windows.Forms;

namespace vk.groups.sample.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lnkGH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kasthack/VKSharp");
        }

        private void checkAgree_CheckedChanged(object sender, System.EventArgs e)
        {
            btnNext.Enabled = checkAgree.Checked ;
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            var frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();

        }
    }
}
