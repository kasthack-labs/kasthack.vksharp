using System;
using System.Windows.Forms;

namespace vk.auth.sample.UI
{
    public partial class FrmPerm : Form
    {
        public FrmPerm()
        {
            InitializeComponent();
        }

        private void rbPerm_CheckedChanged(object sender, EventArgs e)
        { 
            CheckRb();
        }

        private void CheckRb()
        {
            clPerm.Enabled = rbPerm.Checked | !rbNone.Checked;
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            CheckRb();
        }

        private void FrmPerm_Load(object sender, EventArgs e)
        {

        }
    }
}
