using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, представляющий номер телефона
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="number">номер телефона (должно быть 11 цифр и первая цифра обязательно 7)</param>
        public PhoneNumber(long number)
        {
            Number = number;
        }

        /// <summary>
        /// Возвращает и задает номер телефона (должно быть 11 цифр и первая цифра обязательно 7)
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                if (_number != value)
                {
                    string str_number = value.ToString();
                    if (str_number.Length == 11 && str_number[0] == '7')
                    {
                        _number = value;
                    }
                    else throw new ArgumentException("Номер должен состоять из 11 цифр и начинаться с 7");
                }
            }
        }
    }
}
