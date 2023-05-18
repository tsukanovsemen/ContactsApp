using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    /// <summary>
    /// Класс, описывающий главное окно.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса Project.
        /// </summary>
        public Project Project { get; private set; }

        /// <summary>
        /// Список текущих контактов.
        /// </summary>
        public List<Contact> CurrentContacts { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref = "MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Project = ProjectManager.LoadProject();
            UpdateCurrentContacts();
            CurrentContacts = Project.SortContactsByName(CurrentContacts);
            UpdateListBox();
            UpdatePanelBirthdayContacts();
        }

        /// <summary>
        /// Обновление списка контактов в главном окне.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (Contact contact in CurrentContacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Добавление нового контакта.
        /// </summary>
        private void AddContact(Contact contact)
        {
            Project.Contacts.Add(contact);
            UpdateCurrentContacts();
            CurrentContacts = Project.SortContactsByName(CurrentContacts);
        }

        /// <summary>
        /// Удаление выбранного контакта.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта.</param>
        private void RemoveContact(int index)
        {
            ContactsListBox.Items.RemoveAt(index);
            Project.Contacts.Remove(CurrentContacts[index]);
        }

        /// <summary>
        /// Обновляет правую панель главного окна, в зависимости от выбранного контакта.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта.</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
            }
            else
            {
                Contact contact = CurrentContacts[index];
                FillSelectedContact(contact);
            }
        }

        /// <summary>
        /// Обновляет выбранный контакт.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        private void FillSelectedContact(Contact contact)
        {
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumbTextBox.Text = contact.PhoneNumber;
            string date = contact.DateOfBirth.Year.ToString() + "." +
                contact.DateOfBirth.Month.ToString() + "." +
                contact.DateOfBirth.Day.ToString();
            DateBirthTextBox.Text = date;
            VKTextBox.Text = contact.IdVK;
        }

        /// <summary>
        /// Очищает правую панель окна.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            PhoneNumbTextBox.Text = string.Empty;
            DateBirthTextBox.Text = string.Empty;
            VKTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Редактирование контакта по заданному индексу.
        /// </summary>
        /// <param name="index">Индекс редактируемого контакта.</param>
        private void EditContact(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index of chosen contact must be greater then 0.");
            }

            var form = new ContactForm((Contact)CurrentContacts[index].Clone());
            form.ShowDialog();
            var editedContact = form.Contact;

            if (editedContact != null)
            {
                int indexProjectContact = Project.Contacts.IndexOf(CurrentContacts[index]);
                Project.Contacts.Remove(CurrentContacts[index]);
                Project.Contacts.Insert(indexProjectContact, editedContact);
            }
        }

        /// <summary>
        /// Обновление текущих контактов в зависимости от запроса поиска.
        /// </summary>
        public void UpdateCurrentContacts()
        {
            CurrentContacts =
                Project.FindContactsBySubstring(Project.Contacts, FindContactTextBox.Text);
        }

        /// <summary>
        /// Добавление панели именинников.
        /// </summary>
        public void UpdatePanelBirthdayContacts()
        {
            string birthdayContactsNames = "";

            List<Contact> birthdayContacts = Project.FindBirthdayContacts(Project.Contacts);

            if (birthdayContacts == null)
            {
                BirthdayPanel.Visible = false;
                return;
            }
            BirthdayPanel.Visible = true;
            foreach (Contact contact in birthdayContacts)
            {
                birthdayContactsNames += contact.FullName;
            }

            BirthdayContactLabel.Text = birthdayContactsNames;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneNumbTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        private void AddContactButton_MouseEnter_1(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddContactButton_MouseLeave_1(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
            var newContact = form.Contact;
            if (newContact != null)
            {
                AddContact(newContact);
                UpdatePanelBirthdayContacts();
                UpdateListBox();
                ProjectManager.SaveProject(Project);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            string message = "Do you really want to remove " +
                             ContactsListBox.Items[index] + "?";
            string title = "Caution!";

            if (MessageBox.Show(message, title, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveContact(index);
                UpdateCurrentContacts();
                CurrentContacts = Project.SortContactsByName(CurrentContacts);
                UpdatePanelBirthdayContacts();
                UpdateListBox();
                ProjectManager.SaveProject(Project);
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            int indexEditedContact = ContactsListBox.SelectedIndex;
            try
            {
                EditContact(indexEditedContact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            UpdateCurrentContacts();
            CurrentContacts = Project.SortContactsByName(CurrentContacts);
            UpdateListBox();
            UpdatePanelBirthdayContacts();
            UpdateSelectedContact(indexEditedContact);
            ProjectManager.SaveProject(Project);
        }

        private void FindContactTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentContacts =
                Project.FindContactsBySubstring(Project.Contacts, FindContactTextBox.Text);
            UpdateListBox();
            CurrentContacts = Project.SortContactsByName(CurrentContacts);
        }

        private void CloseReminderButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveProject(Project);
        }
    }
}
