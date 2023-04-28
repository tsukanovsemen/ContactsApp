namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FunctionalPanel = new System.Windows.Forms.Panel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContactButton = new System.Windows.Forms.PictureBox();
            this.EditContactButton = new System.Windows.Forms.PictureBox();
            this.AddContactButton = new System.Windows.Forms.PictureBox();
            this.FindContactLabel = new System.Windows.Forms.Label();
            this.FindContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.PersonInfoPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.CloseReminderButton = new System.Windows.Forms.Button();
            this.BirthdayBoyLabel = new System.Windows.Forms.Label();
            this.BirthdayTextLabel = new System.Windows.Forms.Label();
            this.InfoBirthPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumbTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumbLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.FunctionalPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
            this.PersonInfoPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBirthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.FunctionalPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.PersonInfoPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // FunctionalPanel
            // 
            this.FunctionalPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.FunctionalPanel.Controls.Add(this.FindContactLabel);
            this.FunctionalPanel.Controls.Add(this.FindContactTextBox);
            this.FunctionalPanel.Controls.Add(this.ContactsListBox);
            this.FunctionalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionalPanel.Location = new System.Drawing.Point(3, 3);
            this.FunctionalPanel.Name = "FunctionalPanel";
            this.FunctionalPanel.Size = new System.Drawing.Size(244, 444);
            this.FunctionalPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 406);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(158, 0);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(80, 35);
            this.RemoveContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.TabStop = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            this.RemoveContactButton.MouseEnter += new System.EventHandler(this.RemoveContactButton_MouseEnter);
            this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(79, 0);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(79, 35);
            this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactButton.TabIndex = 3;
            this.EditContactButton.TabStop = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(79, 35);
            this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactButton.TabIndex = 4;
            this.AddContactButton.TabStop = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter_1);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave_1);
            // 
            // FindContactLabel
            // 
            this.FindContactLabel.AutoSize = true;
            this.FindContactLabel.Location = new System.Drawing.Point(3, 6);
            this.FindContactLabel.Name = "FindContactLabel";
            this.FindContactLabel.Size = new System.Drawing.Size(30, 13);
            this.FindContactLabel.TabIndex = 2;
            this.FindContactLabel.Text = "Find:";
            // 
            // FindContactTextBox
            // 
            this.FindContactTextBox.Location = new System.Drawing.Point(39, 3);
            this.FindContactTextBox.Name = "FindContactTextBox";
            this.FindContactTextBox.Size = new System.Drawing.Size(202, 20);
            this.FindContactTextBox.TabIndex = 1;
            this.FindContactTextBox.TextChanged += new System.EventHandler(this.FindContactTextBox_TextChanged);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 29);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 377);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // PersonInfoPanel
            // 
            this.PersonInfoPanel.Controls.Add(this.BirthdayPanel);
            this.PersonInfoPanel.Controls.Add(this.VKTextBox);
            this.PersonInfoPanel.Controls.Add(this.VKLabel);
            this.PersonInfoPanel.Controls.Add(this.DateBirthTextBox);
            this.PersonInfoPanel.Controls.Add(this.DateBirthLabel);
            this.PersonInfoPanel.Controls.Add(this.PhoneNumbTextBox);
            this.PersonInfoPanel.Controls.Add(this.PhoneNumbLabel);
            this.PersonInfoPanel.Controls.Add(this.EmailTextBox);
            this.PersonInfoPanel.Controls.Add(this.EmailLabel);
            this.PersonInfoPanel.Controls.Add(this.FullNameTextBox);
            this.PersonInfoPanel.Controls.Add(this.FullNameLabel);
            this.PersonInfoPanel.Controls.Add(this.PhotoPictureBox);
            this.PersonInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonInfoPanel.Location = new System.Drawing.Point(253, 3);
            this.PersonInfoPanel.Name = "PersonInfoPanel";
            this.PersonInfoPanel.Size = new System.Drawing.Size(544, 444);
            this.PersonInfoPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.CloseReminderButton);
            this.BirthdayPanel.Controls.Add(this.BirthdayBoyLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayTextLabel);
            this.BirthdayPanel.Controls.Add(this.InfoBirthPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 369);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(538, 75);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // CloseReminderButton
            // 
            this.CloseReminderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseReminderButton.FlatAppearance.BorderSize = 0;
            this.CloseReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseReminderButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.CloseReminderButton.Location = new System.Drawing.Point(503, 3);
            this.CloseReminderButton.Name = "CloseReminderButton";
            this.CloseReminderButton.Size = new System.Drawing.Size(32, 32);
            this.CloseReminderButton.TabIndex = 3;
            this.CloseReminderButton.UseVisualStyleBackColor = true;
            this.CloseReminderButton.Click += new System.EventHandler(this.CloseReminderButton_Click);
            // 
            // BirthdayBoyLabel
            // 
            this.BirthdayBoyLabel.AutoSize = true;
            this.BirthdayBoyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayBoyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayBoyLabel.Location = new System.Drawing.Point(82, 40);
            this.BirthdayBoyLabel.Name = "BirthdayBoyLabel";
            this.BirthdayBoyLabel.Size = new System.Drawing.Size(201, 13);
            this.BirthdayBoyLabel.TabIndex = 2;
            this.BirthdayBoyLabel.Text = "Абакумов, Петров, Иванов и др.";
            // 
            // BirthdayTextLabel
            // 
            this.BirthdayTextLabel.AutoSize = true;
            this.BirthdayTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayTextLabel.Location = new System.Drawing.Point(82, 24);
            this.BirthdayTextLabel.Name = "BirthdayTextLabel";
            this.BirthdayTextLabel.Size = new System.Drawing.Size(124, 13);
            this.BirthdayTextLabel.TabIndex = 1;
            this.BirthdayTextLabel.Text = "Today is Birthday of:";
            // 
            // InfoBirthPictureBox
            // 
            this.InfoBirthPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoBirthPictureBox.Location = new System.Drawing.Point(3, 3);
            this.InfoBirthPictureBox.Name = "InfoBirthPictureBox";
            this.InfoBirthPictureBox.Size = new System.Drawing.Size(73, 69);
            this.InfoBirthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoBirthPictureBox.TabIndex = 0;
            this.InfoBirthPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(109, 266);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 20);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VkTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(109, 250);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateBirthTextBox
            // 
            this.DateBirthTextBox.Location = new System.Drawing.Point(109, 205);
            this.DateBirthTextBox.Name = "DateBirthTextBox";
            this.DateBirthTextBox.Size = new System.Drawing.Size(175, 20);
            this.DateBirthTextBox.TabIndex = 8;
            this.DateBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateBirthTextBox_KeyPress);
            // 
            // DateBirthLabel
            // 
            this.DateBirthLabel.AutoSize = true;
            this.DateBirthLabel.Location = new System.Drawing.Point(109, 189);
            this.DateBirthLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.DateBirthLabel.Name = "DateBirthLabel";
            this.DateBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateBirthLabel.TabIndex = 7;
            this.DateBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumbTextBox
            // 
            this.PhoneNumbTextBox.Location = new System.Drawing.Point(109, 144);
            this.PhoneNumbTextBox.Name = "PhoneNumbTextBox";
            this.PhoneNumbTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneNumbTextBox.TabIndex = 6;
            this.PhoneNumbTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumbTextBox_KeyPress);
            // 
            // PhoneNumbLabel
            // 
            this.PhoneNumbLabel.AutoSize = true;
            this.PhoneNumbLabel.Location = new System.Drawing.Point(109, 128);
            this.PhoneNumbLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.PhoneNumbLabel.Name = "PhoneNumbLabel";
            this.PhoneNumbLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumbLabel.TabIndex = 5;
            this.PhoneNumbLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 83);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(432, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(109, 67);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 22, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(109, 22);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(432, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(109, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.FunctionalPanel.ResumeLayout(false);
            this.FunctionalPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
            this.PersonInfoPanel.ResumeLayout(false);
            this.PersonInfoPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBirthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel FunctionalPanel;
        private System.Windows.Forms.Label FindContactLabel;
        private System.Windows.Forms.TextBox FindContactTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Panel PersonInfoPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox DateBirthTextBox;
        private System.Windows.Forms.Label DateBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumbTextBox;
        private System.Windows.Forms.Label PhoneNumbLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.PictureBox InfoBirthPictureBox;
        private System.Windows.Forms.Button CloseReminderButton;
        private System.Windows.Forms.Label BirthdayBoyLabel;
        private System.Windows.Forms.Label BirthdayTextLabel;
        private System.Windows.Forms.PictureBox RemoveContactButton;
        private System.Windows.Forms.PictureBox EditContactButton;
        private System.Windows.Forms.PictureBox AddContactButton;
    }
}

