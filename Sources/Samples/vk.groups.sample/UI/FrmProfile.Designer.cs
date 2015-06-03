namespace vk.groups.sample.UI
{
    partial class FrmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.gBGroups = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvGroups = new System.Windows.Forms.ListView();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.gBsettings = new System.Windows.Forms.GroupBox();
            this.cbxGroupsView = new System.Windows.Forms.ComboBox();
            this.gbProfile.SuspendLayout();
            this.gBGroups.SuspendLayout();
            this.gBsettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfile
            // 
            this.gbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProfile.Controls.Add(this.lblUser);
            this.gbProfile.Location = new System.Drawing.Point(12, 12);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(278, 53);
            this.gbProfile.TabIndex = 0;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profile";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(6, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Dmitri Ivanoff";
            // 
            // gBGroups
            // 
            this.gBGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBGroups.Controls.Add(this.txtSearch);
            this.gBGroups.Controls.Add(this.lvGroups);
            this.gBGroups.Location = new System.Drawing.Point(12, 71);
            this.gBGroups.Name = "gBGroups";
            this.gBGroups.Size = new System.Drawing.Size(500, 338);
            this.gBGroups.TabIndex = 0;
            this.gBGroups.TabStop = false;
            this.gBGroups.Text = "Groups you are managed";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(9, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(485, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lvGroups
            // 
            this.lvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGroups.BackColor = System.Drawing.SystemColors.Control;
            this.lvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGroups.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvGroups.LargeImageList = this.ilImages;
            this.lvGroups.Location = new System.Drawing.Point(6, 45);
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(488, 287);
            this.lvGroups.TabIndex = 0;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            // 
            // ilImages
            // 
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "favicon.ico");
            // 
            // gBsettings
            // 
            this.gBsettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBsettings.Controls.Add(this.cbxGroupsView);
            this.gBsettings.Location = new System.Drawing.Point(296, 12);
            this.gBsettings.Name = "gBsettings";
            this.gBsettings.Size = new System.Drawing.Size(216, 53);
            this.gBsettings.TabIndex = 0;
            this.gBsettings.TabStop = false;
            this.gBsettings.Text = "View";
            // 
            // cbxGroupsView
            // 
            this.cbxGroupsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroupsView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroupsView.FormattingEnabled = true;
            this.cbxGroupsView.Items.AddRange(new object[] {
            "Large Icon",
            "List",
            "Small Icon",
            "Tile"});
            this.cbxGroupsView.Location = new System.Drawing.Point(6, 19);
            this.cbxGroupsView.Name = "cbxGroupsView";
            this.cbxGroupsView.Size = new System.Drawing.Size(204, 21);
            this.cbxGroupsView.TabIndex = 0;
            this.cbxGroupsView.SelectedIndexChanged += new System.EventHandler(this.cbxGroupsView_SelectedIndexChanged);
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 421);
            this.Controls.Add(this.gBGroups);
            this.Controls.Add(this.gBsettings);
            this.Controls.Add(this.gbProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 460);
            this.Name = "FrmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.gBGroups.ResumeLayout(false);
            this.gBGroups.PerformLayout();
            this.gBsettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.GroupBox gBGroups;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ListView lvGroups;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.GroupBox gBsettings;
        private System.Windows.Forms.ComboBox cbxGroupsView;
        private System.Windows.Forms.TextBox txtSearch;
    }
}