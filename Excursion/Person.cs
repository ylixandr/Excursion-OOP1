using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Person
    {
        string name;
        DateTime dateBirth;
        string sex;

        // 3 свойства
        public string Name
        { get { return name; } }

        public DateTime DateBirth
        { get { return dateBirth; } }  

        public string Sex
        { get { return sex; } }

        // Метод: информационная строка
        public string InfoString()
        {
            // строим информационную строку, используя интерполяцию строк
            // что такое интерполяция строк - см. Справку 
            string inf = $"\nЧеловек\nимя: {name}" +
                         $"\nдата рождения: {dateBirth.ToShortDateString()}" +
                         $"\nпол: {sex}";

            return inf;
        }

        // Конструктор
        public Person(string name, DateTime dateBirth, string sex)
        {
            this.name = name;
            this.dateBirth = dateBirth;
            this.sex = sex; 
        }
    }
}
