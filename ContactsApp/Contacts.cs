using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта. Содержит информацию о контакте: Фамилию, Имя, почту, ID ВКонтакте, дату рождения и номер телефона
    /// </summary>
    public class Contact : ICloneable
    {
        string _name;
        string _surname;
        string _email;
        string _idVK;
        DateTime _birthDate;
        PhoneNumber _phoneNumber;

        public Contact(string name, string surname, string email, string idVK, DateTime birthDate, PhoneNumber phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            IdVK = idVK;
            BirthDate = birthDate;
            ContactNumber = phoneNumber;
        }
        /// <summary>
        /// Возвращает и задает имя (не длиннее 50 символов)
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    if (value.Length < 50)
                    {
                        _name = value;
                    }
                    else
                    {
                        throw new ArgumentException("Имя не может быть длинее 50 символов!");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию (не длиннее 50 символов)
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname != value)
                {
                    if (value.Length < 50)
                    {
                        _surname = value;
                    }
                    else
                    {
                        throw new ArgumentException("Фамилия не может быть длинее 50 символов!");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает почту (не длиннее 50 символов)
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    if (value.Length < 50 && value.Contains("@"))
                    {
                        _email = value;
                    }
                    else if (value.Length >= 50)
                    {
                        throw new ArgumentException("Email не может быть длинее 50 символов!");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает ID ВКонтакте (не длиннее 15 символов)
        /// </summary>
        public string IdVK
        {
            get { return _idVK; }
            set
            {
                if (_idVK != value)
                {
                    if (value.Length < 15)
                    {
                        _idVK = value;
                    }
                    else
                    {
                        throw new ArgumentException("Id VK не может быть длинее 50 символов!");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает дату рождения (не раньше 1900 года)
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Некорректная дата рождения! Год не может быть ранее, чем 1900 год");
                }
                else if (_birthDate != value)
                {
                    _birthDate = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона
        /// </summary>
        public PhoneNumber ContactNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                }
            }
        }

        public object Clone()
        {
            return new Contact(Name, Surname, Email, IdVK, BirthDate, ContactNumber);
        }
    }
}