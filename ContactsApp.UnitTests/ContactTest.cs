using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    internal class ContactTest
    {
        private Contact _contact = null;

        [SetUp]
        public void CreateContact()
        {
            DateTime birthday = new DateTime(2002, 3, 27);
            _contact = new Contact("Потапов", "Егор", "e@mail.ru", "id546221", birthday, new PhoneNumber(78005553535));
        }


        [Test(Description = "Присвоение строки длиннее 50 символов в качестве фамилии")]
        public void TestSurnameSet_LongString()
        {
            var wrongSurname = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            "Должно возникать исключение, если фамилия длиннее 50");
        }
        [Test(Description = "Присвоение верной фамилии")]
        public void TestSurnameSet_CorrectString()
        {
            var expected = "Потапов";
            Assert.DoesNotThrow(
            () => { _contact.Surname = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верной фамилии")]
        public void TestSurnameGet_CorrectString()
        {
            var expected = "Потапов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            ClassicAssert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Присвоение строки длиннее 50 символов в качестве фамилии")]
        public void TestNameSet_LongString()
        {
            var wrongName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Assert.Throws<ArgumentException>(
            () => { _contact.Name = wrongName; },
            "Должно возникать исключение, если имя длиннее 50");
        }
        [Test(Description = "Присвоение верного имени")]
        public void TestNameSet_CorrectString()
        {
            var expected = "Егор";
            Assert.DoesNotThrow(
            () => { _contact.Name = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного имени")]
        public void TestNameGet_CorrectString()
        {
            var expected = "Егор";
            _contact.Name = expected;
            var actual = _contact.Name;
            ClassicAssert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        [Test(Description = "Присвоение Email без @")]
        public void TestEmailSet_UncorrectArgumentException()
        {
            var wrongEmai = "email.ru";
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongEmai; },
            "Должно возникать исключение, если email не содержит @");
        }
        [Test(Description = "Присвоение длинного Email")]
        public void TestEmailSet_LongArgumentException()
        {
            var wrongEmail = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongEmail; },
            "Должно возникать исключение, если email более 50 символов");
        }
        [Test(Description = "Присвоение верного Email")]
        public void TestEmailSet_CorrectString()
        {
            var expected = "aa@mail.ru";
            Assert.DoesNotThrow(
            () => { _contact.Email = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного Email")]
        public void TestEmailGet_CorrectString()
        {
            var expected = "aa@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            ClassicAssert.AreEqual(expected, actual, "Геттер Email возвращает неправильное имя");
        }
        [Test(Description = "Присвоение строки длиннее 15 символов в качестве VKID")]
        public void TestIdVKSet_LongString()
        {
            var wrongIdVK = "111111111111111111111111";
            Assert.Throws<ArgumentException>(
            () => { _contact.IdVK = wrongIdVK; },
            "Должно возникать исключение, если имя длиннее 15");
        }
        [Test(Description = "Присвоение верного VKID")]
        public void TestIdVKSet_CorrectString()
        {
            var expected = "123456";
            Assert.DoesNotThrow(
            () => { _contact.IdVK = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного VKID")]
        public void TestIdVKGet_CorrectString()
        {
            var expected = "123456";
            _contact.IdVK = expected;
            var actual = _contact.IdVK;
            ClassicAssert.AreEqual(expected, actual, "Геттер IdVK возвращает неправильное имя");
        }
        [Test(Description = "Присвоение даты рождения раньше 1900 года")]
        public void TestBirthDateSet_LongString()
        {
            var wrongBirthDate = DateTime.Parse("1600.01.01");
            Assert.Throws<ArgumentException>(
            () => { _contact.BirthDate = wrongBirthDate; },
            "Должно возникать исключение, если дата раньше 1900 года");
        }
        [Test(Description = "Присвоение верной даты рождения")]
        public void TestBirthDateSet_CorrectString()
        {
            var expected = DateTime.Now;
            Assert.DoesNotThrow(
            () => { _contact.BirthDate = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верной даты рождения")]
        public void TestBirthDateGet_CorrectString()
        {
            var expected = DateTime.Now;
            _contact.BirthDate = expected;
            var actual = _contact.BirthDate;
            ClassicAssert.AreEqual(expected, actual, "Геттер BirthDate возвращает неправильную дату");
        }
        [Test(Description = "Присвоение верного номера телефона")]
        public void TestContactNumberSet_CorrectString()
        {
            var expected = new PhoneNumber(78005553535);
            Assert.DoesNotThrow(
            () => { _contact.ContactNumber = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного номера телефона")]
        public void TestContactNumberGet_CorrectString()
        {
            var expected = new PhoneNumber(78005553535);
            _contact.ContactNumber = expected;
            var actual = _contact.ContactNumber;
            ClassicAssert.AreEqual(expected, actual, "Геттер ContactNumber возвращает неправильный номер");
        }

    }
}
