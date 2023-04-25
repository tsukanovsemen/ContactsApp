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
        /// Проверка нажата кнопка ОК при закрытии окна или же окно закрывается другим способом.
        /// </summary>
        bool _okButtonIsClicked = false;

        /// <summary>
        /// Создает экземпляр класса <see cref = "ContactForm"/>
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref = "ContactForm"/>
        /// Конструктор с параметром, для изменения данных контакта.
        /// </summary>
        /// <param name="contact">Редактируемый контакт.</param>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Contact = contact;
            UpdateForm();
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
            if (!(_fullNameError == ""))
            {
                resultError += _fullNameError + "\n";
            }
            if (!(_emailError == ""))
            {
                resultError += _emailError + "\n";
            }
            if (!(_phoneNumberError == ""))
            {
                resultError += _phoneNumberError + "\n";
            }
            if (!(_dateOfBirthError == ""))
            {
                resultError += _dateOfBirthError + "\n";
            }
            if (!(_idVKError == ""))
            {
                resultError += _idVKError + "\n";
            }
            if (!(resultError == ""))
            {
                MessageBox.Show(resultError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
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
                UpdateContact();
                _okButtonIsClicked = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Contact = null;
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                _fullNameError = "";
            }
            catch (ArgumentException ex)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullNameError = ex.Message;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailError = "";
            }
            catch (ArgumentException ex)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = ex.Message;
            }
        }

        private void PhoneNumbTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.PhoneNumber = PhoneNumbTextBox.Text;
                PhoneNumbTextBox.BackColor = Color.White;
                _phoneNumberError = "";
            }
            catch (ArgumentException ex)
            {
                PhoneNumbTextBox.BackColor = Color.LightPink;
                _phoneNumberError = ex.Message;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.DateOfBirth = DateTimePicker.Value;
                DateTimePicker.BackColor = Color.White;
                _dateOfBirthError = "";
            }
            catch (ArgumentException ex)
            {
                DateTimePicker.BackColor = Color.LightPink;
                _dateOfBirthError = ex.Message;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.IdVK = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
                _idVKError = "";
            }
            catch (ArgumentException ex)
            {
                VKTextBox.BackColor = Color.LightPink;
                _idVKError = ex.Message;
            }
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_okButtonIsClicked)
            {
                Contact = null;
            }
        }
    }
}