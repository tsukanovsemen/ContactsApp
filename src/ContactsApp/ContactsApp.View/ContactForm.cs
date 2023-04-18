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
        private Contact _contact = new Contact();

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

        public ContactForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _contact.FullName = "Цуканов Семен Сергеевич";
            _contact.Email = "apple.semen@mail.ru";
            _contact.PhoneNumber = "89095485638";
            _contact.DateOfBirth = new DateTime(2001, 11, 6);
            _contact.IdVK = "sematsukanovvv";
            UpdateForm();
        }

        /// <summary>
        /// Обновление данных полей контакта.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumbTextBox.Text = _contact.PhoneNumber;
            DateTimePicker.Text = _contact.DateOfBirth.ToString();
            VKTextBox.Text = _contact.IdVK;
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
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumbTextBox.Text;
            _contact.DateOfBirth = DateTimePicker.Value;
            _contact.IdVK = VKTextBox.Text;
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
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
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
                _contact.Email = EmailTextBox.Text;
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
                _contact.PhoneNumber = PhoneNumbTextBox.Text;
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
                _contact.DateOfBirth = DateTimePicker.Value;
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
                _contact.IdVK = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
                _idVKError = "";
            }
            catch (ArgumentException ex)
            {
                VKTextBox.BackColor = Color.LightPink;
                _idVKError = ex.Message;
            }
        }
    }
}