using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class StringToolsTest
    {
        [Test(Description = "Positive test of converting lower letters to upper ones.")]
        public void FirtsCharactersToUpperCaseMethod_ConvertString_ConvertedString()
        {
            //Avarrage
            var convertedText = "Some Text";
            var expectedText = convertedText;

            //Act
            var convertingText = "some text";
            var actualText = StringTools.FirstCharactersToUpperCase(convertingText);

            //Assert
            Assert.AreEqual(expectedText, actualText);
        }

        [Test(Description = "Positive test of validation phone number.")]
        public void ValidationPhoneNumberCorrect_Validation_ReturnsTrue()
        {
            //Avarrage
            var expectedResult = true;

            //Act
            var value = "1234567890()-";
            var actualResult = StringTools.IsPhoneNumberCorrect(value);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test(Description = "Negative test of validation phone number.")]
        public void ValidationPhoneNumberIncorrect_Validation_ReturnsFalse()
        {
            //Avarrage
            var expectedResult = false;

            //Act
            var value = "Hello World.";
            var actualResult = StringTools.IsPhoneNumberCorrect(value);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
