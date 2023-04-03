using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Contact
    {
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
        private string _dayOfBirth;

        /// <summary>
        /// ID vkontakte контакта.
        /// </summary>
        private string _idVK;


        /// <summary>
        /// Максимальное значение длины полного имени.
        /// </summary>
        private const int _maxFullNameAndEmailLength = 100;

        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of FullName must be greater then 0 characters.");
                }

                if (value.Length > _maxFullNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of FullName must be less then {_maxFullNameAndEmailLength} characters.");
                }

                _fullName = FirstCharactersToUpperCase(value);
            }
        }

        /// <summary>
        /// E-mail контакта. 
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of email must be greater then 0 characters.");
                }

                if (value.Length >= _maxFullNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of email must be less then {_maxFullNameAndEmailLength} characters.");
                }

                _email = value.ToLower();
            }
        }

        /// <summary>
        /// Преобразует первые символы слов в заглавные.
        /// </summary>
        /// <param name="value">Строка слов.</param>
        /// <returns>Обновленная строка с заглавными символами.</returns>
        private string FirstCharactersToUpperCase(string value)
        {
            string[] names = value.Split('\u0020');
            string resultLine = "";
            for (int i = 0; i < names.Length; i++)
            {
                char[] tempName = names[i].ToCharArray();
                tempName[0] = char.ToUpper(tempName[0]);
                names[i] = new string(tempName);
                if (i == names.Length - 1)
                {
                    resultLine = string.Concat(resultLine, names[i]);
                }
                else
                {
                    resultLine = string.Concat(resultLine, names[i], " ");
                }
            }

            return resultLine;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.FullName = "ibragimov bogdan alimovich";
            Console.WriteLine(contact.FullName);
        }
    }
}