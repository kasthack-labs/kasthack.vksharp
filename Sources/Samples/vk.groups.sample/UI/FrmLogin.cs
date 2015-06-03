using System;
using System.Windows.Forms;

namespace vk.groups.sample.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            txtUrl.Text = webBrowser.Url.ToString();
        }
    }
}
