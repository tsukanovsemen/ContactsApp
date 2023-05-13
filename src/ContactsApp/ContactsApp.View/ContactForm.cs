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
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Новый контакт, созданный в форме.
        /// </summary>
        public Contact Contact { get; private set; } = new Contact();

        /// <summary>
        /// Сообщение об ошибке в полном имени контакта.
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// Сообщение об ошибке в почте контакта.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Сообщение об ошибке в телефонном номере контакта.
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// Сообщение об ошибке в дате рождения контакта.
        /// </summary>
        private string _dateOfBirthError;

        /// <summary>
        /// Сообщение об ошибке в айди вк контакта.
        /// </summary>
        private string _idVKError;

        /// <summary>
        /// Создает экземпляр класса <see cref = "ContactForm"/>
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            DateTimePicker.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref = "ContactForm"/>
        /// Конструктор с параметром, для изменения данных контакта.
        /// </summary>
        /// <param name="contact">Редактируемый контакт.</param>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;
            UpdateForm();
            DateTimePicker.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Обновление данных полей контакта.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = Contact.FullName;
            EmailTextBox.Text = Contact.Email;
            PhoneNumbTextBox.Text = Contact.PhoneNumber;
            DateTimePicker.Text = Contact.DateOfBirth.ToString();
            VKTextBox.Text = Contact.IdVK;
        }

        /// <summary>
        /// Проверка на существоание ошибок в валидации.
        /// </summary>
        /// <returns>True - ошибок нет, False - если ошибки есть.</returns>
        private bool CheckFormOnErrors()
        {
            string resultError = "";

            var errors = new List<String> { _fullNameError, _emailError,
                _phoneNumberError,_dateOfBirthError, _idVKError };

            errors = errors.Where(error => error != null).ToList();

            if (errors.Count == 0)
            {
                return true;
            }

            resultError = " - " + String.Join("\n - ", errors);

            MessageBox.Show(resultError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        /// <summary>
        /// Обновление полей контакта.
        /// </summary>
        private void UpdateContact()
        {
            Contact.FullName = FullNameTextBox.Text;
            Contact.Email = EmailTextBox.Text;
            Contact.PhoneNumber = PhoneNumbTextBox.Text;
            Contact.DateOfBirth = DateTimePicker.Value;
            Contact.IdVK = VKTextBox.Text;
        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                DialogResult = DialogResult.OK;
                UpdateContact();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Contact = null;
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.FullName = FullNameTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                FullNameTextBox.BackColor = ColorsContactsApp.COLOR_ERROR;
                _fullNameError = ex.Message;
                return;
            }
            FullNameTextBox.BackColor = ColorsContactsApp.COLOR_CORRECTLY;
            _fullNameError = null;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                EmailTextBox.BackColor = ColorsContactsApp.COLOR_ERROR;
                _emailError = ex.Message;
                return;
            }
            EmailTextBox.BackColor = ColorsContactsApp.COLOR_CORRECTLY;
            _emailError = null;
        }

        private void PhoneNumbTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.PhoneNumber = PhoneNumbTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                PhoneNumbTextBox.BackColor = ColorsContactsApp.COLOR_ERROR;
                _phoneNumberError = ex.Message;
                return;
            }
            PhoneNumbTextBox.BackColor = ColorsContactsApp.COLOR_CORRECTLY;
            _phoneNumberError = null;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.DateOfBirth = DateTimePicker.Value;
            }
            catch (ArgumentException ex)
            {
                DateTimePicker.BackColor = ColorsContactsApp.COLOR_ERROR;
                _dateOfBirthError = ex.Message;
                return;
            }
            DateTimePicker.BackColor = ColorsContactsApp.COLOR_CORRECTLY;
            _dateOfBirthError = null;
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.IdVK = VKTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                VKTextBox.BackColor = ColorsContactsApp.COLOR_ERROR;
                _idVKError = ex.Message;
                return;
            }
            VKTextBox.BackColor = ColorsContactsApp.COLOR_CORRECTLY;
            _idVKError = null;
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(DialogResult == DialogResult.OK))
            {
                Contact = null;
            }
        }
    }
}