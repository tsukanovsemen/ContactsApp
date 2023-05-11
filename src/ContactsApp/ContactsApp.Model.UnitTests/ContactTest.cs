using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void InitializeContact()
        {
            _contact = new Contact();
        }

        [Test(Description = "Negative full name assignment check.")]
        [TestCase("", "An exception should be thrown if the length " +
            "of the full name is 0.", TestName = "Assigning an empty string to full name.")]
        [TestCase("The very very very very very very very very" +
            "very very very very very very very very very very very very very big fullname.",
            "An exception should be thrown if the length " +
            "of the full name is greater than 100 characters.", TestName =
            "Assigning a string greater than 100 characters.")]
        public void Test_FullNameSet_ArgumentException(string wrongFullName, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            { _contact.FullName = wrongFullName; }, message);
        }

        [Test(Description = "Positive full name assignment check.")]
        public void Test_FullNameSet_CorrectSet()
        {
            //Arrange
            var expected = "Tsukanov Semyon Sergeevich";

            //Act
            _contact.FullName = "Tsukanov Semyon Sergeevich";
            var actual = _contact.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative email assignment check.")]
        public void Test_EmailSet_ArgumentException()
        {
            var wrongEmail = "The very very very very very very very" +
                "very very very very very very very very very very very very very big email.";
            var message = "An exception should be thrown if the length " +
            "of the email is greater than 100 characters.";

            Assert.Throws<ArgumentException>(() =>
            { _contact.FullName = wrongEmail; }, message);
        }

        [Test(Description = "Positive email assignment check.")]
        public void Test_EmailSet_CorrectSet()
        {
            //Arrange
            var expected = "sementsukanovvv@gmail.com";

            //Act
            _contact.Email = "sementsukanovvv@gmail.com";
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive validation of email assignment to small characters.")]
        public void Test_EmailSet_AllCharsAreLower()
        {
            //Arrange
            var expected = "sementsukanovvv@gmail.com";

            //Act
            _contact.Email = "SEMENTSUKANOVVV@GMAIL.COM";
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative phone number assignment check.")]
        public void Test_PhoneNumberSet_EmptyString()
        {
            //Arrange
            var expected = " ";

            //Act
            _contact.PhoneNumber = "";
            var actual = _contact.PhoneNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative phone number assignment check.")]
        public void Test_PhoneNumberSet_ArgumentException()
        {
            var wrongPhoneNumber = "abcdef";
            var message = "An exception should be thrown if the chars of " +
                "the phone number are incorrect.";

            Assert.Throws<ArgumentException>(() =>
            { _contact.PhoneNumber = wrongPhoneNumber; }, message);
        }

        [Test(Description = "Positive phone number assignment check.")]
        public void Test_PhoneNumberSet_CorrectSet()
        {
            //Arrange
            var expected = "+7(909)145-13-12";

            //Act
            _contact.PhoneNumber = "+7(909)145-13-12";
            var actual = _contact.PhoneNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative date of birth assignment check.")]
        public void Test_DateOfBirthSetLittleDate_ArgumetException()
        {
            var wrongDate = new DateTime(1899, 1, 1);
            var message = "An exception should be thrown if the date of " +
                "birth is less than 1900.1.1.";

            Assert.Throws<ArgumentException>(() =>
            { _contact.DateOfBirth = wrongDate; }, message);
        }

        [Test(Description = "Negative date of birth assignment check.")]
        public void Test_DateOfBirthSetTomorrowDate_ArgumetException()
        {
            var wrongDate = DateTime.Now.AddDays(1);
            var message = "An exception should be thrown if the date of " +
                "birth is greater than date now.";

            Assert.Throws<ArgumentException>(() =>
            { _contact.DateOfBirth = wrongDate; }, message);
        }

        [Test(Description = "Positive date of birth assignment check.")]
        public void Test_DateOfBirthSet_CorrectSet()
        {
            //Arrange
            var expected = new DateTime(2022, 3, 3);

            //Act
            _contact.DateOfBirth = new DateTime(2022, 3, 3);
            var actual = _contact.DateOfBirth;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative IdVk assignment check.")]
        public void Test_IdVkSet_ArgumentException()
        {
            var wrongIdVk = " big id:0123456789101112131415161718192021222324252627282930";
            var message = "An exception should be thrown if the id vk " +
                "will be greater than 50 characters.";

            Assert.Throws<ArgumentException>(() =>
            { _contact.IdVK = wrongIdVk; }, message);
        }

        [Test(Description = "Positive IdVk assignment check.")]
        public void Test_IdVkSet_EmptyString()
        {
            //Avarrage
            var expected = " ";

            //Act
            _contact.IdVK = "";
            var actual = _contact.IdVK;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive IdVk assignment check.")]
        public void Test_IdVkSet_CorrectSet()
        {
            //Avarrage
            var expected = "id@/semyon";

            //Act
            _contact.IdVK = "id@/semyon";
            var actual = _contact.IdVK;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Constructor assignment check.")]
        public void Test_ContactConstructor_ArgumentException()
        {
            var wrongFullName = "very very very very very very very very" +
                "very very very very very very very very very very very very very big letter.";
            var message = "An exception should be thrown if " +
                "the argument of constructor is incorrect.";

            Assert.Throws<ArgumentException>(() =>
            { new Contact(wrongFullName, "email","55-55-55",
                new DateTime(2022,1,1),""); }, message);
        }

        [Test(Description = "Positive Constructor assignment check.")]
        public void Test_ContactConstructor_Correct()
        {
            //Avarrage
            var expectedFullName = "Semyon Tsukanov";
            var expectedEmail = "email@mail.com";
            var expectedPhoneNumber = "89095053939";
            var expectedDateOfBirth = new DateTime(2001, 11, 6);
            var expectedIdVk = "id@/vk";

            //Act
            Contact contact = new Contact("Semyon Tsukanov",
                "email@mail.com", 
                "89095053939",
                new DateTime(2001, 11, 6),
                "id@/vk");
            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.IdVK;

            //Assert
            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
            Assert.AreEqual(expectedIdVk, actualIdVk);
        }

        [Test(Description = "Positive Clone method check.")]
        public void Test_CloneMethod_ClonedInstance()
        {
            //Avarrange
            var expectedFullName = "Semyon Tsukanov";
            var expectedEmail = "email@mail.com";
            var expectedPhoneNumber = "89095053939";
            var expectedDateOfBirth = new DateTime(2001, 11, 6);
            var expectedIdVk = "id@/vk";

            //Act
            _contact = new Contact("Semyon Tsukanov",
                "email@mail.com",
                "89095053939",
                new DateTime(2001, 11, 6),
                "id@/vk");

            Contact newContact = (Contact)_contact.Clone();
            var actualFullName = newContact.FullName;
            var actualEmail = newContact.Email;
            var actualPhoneNumber = newContact.PhoneNumber;
            var actualDateOfBirth = newContact.DateOfBirth;
            var actualIdVk = newContact.IdVK;

            //Assert
            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
            Assert.AreEqual(expectedIdVk, actualIdVk);
        }
    }
}
