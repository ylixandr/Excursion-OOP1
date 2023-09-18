using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion
{
    class Student:Person
    {
        decimal scolarShip;

        public decimal ScolarShip
        {
            get { return scolarShip; } set {  scolarShip = value; }
        }

       public double averageMark;
        public double AverageMark
        {
            get { return averageMark; }
            set { averageMark = value; }
        }

        public void GetScholarShip()
        {
            if (averageMark >= 8.0)
                scolarShip = 100;
            else if (averageMark < 8.0)
                scolarShip = 80;
           

        }

        public Student(string name, DateTime dateBirth, string sex, decimal scolarShip, double averageMark):base (name, dateBirth, sex)
        {
            this.scolarShip = scolarShip;
            this.averageMark = averageMark;
        }

        new public string InfoString()
        {
            string inf = $"\nСтудент\nимя: {Name}" +
                 $"\nдата рождения: {DateBirth.ToShortDateString()}" +
                 $"\nпол: {Sex}" +
                 $"\nбалл: {AverageMark}";

            // Новая информационная строка
            inf = inf + $"\nстипуха: {scolarShip}";
            return inf;
        }
    }

}
