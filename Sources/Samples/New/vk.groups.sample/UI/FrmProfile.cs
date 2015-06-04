using System;
using System.Windows.Forms;

namespace vk.groups.sample.UI
{
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            cbxGroupsView.SelectedIndex = 0;
        }

        private void cbxGroupsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxGroupsView.SelectedIndex)
            {
                case 0:
                    lvGroups.View = View.LargeIcon;
                    break;
                case 1:
                    lvGroups.View = View.List;
                    break;
                case 2:
                    lvGroups.View = View.SmallIcon;
                    break;
                case 3:
                    lvGroups.View = View.Tile;
                    break;
            }
        }
    }
}