using System;
using System.Linq;

namespace ContactsApp.Model
{
    internal class Contact : ICloneable
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
        private DateTime _dayOfBirth;

        /// <summary>
        /// ID vkontakte контакта.
        /// </summary>
        private string _idVK;

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
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of FullName must be greater then 0 characters.");
                }

                if (value.Length > _maxNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of FullName must be less then {_maxNameAndEmailLength} characters.");
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

                if (value.Length >= _maxNameAndEmailLength)
                {
                    throw new ArgumentException(
                        $"The length of email must be less then {_maxNameAndEmailLength} characters.");
                }

                _email = value.ToLower();
            }
        }

        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of PhoneNumber must be greater then 0.");
                }

                _phoneNumber = FilterStringPhoneNumber(value);
            }
        }

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        public DateTime DayOfBirth
        {
            get { return _dayOfBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException($"The date must be less then {DateTime.Now}.");
                }

                if (value < new DateTime(1900, 1, 1))
                {
                    throw new ArgumentException($"The date must be greater then {new DateTime(1900, 1, 1)}");
                }

                _dayOfBirth = value;
            }
        }

        /// <summary>
        /// ID vkontakte контакта.
        /// </summary>
        public string IdVK
        {
            get { return _idVK; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The length of IdVK must be greater then 0.");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException($"The length of IdVK must be less then {_maxIdVKLength} characters.");
                }

                _idVK = value;
            }
        }

        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создание контакта, с некоторыми данными.
        /// </summary>
        /// <param name="fullName">Полное имя контакта.</param>
        /// <param name="email">Email контакта.</param>
        /// <param name="phoneNumber">Телефонный номер.</param>
        /// <param name="dayOfBirth">Дата рождения.</param>
        /// <param name="idVK">ID контакта.</param>
        public Contact(string fullName, string email, string phoneNumber, DateTime dayOfBirth, string idVK)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DayOfBirth = dayOfBirth;
            IdVK = idVK;
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

        /// <summary>
        /// Фильтрует строку символов телефонного номера.
        /// </summary>
        /// <param name="value">Входная строка символов.</param>
        /// <returns>Выходная строка.</returns>
        private string FilterStringPhoneNumber(string value)
        {
            string filteredString = new string(value.Where(c => char.IsDigit(c)
            || c == '+' || c == '(' || c == ')' || c == '-' || c == ' ').ToArray());
            return filteredString;
        }

        /// <summary>
        /// Реализует интерфейс ICloneable.
        /// </summary>
        /// <returns>Объект с заданными полями.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Clone()
        {
            throw new NotImplementedException();
            return new Contact(FullName, Email, PhoneNumber, DayOfBirth, IdVK);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            c.PhoneNumber = "1jwf3232fs`dsr33ve;(sf),09-sfs12312193";
            Console.WriteLine(c.PhoneNumber);
        }
    }
}