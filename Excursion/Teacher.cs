using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Teacher : Person
    {
        int workExperience; // стаж работы (лет)

        // Свойство
        public int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        // Конструктор
        // Поля name, dateBirth, sex - наследуемые
        public Teacher(string name, DateTime dateBirth, string sex, int workExperience)
             : base(name, dateBirth, sex)
        {
            this.workExperience = workExperience;
        }

        //Переопределяем метод базового класса InfoString()
        new public string InfoString()
        {
            string inf = $"\nПреподаватель\nимя: {Name}" +
                 $"\nдата рождения: {DateBirth.ToShortDateString()}" +
                 $"\nпол: {Sex}";

            // Новая информационная строка
            inf = inf + $"\nстаж: {workExperience} лет";
            return inf;
        }
    }
}