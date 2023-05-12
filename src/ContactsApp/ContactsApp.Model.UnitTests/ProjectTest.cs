using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        Project _project;

        [SetUp]
        public void InitializeProject()
        {
            _project = new Project();
        }

        [Test(Description = "Positive get contacts test.")]
        public void Contacts_GetContacts_ReturnsSameValue()
        {
            //Avarrage
            var fullNameFirst = "Sem";
            var fullNameSecond = "Artem";
            var expectedFullNameFirstContact = fullNameFirst;
            var expectedFullNameSecondContact = fullNameSecond;

            //Act
            Contact firstContact = new Contact();
            firstContact.FullName = fullNameFirst;
            _project.Contacts.Add(firstContact);

            Contact secondContact = new Contact();
            secondContact.FullName = fullNameSecond;
            _project.Contacts.Add(secondContact);

            var actualFullNameFirstContact = _project.Contacts[0].FullName;
            var actualFullNameSecondContact = _project.Contacts[1].FullName;

            //Assert
            Assert.AreEqual(expectedFullNameFirstContact, actualFullNameFirstContact);
            Assert.AreEqual(expectedFullNameSecondContact, actualFullNameSecondContact);
        }

        [Test(Description = "Positive test of sorting contacts")]
        public void SortByNameMethod_SortContacts_SortedList()
        {
            //Avarrage
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

            //Act
            List<Contact> contacts = new List<Contact>();
            contacts.Add(secondContact);
            contacts.Add(thirdContact);
            contacts.Add(firstContact);
            var actualContactsList = _project.SortContactsByName(contacts);

            //Assert
            Assert.AreEqual(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Positive test of finding birthday contacts.")]
        public void FindBirthdayContactsMethod_FindContacts_ReturnsBirthdayList()
        {
            //Avarrage
            var birthdayContactsList = new List<Contact>();
            var birthdayContact = new Contact();
            var birthDate = DateTime.Today;
            birthdayContact.DateOfBirth = birthDate;
            birthdayContactsList.Add(birthdayContact);
            var expectedContactsList = birthdayContactsList;

            //Act
            var contactsList = new List<Contact>();
            var firstContact = new Contact();
            var someDate = birthDate.AddDays(-3);
            firstContact.DateOfBirth = someDate;
            contactsList.Add(firstContact);
            contactsList.Add(birthdayContact);
            var actualContactsList = _project.FindBirthdayContacts(contactsList);

            //Assert
            Assert.AreEqual(expectedContactsList,
                actualContactsList);
        }

        [Test(Description = "Positive test of finding contacts by substring.")]
        public void FindContactsBySubstring_FindContacts_ReturnsContactsList()
        {
            //Avarrage
            var desiredContactsList = new List<Contact>();
            Contact setupContact = new Contact();
            var fullName = "Семен.";
            setupContact.FullName = fullName;
            desiredContactsList.Add(setupContact);
            var expectedContactsList = desiredContactsList;

            //Act
            var contactsList = new List<Contact>();
            contactsList.Add(setupContact);
            Contact anotherContact = new Contact();
            var fullNameAnotherContact = "Андрей.";
            anotherContact.FullName = fullNameAnotherContact;
            contactsList.Add(anotherContact);
            var substring = "Сем";
            var actualContactsList = _project.FindContactsBySubstring(contactsList, substring);

            //Assert
            Assert.AreEqual(expectedContactsList, actualContactsList);
        }
    }
}
