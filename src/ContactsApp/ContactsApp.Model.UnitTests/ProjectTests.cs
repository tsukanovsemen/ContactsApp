using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test(Description = "Positive get contacts test.")]
        public void Contacts_GetContacts_ReturnsSameValue()
        {
            // Setup
            Project project = new Project();
            Contact firstContact = new Contact();
            Contact secondContact = new Contact();
            var expectedFirstContact = firstContact;
            var expectedSecondContact = secondContact;

            // Act
            project.Contacts.Add(firstContact);
            project.Contacts.Add(secondContact);

            var actualFirstContact = project.Contacts[0];
            var actualSecondContact = project.Contacts[1];

            // Assert
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(expectedFirstContact, actualFirstContact);
                    Assert.AreEqual(expectedSecondContact, actualSecondContact);
                }
                );
        }

        [Test(Description = "Positive test of sorting contacts")]
        public void SortByNameMethod_SortContacts_SortedList()
        {
            // Setup
            Project project = new Project();
            List<Contact> alreadySortedContacts = new List<Contact>();

            Contact firstContact = new Contact();
            var firstContactName = "Artem";
            firstContact.FullName = firstContactName;

            Contact secondContact = new Contact();
            var secondContactName = "Boris";
            secondContact.FullName = secondContactName;

            Contact thirdContact = new Contact();
            var thirdContactName = "Vladimir";
            thirdContact.FullName = thirdContactName;

            alreadySortedContacts.Add(firstContact);
            alreadySortedContacts.Add(secondContact);
            alreadySortedContacts.Add(thirdContact);

            var expectedContactsList = alreadySortedContacts;
            List<Contact> contacts = new List<Contact>();
            contacts.Add(secondContact);
            contacts.Add(thirdContact);
            contacts.Add(firstContact);

            // Act
            var actualContactsList = project.SortContactsByName(contacts);

            // Assert
            AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Positive test of finding birthday contacts.")]
        public void FindBirthdayContactsMethod_FindContacts_ReturnsBirthdayList()
        {
            // Setup
            Project project = new Project();
            var birthdayContactsList = new List<Contact>();
            var birthdayContact = new Contact();
            var birthDate = DateTime.Today;
            birthdayContact.DateOfBirth = birthDate;
            birthdayContactsList.Add(birthdayContact);
            var expectedContactsList = birthdayContactsList;

            var contactsList = new List<Contact>();
            var firstContact = new Contact();
            var someDate = birthDate.AddDays(-3);
            firstContact.DateOfBirth = someDate;
            contactsList.Add(firstContact);
            contactsList.Add(birthdayContact);

            // Act
            var actualContactsList = project.FindBirthdayContacts(contactsList);

            // Assert
            AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Positive test of finding contacts by substring.")]
        public void FindContactsBySubstring_FindContacts_ReturnsContactsList()
        {
            // Setup
            Project project = new Project();
            var desiredContactsList = new List<Contact>();
            Contact setupContact = new Contact();
            var fullName = "Artem";
            setupContact.FullName = fullName;
            desiredContactsList.Add(setupContact);
            var secondFullName = "Artur";
            Contact secondSetupContact = new Contact();
            secondSetupContact.FullName = secondFullName;
            desiredContactsList.Add(secondSetupContact);
            var expectedContactsList = desiredContactsList;

            var contactsList = new List<Contact>();
            contactsList.Add(setupContact);
            contactsList.Add(secondSetupContact);
            Contact anotherContact = new Contact();
            var fullNameAnotherContact = "Boris";
            anotherContact.FullName = fullNameAnotherContact;
            contactsList.Add(anotherContact);
            var substring = "Art";

            // Act
            var actualContactsList = project.FindContactsBySubstring(contactsList, substring);

            // Assert
            AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }

        /// <summary>
        /// Сравнение каждого контакта из списка через CompateContacts класс.
        /// </summary>
        /// <param name="contactsList1">Первый список контактов.</param>
        /// <param name="contactsList2">Второй список контактов.</param>
        private void AssertCompareContactsLists(List<Contact> expectedList, List<Contact> actualList)
        {
            for (int i = 0; i < actualList.Count; i++)
            {
                CompareContacts.AssertComparedContacts(expectedList[i],
                     actualList[i]);
            }
        }
    }
}
