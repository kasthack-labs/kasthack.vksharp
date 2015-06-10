namespace vk.groups.sample.UI
{
    partial class FrmBanedit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGroupsView = new System.Windows.Forms.ComboBox();
            this.picAva = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Added by Anton Semenoff Jul 18, 2013 at 3:16 pm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dmitri Ivanoff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Block for";
            // 
            // cbxGroupsView
            // 
            this.cbxGroupsView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroupsView.FormattingEnabled = true;
            this.cbxGroupsView.Items.AddRange(new object[] {
            "Forever",
            "A year",
            "A month",
            "A week",
            "A day",
            "An hour"});
            this.cbxGroupsView.Location = new System.Drawing.Point(114, 87);
            this.cbxGroupsView.Name = "cbxGroupsView";
            this.cbxGroupsView.Size = new System.Drawing.Size(141, 21);
            this.cbxGroupsView.TabIndex = 7;
            // 
            // picAva
            // 
            this.picAva.Location = new System.Drawing.Point(12, 12);
            this.picAva.Name = "picAva";
            this.picAva.Size = new System.Drawing.Size(96, 96);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAva.TabIndex = 0;
            this.picAva.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Other",
            "Spam",
            "Verbal abuse",
            "Strong language",
            "Irrelevant messages"});
            this.comboBox1.Location = new System.Drawing.Point(261, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 20);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(215, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show this comment to the blocked user ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Unblock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmBanedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 211);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGroupsView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBanedit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit ban";
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Icon = Program.AppIcon;
        }

        #endregion

        private System.Windows.Forms.PictureBox picAva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGroupsView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}