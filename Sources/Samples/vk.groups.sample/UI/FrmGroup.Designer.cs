namespace vk.groups.sample.UI
{
    partial class FrmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroup));
            this.gBGroups = new System.Windows.Forms.GroupBox();
            this.lvGroups = new System.Windows.Forms.ListView();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.cbxGroupsView = new System.Windows.Forms.ComboBox();
            this.tabGroup = new System.Windows.Forms.TabControl();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.tbReq = new System.Windows.Forms.TabPage();
            this.tbInvites = new System.Windows.Forms.TabPage();
            this.tbAdmins = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbBan = new System.Windows.Forms.TabPage();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbLinks = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            this.gBGroups.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.tbUsers.SuspendLayout();
            this.tbAdmins.SuspendLayout();
            this.tbBan.SuspendLayout();
            this.tbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gBGroups
            // 
            this.gBGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBGroups.Controls.Add(this.tabGroup);
            this.gBGroups.Location = new System.Drawing.Point(12, 12);
            this.gBGroups.Name = "gBGroups";
            this.gBGroups.Size = new System.Drawing.Size(500, 397);
            this.gBGroups.TabIndex = 2;
            this.gBGroups.TabStop = false;
            this.gBGroups.Text = "Managing";
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
            this.lvGroups.Location = new System.Drawing.Point(6, 32);
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(465, 249);
            this.lvGroups.TabIndex = 0;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            // 
            // ilImages
            // 
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "favicon.ico");
            // 
            // cbxGroupsView
            // 
            this.cbxGroupsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroupsView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroupsView.FormattingEnabled = true;
            this.cbxGroupsView.Items.AddRange(new object[] {
            "Large Icon",
            "List",
            "Small Icon",
            "Tile"});
            this.cbxGroupsView.Location = new System.Drawing.Point(330, 86);
            this.cbxGroupsView.Name = "cbxGroupsView";
            this.cbxGroupsView.Size = new System.Drawing.Size(141, 21);
            this.cbxGroupsView.TabIndex = 0;
            this.cbxGroupsView.SelectedIndexChanged += new System.EventHandler(this.cbxGroupsView_SelectedIndexChanged);
            // 
            // tabGroup
            // 
            this.tabGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGroup.Controls.Add(this.tbInfo);
            this.tabGroup.Controls.Add(this.tbUsers);
            this.tabGroup.Controls.Add(this.tbReq);
            this.tabGroup.Controls.Add(this.tbInvites);
            this.tabGroup.Controls.Add(this.tbAdmins);
            this.tabGroup.Controls.Add(this.tbBan);
            this.tabGroup.Controls.Add(this.tbLinks);
            this.tabGroup.Location = new System.Drawing.Point(9, 19);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.SelectedIndex = 0;
            this.tabGroup.Size = new System.Drawing.Size(485, 372);
            this.tabGroup.TabIndex = 2;
            // 
            // tbUsers
            // 
            this.tbUsers.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsers.Controls.Add(this.btn_Search);
            this.tbUsers.Controls.Add(this.txtSearch);
            this.tbUsers.Controls.Add(this.lvGroups);
            this.tbUsers.Location = new System.Drawing.Point(4, 22);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsers.Size = new System.Drawing.Size(477, 287);
            this.tbUsers.TabIndex = 0;
            this.tbUsers.Text = "Users";
            // 
            // tbReq
            // 
            this.tbReq.BackColor = System.Drawing.SystemColors.Control;
            this.tbReq.Location = new System.Drawing.Point(4, 22);
            this.tbReq.Name = "tbReq";
            this.tbReq.Padding = new System.Windows.Forms.Padding(3);
            this.tbReq.Size = new System.Drawing.Size(477, 287);
            this.tbReq.TabIndex = 1;
            this.tbReq.Text = "Requests";
            // 
            // tbInvites
            // 
            this.tbInvites.BackColor = System.Drawing.SystemColors.Control;
            this.tbInvites.Location = new System.Drawing.Point(4, 22);
            this.tbInvites.Name = "tbInvites";
            this.tbInvites.Size = new System.Drawing.Size(477, 287);
            this.tbInvites.TabIndex = 2;
            this.tbInvites.Text = "Invites";
            // 
            // tbAdmins
            // 
            this.tbAdmins.BackColor = System.Drawing.SystemColors.Control;
            this.tbAdmins.Controls.Add(this.button1);
            this.tbAdmins.Controls.Add(this.textBox2);
            this.tbAdmins.Location = new System.Drawing.Point(4, 22);
            this.tbAdmins.Name = "tbAdmins";
            this.tbAdmins.Size = new System.Drawing.Size(477, 287);
            this.tbAdmins.TabIndex = 3;
            this.tbAdmins.Text = "Admins";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(384, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // tbBan
            // 
            this.tbBan.BackColor = System.Drawing.SystemColors.Control;
            this.tbBan.Controls.Add(this.button2);
            this.tbBan.Controls.Add(this.textBox3);
            this.tbBan.Location = new System.Drawing.Point(4, 22);
            this.tbBan.Name = "tbBan";
            this.tbBan.Padding = new System.Windows.Forms.Padding(3);
            this.tbBan.Size = new System.Drawing.Size(477, 287);
            this.tbBan.TabIndex = 4;
            this.tbBan.Text = "Ban";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbInfo.Controls.Add(this.cbxGroupsView);
            this.tbInfo.Controls.Add(this.btnLeave);
            this.tbInfo.Controls.Add(this.label5);
            this.tbInfo.Controls.Add(this.label4);
            this.tbInfo.Controls.Add(this.label3);
            this.tbInfo.Controls.Add(this.label2);
            this.tbInfo.Controls.Add(this.label1);
            this.tbInfo.Controls.Add(this.picLogo);
            this.tbInfo.Location = new System.Drawing.Point(4, 22);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(477, 346);
            this.tbInfo.TabIndex = 5;
            this.tbInfo.Text = "Main info";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(396, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(396, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(6, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(396, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(6, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 20);
            this.textBox3.TabIndex = 5;
            // 
            // tbLinks
            // 
            this.tbLinks.Location = new System.Drawing.Point(4, 22);
            this.tbLinks.Name = "tbLinks";
            this.tbLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tbLinks.Size = new System.Drawing.Size(477, 287);
            this.tbLinks.TabIndex = 6;
            this.tbLinks.Text = "Links";
            this.tbLinks.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::vk.groups.sample.Properties.Resources.favicon_64x64;
            this.picLogo.Location = new System.Drawing.Point(6, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(96, 96);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total users: 00000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total requests: 00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Banned users: 00000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Admin users: 00000000";
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeave.Location = new System.Drawing.Point(378, 6);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(93, 23);
            this.btnLeave.TabIndex = 6;
            this.btnLeave.Text = "Leave group";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 421);
            this.Controls.Add(this.gBGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 460);
            this.Name = "FrmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<GroupName>";
            this.Load += new System.EventHandler(this.FrmGroup_Load);
            this.gBGroups.ResumeLayout(false);
            this.tabGroup.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
            this.tbUsers.PerformLayout();
            this.tbAdmins.ResumeLayout(false);
            this.tbAdmins.PerformLayout();
            this.tbBan.ResumeLayout(false);
            this.tbBan.PerformLayout();
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBGroups;
        private System.Windows.Forms.ListView lvGroups;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.ComboBox cbxGroupsView;
        private System.Windows.Forms.TabControl tabGroup;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.TabPage tbReq;
        private System.Windows.Forms.TabPage tbInvites;
        private System.Windows.Forms.TabPage tbAdmins;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tbBan;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tbLinks;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label label5;
    }
}