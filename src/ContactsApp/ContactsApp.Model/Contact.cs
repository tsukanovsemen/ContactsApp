using System;
using System.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс, описывающий Контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Максимальное значение длины полного имени и email.
        /// </summary>
        private const int _maxNameAndEmailLength = 100;

        /// <summary>
        /// Максимальное значение длины Id VK.
        /// </summary>
        private const int _maxIdVKLength = 50;

        /// <summary>
        /// Полное имя контакта. 
        /// </summary>
        private string _fullName;

        /// <summary>
        /// E-mail контакта. 
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефонный номер контакта. 
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// ID vkontakte контакта.
        /// </summary>
        private string _idVK;

        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length > _maxNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of FullName must be less then " +
                        $"{_maxNameAndEmailLength} characters.");
                }

                _fullName = ContactsAppService.FirstCharactersToUpperCase(value);
            }
        }

        /// <summary>
        /// E-mail контакта. 
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length >= _maxNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of email must be less then " +
                        $"{_maxNameAndEmailLength} characters.");
                }

                _email = value.ToLower();
            }
        }

        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = ContactsAppService.FilterStringPhoneNumber(value);
            }
        }

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        public DateTime DayOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException($"The date must be less then " +
                        $"{DateTime.Now}.");
                }

                if (value < new DateTime(1900, 1, 1))
                {
                    throw new ArgumentException($"The date must be greater then " +
                        $"{new DateTime(1900, 1, 1)}");
                }

                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// ID vkontakte контакта.
        /// </summary>
        public string IdVK
        {
            get
            {
                return _idVK;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"The length of IdVK must be less then " +
                        $"{_maxIdVKLength} characters.");
                }

                _idVK = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref = "Contact"/>
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создает экземпляр класса <see cref = "Contact"/>
        /// </summary>
        /// <param name="fullName">Полное имя контакта.</param>
        /// <param name="email">Email контакта.</param>
        /// <param name="phoneNumber">Телефонный номер.</param>
        /// <param name="dayOfBirth">Дата рождения.</param>
        /// <param name="idVK">ID контакта.</param>
        public Contact(
            string fullName,
            string email,
            string phoneNumber,
            DateTime dayOfBirth,
            string idVK)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DayOfBirth = dayOfBirth;
            IdVK = idVK;
        }

        /// <summary>
        /// Реализует интерфейс ICloneable.
        /// </summary>
        /// <returns>Объект с заданными полями.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Clone()
        {
            return new Contact(FullName, Email, PhoneNumber, DayOfBirth, IdVK);
        }
    }
}