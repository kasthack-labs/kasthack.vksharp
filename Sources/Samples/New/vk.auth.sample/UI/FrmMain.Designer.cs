namespace vk.groups.sample.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.checkAgree = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lnkGH = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::vk.auth.sample.Properties.Resources.favicon_64x64;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(64, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(82, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(331, 140);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // checkAgree
            // 
            this.checkAgree.AutoSize = true;
            this.checkAgree.Location = new System.Drawing.Point(85, 155);
            this.checkAgree.Name = "checkAgree";
            this.checkAgree.Size = new System.Drawing.Size(298, 17);
            this.checkAgree.TabIndex = 2;
            this.checkAgree.Text = "С вышеуказанными пунктами согласен, продолжить.";
            this.checkAgree.UseVisualStyleBackColor = true;
            this.checkAgree.CheckedChanged += new System.EventHandler(this.checkAgree_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(85, 178);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(298, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "OK";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lnkGH
            // 
            this.lnkGH.AutoSize = true;
            this.lnkGH.Location = new System.Drawing.Point(9, 216);
            this.lnkGH.Name = "lnkGH";
            this.lnkGH.Size = new System.Drawing.Size(191, 13);
            this.lnkGH.TabIndex = 4;
            this.lnkGH.TabStop = true;
            this.lnkGH.Text = "https://github.com/kasthack/VKSharp";
            this.lnkGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGH_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 243);
            this.Controls.Add(this.lnkGH);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.checkAgree);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox checkAgree;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.LinkLabel lnkGH;
    }
}