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
        public Project Project { get; private set; } = new Project();

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
            UpdateCurrentContacts();
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
                FullNameTextBox.Text = CurrentContacts[index].FullName;
                EmailTextBox.Text = CurrentContacts[index].Email;
                PhoneNumbTextBox.Text = CurrentContacts[index].PhoneNumber;
                string date = CurrentContacts[index].DateOfBirth.Year.ToString() + "." +
                    CurrentContacts[index].DateOfBirth.Month.ToString() + "." +
                    CurrentContacts[index].DateOfBirth.Day.ToString();
                DateBirthTextBox.Text = date;
                VKTextBox.Text = CurrentContacts[index].IdVK;
            }
        }

        /// <summary>
        /// Очищает правую панель окна.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumbTextBox.Text = "";
            DateBirthTextBox.Text = "";
            VKTextBox.Text = "";
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

            var form = new ContactForm((Contact)Project.Contacts[index].Clone());
            form.ShowDialog();
            var editedContact = form.Contact;

            if (editedContact != null)
            {
                Project.Contacts.RemoveAt(index);
                Project.Contacts.Insert(index, editedContact);
            }
        }

        /// <summary>
        /// Обновление текущих контактов в зависимости от запроса поиска.
        /// </summary>
        public void UpdateCurrentContacts()
        {
            if (FindContactTextBox.Text == "")
            {
                CurrentContacts = Project.Contacts;
            }
            else
            {
                CurrentContacts = Project.FindContactsBySubstring(Project.Contacts, FindContactTextBox.Text);
            }
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
                UpdateListBox();
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
            if (ContactsListBox.SelectedIndex == -1)
            {
                return;
            }
            string message = "Do you really want to remove " +
                             ContactsListBox.Items[ContactsListBox.SelectedIndex] + "?";
            string title = "Caution!";

            if (MessageBox.Show(message, title, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveContact(ContactsListBox.SelectedIndex);
                UpdateCurrentContacts();
                UpdateListBox();
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
            UpdateListBox();
            UpdateSelectedContact(indexEditedContact);
        }

        private void FindContactTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentContacts = Project.FindContactsBySubstring(Project.Contacts, FindContactTextBox.Text);
            UpdateListBox();
        }

        private void CloseReminderButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }
    }
}
