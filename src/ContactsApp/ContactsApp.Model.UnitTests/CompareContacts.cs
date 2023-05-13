using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    public class CompareContacts
    {
        public static void AssertComparedContacts(Contact contact1, Contact contact2)
        {
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(contact1.FullName, contact2.FullName);
                    Assert.AreEqual(contact1.Email, contact2.Email);
                    Assert.AreEqual(contact1.PhoneNumber, contact2.PhoneNumber);
                    Assert.AreEqual(contact1.DateOfBirth, contact2.DateOfBirth);
                    Assert.AreEqual(contact1.IdVK, contact2.IdVK);
                }
                );
        }
    }
}
