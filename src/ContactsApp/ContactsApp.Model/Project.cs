using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс, описывающий проект.
    /// </summary>
    internal class Project
    {
        /// <summary>
        /// Список всех контактов.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }

        /// <summary>
        /// Создание контактов.
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }

        /// <summary>
        /// Сортировка контактов по имени.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Отсортированный список всех контактов.</returns>
        public List<Contact> SortContactsByName(List<Contact> contacts)
        {
            contacts.Sort((x, y) => x.FullName.CompareTo(y.FullName));
            return contacts;
        }

        /// <summary>
        /// Поиск именниников среди всех контактов.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Список именниников.</returns>
        public List<Contact> FindBirthdayBoy(List<Contact> contacts)
        {
            List<Contact> birthdayBoys = new List<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.DayOfBirth == DateTime.Now)
                {
                    birthdayBoys.Add(contact);
                }
            }

            return birthdayBoys;
        }

        /// <summary>
        /// Поиск контакта по подстроке имени.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <param name="searchName">Подстрока поиска.</param>
        /// <returns></returns>
        public List<Contact> FindContactsBySubstring(List<Contact> contacts, string searchName)
        {
            return contacts.FindAll(contact => contact.FullName.Contains(searchName));
        }
    }
}
