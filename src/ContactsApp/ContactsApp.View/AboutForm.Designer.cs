namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutFormPanel = new System.Windows.Forms.Panel();
            this.Image8LinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AllUsedImageLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NameAppLabel = new System.Windows.Forms.Label();
            this.OKPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.LicenseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AboutFormPanel.SuspendLayout();
            this.OKPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutFormPanel
            // 
            this.AboutFormPanel.Controls.Add(this.Image8LinkLabel);
            this.AboutFormPanel.Controls.Add(this.GitHubLinkLabel);
            this.AboutFormPanel.Controls.Add(this.AllUsedImageLabel);
            this.AboutFormPanel.Controls.Add(this.MailLabel);
            this.AboutFormPanel.Controls.Add(this.NameLabel);
            this.AboutFormPanel.Controls.Add(this.GitHubLabel);
            this.AboutFormPanel.Controls.Add(this.EmailLabel);
            this.AboutFormPanel.Controls.Add(this.AuthorLabel);
            this.AboutFormPanel.Controls.Add(this.VersionLabel);
            this.AboutFormPanel.Controls.Add(this.NameAppLabel);
            this.AboutFormPanel.Controls.Add(this.OKPanel);
            this.AboutFormPanel.Controls.Add(this.LicenseRichTextBox);
            this.AboutFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutFormPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutFormPanel.Name = "AboutFormPanel";
            this.AboutFormPanel.Size = new System.Drawing.Size(524, 401);
            this.AboutFormPanel.TabIndex = 0;
            // 
            // Image8LinkLabel
            // 
            this.Image8LinkLabel.AutoSize = true;
            this.Image8LinkLabel.Location = new System.Drawing.Point(203, 333);
            this.Image8LinkLabel.Name = "Image8LinkLabel";
            this.Image8LinkLabel.Size = new System.Drawing.Size(102, 13);
            this.Image8LinkLabel.TabIndex = 13;
            this.Image8LinkLabel.TabStop = true;
            this.Image8LinkLabel.Text = "https://icons8.com/";
            this.Image8LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Image8LinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(124, 114);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(175, 13);
            this.GitHubLinkLabel.TabIndex = 12;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/tsukanovsemen";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // AllUsedImageLabel
            // 
            this.AllUsedImageLabel.AutoSize = true;
            this.AllUsedImageLabel.Location = new System.Drawing.Point(12, 333);
            this.AllUsedImageLabel.Name = "AllUsedImageLabel";
            this.AllUsedImageLabel.Size = new System.Drawing.Size(185, 13);
            this.AllUsedImageLabel.TabIndex = 10;
            this.AllUsedImageLabel.Text = "All used images are downloaded from:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(124, 93);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(108, 13);
            this.MailLabel.TabIndex = 8;
            this.MailLabel.Text = "apple.semen@mail.ru";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(124, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Semyon Tsukanov";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(12, 114);
            this.GitHubLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(43, 13);
            this.GitHubLabel.TabIndex = 6;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 93);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "E-mail:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 72);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 46);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 13);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "v 1.0";
            // 
            // NameAppLabel
            // 
            this.NameAppLabel.AutoSize = true;
            this.NameAppLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAppLabel.Location = new System.Drawing.Point(9, 3);
            this.NameAppLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NameAppLabel.Name = "NameAppLabel";
            this.NameAppLabel.Size = new System.Drawing.Size(190, 36);
            this.NameAppLabel.TabIndex = 2;
            this.NameAppLabel.Text = "ContactsApp";
            // 
            // OKPanel
            // 
            this.OKPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.OKPanel.Controls.Add(this.OKButton);
            this.OKPanel.Location = new System.Drawing.Point(0, 355);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(524, 45);
            this.OKPanel.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(437, 11);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LicenseRichTextBox
            // 
            this.LicenseRichTextBox.Location = new System.Drawing.Point(12, 152);
            this.LicenseRichTextBox.Name = "LicenseRichTextBox";
            this.LicenseRichTextBox.Size = new System.Drawing.Size(500, 178);
            this.LicenseRichTextBox.TabIndex = 0;
            this.LicenseRichTextBox.Text = resources.GetString("LicenseRichTextBox.Text");
            this.LicenseRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseRichTextBox_KeyPress);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 401);
            this.Controls.Add(this.AboutFormPanel);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.AboutFormPanel.ResumeLayout(false);
            this.AboutFormPanel.PerformLayout();
            this.OKPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AboutFormPanel;
        private System.Windows.Forms.Panel OKPanel;
        private System.Windows.Forms.RichTextBox LicenseRichTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label NameAppLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label AllUsedImageLabel;
        private System.Windows.Forms.LinkLabel Image8LinkLabel;
        private System.Windows.Forms.Button OKButton;
    }
}