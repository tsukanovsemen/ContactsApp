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
        private Project _project;

        /// <summary>
        /// Создает экземпляр класса <see cref = "MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
        }

        /// <summary>
        /// Обновление списка контактов в главном окне.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Добавление нового контакта.
        /// </summary>
        private void AddContact()
        {
            string fullName = ContactFactory.GenerateRandomName();
            string email = ContactFactory.GenerateEmail(fullName);
            string phoneNumber = ContactFactory.GenerateRandomPhoneNumber();
            DateTime date = ContactFactory.GenerateRandomDate();
            string idVK = ContactFactory.GenerateIDVK(fullName);
            _project.Contacts.Add(new Contact(fullName, email,
                phoneNumber, date, idVK));
        }

        /// <summary>
        /// Удаление выбранного контакта.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта.</param>
        private void RemoveContact(int index)
        {
            ContactsListBox.Items.RemoveAt(index);
            _project.Contacts.RemoveAt(index);
        }

        /// <summary>
        /// Обновляет правую панель главного окна, в зависимости от выбранного контакта.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта.</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                CleareSelectedContact();
            }
            else
            {
                FullNameTextBox.Text = _project.Contacts[index].FullName;
                EmailTextBox.Text = _project.Contacts[index].Email;
                PhoneNumbTextBox.Text = _project.Contacts[index].PhoneNumber;
                string date = _project.Contacts[index].DateOfBirth.Year.ToString() + "." +
                    _project.Contacts[index].DateOfBirth.Month.ToString() + "." +
                    _project.Contacts[index].DateOfBirth.Day.ToString();
                DateBirthTextBox.Text = date;
                VKTextBox.Text = _project.Contacts[index].IdVK;
            }
        }

        /// <summary>
        /// Очищает правую панель окна.
        /// </summary>
        private void CleareSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumbTextBox.Text = "";
            DateBirthTextBox.Text = "";
            VKTextBox.Text = "";
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
            //var form = new ContactForm();
            //form.ShowDialog();
            AddContact();
            UpdateListBox();
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
                UpdateListBox();
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }
    }
}
