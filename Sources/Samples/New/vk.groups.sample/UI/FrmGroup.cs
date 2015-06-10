using System;
using System.Windows.Forms;

namespace vk.groups.sample.UI
{
    public partial class FrmGroup : Form
    {
        public FrmGroup()
        {
            InitializeComponent();
        }

        private void FrmGroup_Load(object sender, EventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
