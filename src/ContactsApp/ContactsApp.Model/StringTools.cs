using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Сервисный класс для преобразования строк в Contact.
    /// </summary>
    public class StringTools
    {
        /// <summary>
        /// Преобразует первые символы слов в заглавные.
        /// </summary>
        /// <param name="value">Строка слов.</param>
        /// <returns>Обновленная строка с заглавными символами.</returns>
        public static string FirstCharactersToUpperCase(string value)
        {
            string[] names = value.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                var name = names[i];
                names[i] = name.Substring(0, 1).ToUpper() + name.Substring(1);
            }

            return String.Join(" ", names);
        }

        /// <summary>
        /// Фильтрует строку символов телефонного номера.
        /// </summary>
        /// <param name="value">Входная строка символов.</param>
        /// <returns>Выходная строка.</returns>
        public static bool IsPhoneNumberCorrect(string value)
        {
            string allowedChars = "1234567890+()- ";

            for (int i = 0; i < value.Length; i++)
            {
                if (!allowedChars.Contains(value[i]))
                {
                    throw new ArgumentException("Phone number can contain only 1234567890+()- chars.");
                }
            }
            return true;
        }
    }
}
