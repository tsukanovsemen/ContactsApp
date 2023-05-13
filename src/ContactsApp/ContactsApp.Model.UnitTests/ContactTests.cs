using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test(Description = "Negative full name assignment check.")]
        [TestCase("", "An exception should be thrown if the length " +
            "of the full name is 0.", TestName = "Assigning an empty string to full name.")]
        [TestCase("The very very very very very very very very" +
            "very very very very very very very very very very very very very big fullname.",
            "An exception should be thrown if the length " +
            "of the full name is greater than 100 characters.", TestName =
            "Assigning a string greater than 100 characters.")]
        public void FullName_SetIncorrectValue_ArgumentException(string wrongFullName, string message)
        {
            // Setup
            Contact contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.FullName = wrongFullName;
            },
            message);
        }

        [Test(Description = "Positive full name assignment check.")]
        public void FullName_SetCorrectValue_ReturnsSameValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctFullName = "Tsukanov Semyon Sergeevich";
            var expected = correctFullName;

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative email assignment check.")]
        public void Email_SetIncorrectValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongEmail = "The very very very very very very very" +
                "very very very very very very very very very very very very very big email.";
            var message = "An exception should be thrown if the length " +
            "of the email is greater than 100 characters.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.FullName = wrongEmail;
            },
            message);
        }

        [Test(Description = "Positive email assignment check.")]
        public void Email_SetCorrectValue_ReturnsSameValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctEmail = "sementsukanovvv@gmail.com";
            var expected = correctEmail;

            // Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive validation of email assignment to small characters.")]
        public void Email_SetAllCharsAreLower_ReturnsAllCharsLowerValue()
        {
            // Setup
            Contact contact = new Contact();
            var lowerCorrectEmail = "sementsukanovvv@gmail.com";
            var expected = lowerCorrectEmail;

            // Act
            var upperIncorrectEmail = lowerCorrectEmail.ToUpper();
            contact.Email = upperIncorrectEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative phone number assignment check.")]
        public void PhoneNumber_SetIncorrectValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongPhoneNumber = "abcdef";
            var message = "An exception should be thrown if the chars of " +
                "the phone number are incorrect.";

            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.PhoneNumber = wrongPhoneNumber;
            },
            message);
        }

        [Test(Description = "Positive phone number assignment check.")]
        public void PhoneNumber_SetCorrectValue_ReturnsSameValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctPhoneNumber = "+7(909)145-13-12";
            var expected = correctPhoneNumber;

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative date of birth assignment check.")]
        public void DateOfBirth_SetLittleDate_ArgumetException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongDate = new DateTime(1899, 1, 1);
            var message = "An exception should be thrown if the date of " +
                "birth is less than 1900.1.1.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = wrongDate;
            },
            message);
        }

        [Test(Description = "Negative date of birth assignment check.")]
        public void DateOfBirth_SetTomorrowDate_ArgumetException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongDate = DateTime.Now.AddDays(1);
            var message = "An exception should be thrown if the date of " +
                "birth is greater than date now.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = wrongDate;
            },
            message);
        }

        [Test(Description = "Positive date of birth assignment check.")]
        public void DateOfBirth_SetCorrectValue_ReturnsSameValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctDate = new DateTime(2022, 3, 3);
            var expected = correctDate;

            // Act
            contact.DateOfBirth = correctDate;
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative IdVk assignment check.")]
        public void IdVk_SetBigLengthValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongIdVk = " big id:0123456789101112131415161718192021222324252627282930";
            var message = "An exception should be thrown if the id vk " +
                "will be greater than 50 characters.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.IdVK = wrongIdVk;
            },
            message);
        }

        [Test(Description = "Positive IdVk assignment check.")]
        public void IdVk_SetCorrectValue_ReturnsSameValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctId = "id@/semyon";
            var expected = correctId;

            //Act
            contact.IdVK = correctId;
            var actual = contact.IdVK;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Constructor assignment check.")]
        public void Constructor_PassingInvalidParameter_ArgumentException()
        {
            // Setup
            var wrongFullName = "very very very very very very very very" +
                "very very very very very very very very very very very very very big letter.";
            var message = "An exception should be thrown if " +
                "the argument of constructor is incorrect.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                new Contact(wrongFullName, "email", "55-55-55",
                new DateTime(2022, 1, 1), "");
            },
            message);
        }

        [Test(Description = "Positive Constructor assignment check.")]
        public void Constructor_PassingCorrectParameters_ReturnsSameValues()
        {
            // Setup
            var fullName = "Semyon Tsukanov";
            var expectedFullName = fullName;

            var email = "email@mail.com";
            var expectedEmail = email;

            var phoneNumber = "89095053939";
            var expectedPhoneNumber = phoneNumber;

            var date = new DateTime(2001, 11, 6);
            var expectedDateOfBirth = date;

            var idVk = "id@/vk";
            var expectedIdVk = idVk;

            Contact contact = new Contact(fullName,
                email,
                phoneNumber,
                date,
                idVk);

            // Act
            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.IdVK;

            // Assert
            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
            Assert.AreEqual(expectedIdVk, actualIdVk);
        }

        [Test(Description = "Positive Clone method check.")]
        public void CloneMethod_CloneObject_ReturnsSameValues()
        {
            // Setup
            var fullName = "Semyon Tsukanov";
            var expectedFullName = fullName;

            var email = "email@mail.com";
            var expectedEmail = email;

            var phoneNumber = "89095053939";
            var expectedPhoneNumber = phoneNumber;

            var date = new DateTime(2001, 11, 6);
            var expectedDateOfBirth = date;

            var idVk = "id@/vk";
            var expectedIdVk = idVk;

            Contact contact = new Contact(fullName,
                email,
                phoneNumber,
                date,
                idVk);

            // Act
            Contact newContact = (Contact)contact.Clone();
            var actualFullName = newContact.FullName;
            var actualEmail = newContact.Email;
            var actualPhoneNumber = newContact.PhoneNumber;
            var actualDateOfBirth = newContact.DateOfBirth;
            var actualIdVk = newContact.IdVK;

            // Assert
            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
            Assert.AreEqual(expectedIdVk, actualIdVk);
        }
    }
}
