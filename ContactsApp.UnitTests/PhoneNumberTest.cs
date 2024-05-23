using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{
    /// <summary>
    /// Класс модельных тестов номера телефона
    /// </summary>
    /// 
    public class PhoneNumberTest
    {

        PhoneNumber _number;

        [SetUp]
        public void CreateContact()
        {
            _number = new PhoneNumber(78005553535);
        }
        [Test(Description = "Присвоение номера телефона начинающегося не с 7")]
        public void TestPhoneNumberSet_UncorrectArgumentException()
        {
            var wrongPhone = 88005553535;
            Assert.Throws<ArgumentException>(
            () => { _number.Number = wrongPhone; },
            "Должно возникать исключение, если номер телефона не начинается с 7");
        }
        [Test(Description = "Присвоение Email без @")]
        public void TestPhoneNumberSet_ArgumentException()
        {
            var wrongPhone = 7;
            Assert.Throws<ArgumentException>(
            () => { _number.Number = wrongPhone; },
            "Должно возникать исключение, если номер состоит не из 11 символов");
        }
        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _number.Number = wrongNumber; },
            message);
        }
        [Test(Description = "Присвоение верного номера")]
        public void TestSurnameSet_CorrectString()
        {
            var expected = (78005553530);
            Assert.DoesNotThrow(
            () => { _number.Number = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного номера")]
        public void TestPhoneNumberGet_CorrectString()
        {
            var expected = (78005553530);

            _number.Number = expected;
            var actual = _number.Number;
            ClassicAssert.AreEqual(expected, actual, "Геттер Number возвращает неправильный номер");
        }
    }
}
