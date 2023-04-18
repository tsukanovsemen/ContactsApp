using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.View
{
    /// <summary>
    /// Класс для генерации случайных данных контакта.
    /// </summary>
    public static class ContactFactory
    {
        /// <summary>
        /// Генерация случайного полного имени из предложенного списка внутри метода.
        /// </summary>
        /// <returns>Сгенерированное новое имя.</returns>
        public static string GenerateRandomName()
        {
            Random rand = new Random();
            string[] names = {"Андрей", "Александр", "Марк", "Егор", "Семён",
                "Никита", "Антон", "Григорий", "Алексей", "Сергей"};
            string[] surnames = {"Петров", "Ковалев", "Пупкин", "Иванов", "Смирнов",
                "Антонов", "Егоров", "Платонов", "Цуканов", "Воробев"};
            string[] patronimycs = {"Алексеевич", "Валерьевич", "Евгеньевич", "Сергеевич", "Викторович",
                "Андреевич", "Аркадьевич", "Артемьевич", "Петрович", "Егорович"};

            return surnames[rand.Next(0, 9)] + " " + names[rand.Next(0, 9)] +
                " " + patronimycs[rand.Next(0, 9)];
        }

        /// <summary>
        /// Генерация email исходя из имени.
        /// </summary>
        /// <param name="fullName">Имя контакта.</param>
        /// <returns>Почта контакта.</returns>
        public static string GenerateEmail(string fullName)
        {
            string rus = "абвгдеёжзийклмнопрстуфхцчшщ";
            string eng = "abvgdeejziiklmnoprstufhccss";
            fullName = fullName.ToLower();
            string engName = "";
            foreach (char c in fullName)
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (c == rus[i])
                    {
                        engName += eng[i];
                    }
                }
            }
            return engName + "@mail.ru";
        }

        /// <summary>
        /// Генерация случайного номера телефона.
        /// </summary>
        /// <returns>Случайный номер телефона.</returns>
        public static string GenerateRandomPhoneNumber()
        {
            Random rand = new Random();
            string[] operatorsCodes = { "(909)", "(800)", "(952)", "(903)" };
            string resultNubmer = "+7" + operatorsCodes[rand.Next(0, 3)];
            for (int i = 0; i < 7; i++)
            {
                resultNubmer += rand.Next(0, 9);
            }
            return resultNubmer;
        }

        /// <summary>
        /// Генерация случайной даты.
        /// </summary>
        /// <returns>Объект DateTime.</returns>
        public static DateTime GenerateRandomDate()
        {
            Random rand = new Random();
            return new DateTime(rand.Next(1960, 2010), rand.Next(1, 12), rand.Next(1, 29));
        }

        /// <summary>
        /// Генерация айди вк по полному имени.
        /// </summary>
        /// <param name="fullName">Полное имя контакта.</param>
        /// <returns>Айди вконтакте.</returns>
        public static string GenerateIDVK(string fullName)
        {
            string rus = "абвгдеёжзийклмнопрстуфхцчшщ";
            string eng = "abvgdeejziiklmnoprstufhccss";
            fullName = fullName.ToLower();
            string engName = "";
            foreach (char c in fullName)
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (c == rus[i])
                    {
                        engName += eng[i];
                    }
                }
            }
            return engName;
        }
    }
}
