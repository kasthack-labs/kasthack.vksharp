namespace vk.auth.sample.UI
{
    partial class FrmPerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerm));
            this.clPerm = new System.Windows.Forms.CheckedListBox();
            this.rbPerm = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clPerm
            // 
            this.clPerm.FormattingEnabled = true;
            this.clPerm.Items.AddRange(new object[] {
            " Ads = 1<<1,",
            "Audio = 1 << 2,",
            "Docs = 1 << 3,",
            "Friends = 1 << 4,",
            "Groups = 1 << 5,",
            "Messages = 1 << 6,",
            "Notes = 1 << 8,",
            "Notifications = 1 << 9,",
            "Notify = 1 << 10,",
            "Offers = 1 << 11,",
            "Offline = 1 << 12,",
            "Pages = 1 << 13,",
            "Photos = 1 << 14,",
            "Questions = 1 << 15,",
            "Stats = 1 << 16,",
            "Status = 1 << 17,",
            "Video = 1 << 18,",
            "Wall = 1 << 19,",
            "Everything = ~0,"});
            this.clPerm.Location = new System.Drawing.Point(26, 35);
            this.clPerm.Name = "clPerm";
            this.clPerm.Size = new System.Drawing.Size(320, 184);
            this.clPerm.TabIndex = 0;
            // 
            // rbPerm
            // 
            this.rbPerm.AutoSize = true;
            this.rbPerm.Checked = true;
            this.rbPerm.Location = new System.Drawing.Point(12, 12);
            this.rbPerm.Name = "rbPerm";
            this.rbPerm.Size = new System.Drawing.Size(108, 17);
            this.rbPerm.TabIndex = 1;
            this.rbPerm.TabStop = true;
            this.rbPerm.Text = "Selected from list:";
            this.rbPerm.UseVisualStyleBackColor = true;
            this.rbPerm.CheckedChanged += new System.EventHandler(this.rbPerm_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(12, 227);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 1;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(271, 248);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // FrmPerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 283);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbPerm);
            this.Controls.Add(this.clPerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.FrmPerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clPerm;
        private System.Windows.Forms.RadioButton rbPerm;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Button btnNext;
    }
}