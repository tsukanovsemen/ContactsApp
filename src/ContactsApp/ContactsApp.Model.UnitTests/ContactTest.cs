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
        [TestCase("", "An exception should be thrown if the length " +
            "of the full name is 0.", TestName = "Assigning an empty string to full name.")]
        [TestCase("The very very very very very very very very very very very very very " +
            "very very very very very long name which greater then 100 characters.", TestName =
            "Assigning a string greater than 100 characters.")]
        public void Test_FullNameSet_ArgumentException(string wrongFullName, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(() =>
            { contact.FullName = wrongFullName; }, message);
        }

    }
}
