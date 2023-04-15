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
    public class Project
    {
        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public List<Contact> Contacts { get; private set; } = new List<Contact>();

        /// <summary>
        /// Сортировка контактов по имени.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Отсортированный список всех контактов.</returns>
        public List<Contact> SortContactsByName(List<Contact> contacts)
        {
            contacts.Sort((contact, nextContact) =>
            contact.FullName.CompareTo(nextContact.FullName));
            return contacts;
        }

        /// <summary>
        /// Поиск именниников среди всех контактов.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <returns>Список именниников.</returns>
        public List<Contact> FindBirthdayContact(List<Contact> contacts)
        {
            List<Contact> birthdayContact = new List<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.DateOfBirth.Day == DateTime.Today.Day &&
                    contact.DateOfBirth.Month == DateTime.Today.Month)
                {
                    birthdayContact.Add(contact);
                }
            }

            return birthdayContact;
        }

        /// <summary>
        /// Поиск контакта по подстроке имени.
        /// </summary>
        /// <param name="contacts">Список всех контактов.</param>
        /// <param name="substring">Подстрока поиска.</param>
        /// <returns></returns>
        public List<Contact> FindContactsBySubstring(List<Contact> contacts, string substring)
        {
            substring = substring.ToLower();
            return contacts.FindAll(contact => contact.FullName.ToLower().Contains(substring));
        }
    }
}
