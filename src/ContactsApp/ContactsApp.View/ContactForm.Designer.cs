namespace ContactsApp.View
{
    partial class ContactForm
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
            this.AddContactPanel = new System.Windows.Forms.Panel();
            this.AddPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.VkLabel = new System.Windows.Forms.Label();
            this.DateBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumbTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumbLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.OKCancelPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AddContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            this.OKCancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddContactPanel
            // 
            this.AddContactPanel.Controls.Add(this.OKCancelPanel);
            this.AddContactPanel.Controls.Add(this.AddPhotoButton);
            this.AddContactPanel.Controls.Add(this.VkTextBox);
            this.AddContactPanel.Controls.Add(this.VkLabel);
            this.AddContactPanel.Controls.Add(this.DateBirthTextBox);
            this.AddContactPanel.Controls.Add(this.DateBirthLabel);
            this.AddContactPanel.Controls.Add(this.PhoneNumbTextBox);
            this.AddContactPanel.Controls.Add(this.PhoneNumbLabel);
            this.AddContactPanel.Controls.Add(this.EmailTextBox);
            this.AddContactPanel.Controls.Add(this.EmailLabel);
            this.AddContactPanel.Controls.Add(this.FullNameTextBox);
            this.AddContactPanel.Controls.Add(this.FullNameLabel);
            this.AddContactPanel.Controls.Add(this.AddPhotoPictureBox);
            this.AddContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactPanel.Location = new System.Drawing.Point(0, 0);
            this.AddContactPanel.Name = "AddContactPanel";
            this.AddContactPanel.Size = new System.Drawing.Size(524, 351);
            this.AddContactPanel.TabIndex = 0;
            // 
            // AddPhotoPictureBox
            // 
            this.AddPhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.AddPhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AddPhotoPictureBox.Name = "AddPhotoPictureBox";
            this.AddPhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.AddPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoPictureBox.TabIndex = 0;
            this.AddPhotoPictureBox.TabStop = false;
            // 
            // VkTextBox
            // 
            this.VkTextBox.Location = new System.Drawing.Point(109, 263);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(175, 20);
            this.VkTextBox.TabIndex = 20;
            // 
            // VkLabel
            // 
            this.VkLabel.AutoSize = true;
            this.VkLabel.Location = new System.Drawing.Point(109, 247);
            this.VkLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(24, 13);
            this.VkLabel.TabIndex = 19;
            this.VkLabel.Text = "VK:";
            // 
            // DateBirthTextBox
            // 
            this.DateBirthTextBox.Location = new System.Drawing.Point(109, 202);
            this.DateBirthTextBox.Name = "DateBirthTextBox";
            this.DateBirthTextBox.Size = new System.Drawing.Size(175, 20);
            this.DateBirthTextBox.TabIndex = 18;
            // 
            // DateBirthLabel
            // 
            this.DateBirthLabel.AutoSize = true;
            this.DateBirthLabel.Location = new System.Drawing.Point(109, 186);
            this.DateBirthLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.DateBirthLabel.Name = "DateBirthLabel";
            this.DateBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateBirthLabel.TabIndex = 17;
            this.DateBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumbTextBox
            // 
            this.PhoneNumbTextBox.Location = new System.Drawing.Point(109, 141);
            this.PhoneNumbTextBox.Name = "PhoneNumbTextBox";
            this.PhoneNumbTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneNumbTextBox.TabIndex = 16;
            this.PhoneNumbTextBox.Text = "+7 (999) 777-77-77";
            // 
            // PhoneNumbLabel
            // 
            this.PhoneNumbLabel.AutoSize = true;
            this.PhoneNumbLabel.Location = new System.Drawing.Point(109, 125);
            this.PhoneNumbLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.PhoneNumbLabel.Name = "PhoneNumbLabel";
            this.PhoneNumbLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumbLabel.TabIndex = 15;
            this.PhoneNumbLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 80);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(403, 20);
            this.EmailTextBox.TabIndex = 14;
            this.EmailTextBox.Text = "makar@mail.ru";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(109, 64);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(109, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(403, 20);
            this.FullNameTextBox.TabIndex = 12;
            this.FullNameTextBox.Text = "Макаров Богдан Захарович";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(109, 3);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 11;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(37, 106);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 21;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // OKCancelPanel
            // 
            this.OKCancelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.OKCancelPanel.Controls.Add(this.OkButton);
            this.OKCancelPanel.Controls.Add(this.CancelButton);
            this.OKCancelPanel.Location = new System.Drawing.Point(0, 306);
            this.OKCancelPanel.Name = "OKCancelPanel";
            this.OKCancelPanel.Size = new System.Drawing.Size(524, 45);
            this.OKCancelPanel.TabIndex = 22;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(437, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(356, 10);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 351);
            this.Controls.Add(this.AddContactPanel);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.AddContactPanel.ResumeLayout(false);
            this.AddContactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            this.OKCancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddContactPanel;
        private System.Windows.Forms.PictureBox AddPhotoPictureBox;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox DateBirthTextBox;
        private System.Windows.Forms.Label DateBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumbTextBox;
        private System.Windows.Forms.Label PhoneNumbLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox AddPhotoButton;
        private System.Windows.Forms.Panel OKCancelPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}